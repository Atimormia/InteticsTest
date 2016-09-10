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
    /// Interaction logic for ClientCard.xaml
    /// </summary>
    public partial class ClientCard : Window
    {
        InteticsTest.ServiceStationDataSet serviceStationDataSet;
        InteticsTest.ServiceStationDataSetTableAdapters.ClientTableAdapter serviceStationDataSetClientTableAdapter;

        NewOrder newOrderWindow;

        public ClientCard()
        {
            InitializeComponent();
            
            serviceStationDataSet = ((InteticsTest.ServiceStationDataSet)(this.FindResource("serviceStationDataSet")));
            serviceStationDataSetClientTableAdapter = new InteticsTest.ServiceStationDataSetTableAdapters.ClientTableAdapter();
        }

        public ClientCard(NewOrder parent):this()
        {
            newOrderWindow = parent;
            relatedCars.IsEnabled = false;
            chooseClient.IsEnabled = true;
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void dataGrid_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            serviceStationDataSetClientTableAdapter.Fill(serviceStationDataSet.Client);
            System.Windows.Data.CollectionViewSource clientViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("clientViewSource")));
            clientViewSource.View.MoveCurrentToFirst();
        }

        private void find_Click(object sender, RoutedEventArgs e)
        {
            serviceStationDataSetClientTableAdapter.FillByNameSurname(serviceStationDataSet.Client,nameClient.Text,surnameClient.Text);
            if (clientDataGrid.Items.Count == 1)
            {
                MessageBox.Show("There are nothing to show. To add client enter information and click Add button","Nothing to show",MessageBoxButton.OK,MessageBoxImage.Information);
            }
        }

        private void addClient_Click(object sender, RoutedEventArgs e)
        {
            DataRowView row = (DataRowView)clientDataGrid.Items[clientDataGrid.Items.Count-2];
            if (row == null)
            {
                MessageBox.Show("Error", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            DateTime date = new DateTime();
            if (DateTime.TryParse(row[3].ToString(), out date))
                serviceStationDataSetClientTableAdapter.Insert(row[1].ToString(), row[2].ToString(), date, row[4].ToString(), row[5].ToString(), row[6].ToString());
            else
                serviceStationDataSetClientTableAdapter.Insert(row[1].ToString(), row[2].ToString(), null, row[4].ToString(), row[5].ToString(), row[6].ToString());
        }

        private void showAll_Click(object sender, RoutedEventArgs e)
        {
            serviceStationDataSetClientTableAdapter.Fill(serviceStationDataSet.Client);
        }

        private void GetClientDataFromCurrentRow(out int id, out string name, out string surname)
        {
            DataRowView currentRow = (DataRowView)this.clientDataGrid.SelectedItem;
            
            id = Int32.Parse(currentRow[0].ToString());
            name = currentRow[1].ToString();
            surname = currentRow[2].ToString();

            if (currentRow == null)
            {
                MessageBox.Show("Error", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }

        private void chooseClient_Click(object sender, RoutedEventArgs e)
        {
            int id;
            string name;
            string surname;
            GetClientDataFromCurrentRow(out id, out name, out surname);
            newOrderWindow.SetClientData(id, name, surname);

            this.Close();
        }

        private void relatedCars_Click(object sender, RoutedEventArgs e)
        {
            int id;
            string name;
            string surname;
            GetClientDataFromCurrentRow(out id, out name, out surname);

            CarsList carsListWindow = new CarsList(id, name, surname);
            carsListWindow.Show();
        }
    }
}
