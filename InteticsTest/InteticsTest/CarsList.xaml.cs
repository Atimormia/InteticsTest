using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace InteticsTest
{
    /// <summary>
    /// Interaction logic for CarsList.xaml
    /// </summary>
    public partial class CarsList : Window
    {
        InteticsTest.ServiceStationDataSet serviceStationDataSet;
        InteticsTest.ServiceStationDataSetTableAdapters.CarTableAdapter serviceStationDataSetCarTableAdapter;

        int clientId = -1;
        NewOrder newOrderWindow;

        public CarsList()
        {
            InitializeComponent();

            serviceStationDataSet = ((InteticsTest.ServiceStationDataSet)(this.FindResource("serviceStationDataSet")));
            serviceStationDataSetCarTableAdapter = new InteticsTest.ServiceStationDataSetTableAdapters.CarTableAdapter();
        }

        public CarsList(int clientId, string clientName, string clientSurname):this()
        {
            this.clientId = clientId;
            this.clientName.Text = clientName;
            this.clientSurname.Text = clientSurname;
        }

        public CarsList(NewOrder parent,int clientId, string clientName, string clientSurname):this(clientId,clientName,clientSurname)
        {
            newOrderWindow = parent;
            chooseCar.IsEnabled = true;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            serviceStationDataSetCarTableAdapter.FillByClientId(serviceStationDataSet.Car,clientId);
            System.Windows.Data.CollectionViewSource carViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("carViewSource")));
            carViewSource.View.MoveCurrentToFirst();
        }

        private void chooseCar_Click(object sender, RoutedEventArgs e)
        {
            DataRowView currentRow = (DataRowView)this.carDataGrid.SelectedItem;

            int id = Int32.Parse(currentRow[0].ToString());
            string vin = currentRow[4].ToString();
            newOrderWindow.GetCarData(id,vin);

            this.Close();
        }

        private void addCar_Click(object sender, RoutedEventArgs e)
        {
            DataRowView row = (DataRowView)carDataGrid.Items[carDataGrid.Items.Count - 2];
            for (int i = 1; i < row.Row.Table.Columns.Count-1; i++)
            {
                MessageBox.Show(row[i].ToString());
                if (row[i].ToString() == "")
                {
                    MessageBox.Show("Enter car data","CarsList",MessageBoxButton.OK,MessageBoxImage.Warning);
                    return;
                }
            }
            if (serviceStationDataSetCarTableAdapter.Insert(row[1].ToString(), row[2].ToString(), Int32.Parse(row[3].ToString()), row[4].ToString(), clientId) > 0)
            {
                MessageBox.Show("Success");
                serviceStationDataSetCarTableAdapter.FillByClientId(serviceStationDataSet.Car, clientId);
            }
        }

        private void editCar_Click(object sender, RoutedEventArgs e)
        {
            DataRowView row = (DataRowView)carDataGrid.SelectedItem;
            if (serviceStationDataSetCarTableAdapter.UpdateByCarId(row[1].ToString(), row[2].ToString(), Int32.Parse(row[3].ToString()), row[4].ToString(), clientId, Int32.Parse(row[0].ToString())) > 0)
            {
                MessageBox.Show("Success");
                serviceStationDataSetCarTableAdapter.FillByClientId(serviceStationDataSet.Car, clientId);
            }
        }

        private void deleteCar_Click(object sender, RoutedEventArgs e)
        {
            DataRowView row = (DataRowView)carDataGrid.SelectedItem;
            int carId = Int32.Parse(row[0].ToString());
            int ordersCount = (int)serviceStationDataSetCarTableAdapter.CountOrdersByClientId(carId);

            if (ordersCount == 0)
            {
                if (serviceStationDataSetCarTableAdapter.DeleteByCarId(carId) > 0)
                {
                    MessageBox.Show("Success");
                    serviceStationDataSetCarTableAdapter.FillByClientId(serviceStationDataSet.Car, clientId);
                }
            }
        }
    }
}
