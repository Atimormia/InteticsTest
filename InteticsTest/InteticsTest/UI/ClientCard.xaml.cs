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
using System.Data.Objects;
using InteticsTest.Model;

namespace InteticsTest
{
    /// <summary>
    /// Interaction logic for ClientCard.xaml
    /// </summary>
    public partial class ClientCard : Window
    {
        NewOrder newOrderWindow;

        ClientRepository repository;

        public ClientCard()
        {
            InitializeComponent();

            ServiceStationDataSet serviceStationDataSet = ((ServiceStationDataSet)(this.FindResource("serviceStationDataSet")));
            repository = new ClientRepository(serviceStationDataSet);
        }

        public ClientCard(NewOrder parent):this()
        {
            newOrderWindow = parent;
            relatedCars.IsEnabled = false;
            chooseClient.IsEnabled = true;
        }

        public void ReloadData()
        {
            repository.FillClientsList();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ReloadData();
            CollectionViewSource clientViewSource = ((CollectionViewSource)(this.FindResource("clientViewSource")));
            clientViewSource.View.MoveCurrentToFirst();
        }

        private void find_Click(object sender, RoutedEventArgs e)
        {
            repository.FillClientsListByNameSuname(new Client(id: -1, firstName: nameClient.Text, lastName: surnameClient.Text));
            if (clientDataGrid.Items.Count == 1)
            {
                MessageBox.Show("There are nothing to show. To add client enter information and click Add button","Nothing to show",MessageBoxButton.OK,MessageBoxImage.Information);
            }
        }

        private void addClient_Click(object sender, RoutedEventArgs e)
        {
            DataRowView row = (DataRowView)clientDataGrid.Items[clientDataGrid.Items.Count-2];

            repository.Insert(new Client(row));
            ReloadData();
        }

        private void showAll_Click(object sender, RoutedEventArgs e)
        {
            ReloadData();
        }

        private Client GetClientDataFromCurrentRow()
        {
            DataRowView currentRow = (DataRowView)this.clientDataGrid.SelectedItem;
            try
            {
                return new Client(currentRow);
            }
            catch
            {
                return null;
            }            
        }

        private void chooseClient_Click(object sender, RoutedEventArgs e)
        {
            Client client = GetClientDataFromCurrentRow();
            if (!repository.ValidImportClient(client)) return;
            newOrderWindow.SetClientData(client);

            this.Close();
        }

        private void relatedCars_Click(object sender, RoutedEventArgs e)
        {
            Client client = GetClientDataFromCurrentRow();
            if (!repository.ValidImportClient(client)) return;

            CarsList carsListWindow = new CarsList(client);
            carsListWindow.Show();
        }
    }
}
