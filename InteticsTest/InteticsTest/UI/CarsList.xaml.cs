using InteticsTest.Model;
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

        CarRepository repository;

        public CarsList()
        {
            InitializeComponent();

            ServiceStationDataSet serviceStationDataSet = ((ServiceStationDataSet)(this.FindResource("serviceStationDataSet")));
            repository = new CarRepository(serviceStationDataSet);
        }

        public CarsList(Client client):this()
        {
            this.clientId = client.id;
            this.clientName.Text = client.firstName;
            this.clientSurname.Text = client.lastName;
        }

        public CarsList(NewOrder parent, Client client):this(client)
        {
            newOrderWindow = parent;
            chooseCar.IsEnabled = true;
        }

        public void ReloadData()
        {
            repository.FillCarsListByClient(new Client(id: clientId));
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ReloadData();
            CollectionViewSource carViewSource = ((CollectionViewSource)(this.FindResource("carViewSource")));
            carViewSource.View.MoveCurrentToFirst();
        }

        private void chooseCar_Click(object sender, RoutedEventArgs e)
        {
            DataRowView currentRow = (DataRowView)this.carDataGrid.SelectedItem;

            Car car = new Car(currentRow);
            if (!repository.ValidImportCar(car)) return;

            newOrderWindow.SetCarData(new Car(currentRow));

            this.Close();
        }

        private void addCar_Click(object sender, RoutedEventArgs e)
        {
            DataRowView row = (DataRowView)carDataGrid.Items[carDataGrid.Items.Count - 2];
            row["id_client"] = clientId;
            
            repository.Insert(new Car(row));
            ReloadData();
        }

        private void editCar_Click(object sender, RoutedEventArgs e)
        {
            DataRowView row = (DataRowView)carDataGrid.SelectedItem;
            row["id_client"] = clientId;
           
            repository.Update(new Car(row));
            ReloadData();
        }

        private void deleteCar_Click(object sender, RoutedEventArgs e)
        {
            DataRowView row = (DataRowView)carDataGrid.SelectedItem;
            row["id_client"] = clientId;            

            repository.Delete(new Car(row));
            ReloadData();
        }
    }
}
