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
        int clientId = -1;
        NewOrder newOrderWindow;

        public CarsList(NewOrder parent,int clientId, string clientName, string clientSurname)
        {
            InitializeComponent();

            newOrderWindow = parent;
            this.clientId = clientId;
            this.clientName.Text = clientName;
            this.clientSurname.Text = clientSurname;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            InteticsTest.ServiceStationDataSet serviceStationDataSet = ((InteticsTest.ServiceStationDataSet)(this.FindResource("serviceStationDataSet")));
            // Load data into the table Client. You can modify this code as needed.
            InteticsTest.ServiceStationDataSetTableAdapters.CarTableAdapter serviceStationDataSetCarTableAdapter = new InteticsTest.ServiceStationDataSetTableAdapters.CarTableAdapter();
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
    }
}
