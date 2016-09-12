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
    /// Interaction logic for OrdersList.xaml
    /// </summary>
    public partial class OrdersList : Window
    {
        OrderRepository repository;

        public OrdersList()
        {
            InitializeComponent();
            ServiceStationDataSet serviceStationDataSet = ((ServiceStationDataSet)(this.FindResource("serviceStationDataSet")));
            repository = new OrderRepository(serviceStationDataSet);
        }

        public void ReloadData()
        {
            repository.FillOrdersList();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            repository.FillOrdersList();
        }

        private void addOrder_Click(object sender, RoutedEventArgs e)
        {
            NewOrder newOrderWindow = new NewOrder(this);
            newOrderWindow.Show();
        }

        private void editOrder_Click(object sender, RoutedEventArgs e)
        {
            DataRowView currentRow = (DataRowView)this.orderDataGrid.SelectedItem;
            Order order = new Order(currentRow);
            if (!repository.ValidImportOrder(order)) return;

            NewOrder newOrderWindow = new NewOrder(this);
            newOrderWindow.SetClientData(ComposeClient(currentRow));
            newOrderWindow.SetCarData(ComposeCar(currentRow));
            newOrderWindow.SetOrderData(order);
            newOrderWindow.Show();
        }

        private Client ComposeClient(DataRowView row)
        {
            Client client = new Client();
            client.id = Int32.Parse(row["id_client"].ToString());

            string[] names = row["client"].ToString().Split(' ');
            client.firstName = names[0];
            client.lastName = names[1];

            return client;
        }

        private Car ComposeCar(DataRowView row)
        {
            Car car = new Car();
            car.id = Int32.Parse(row["id_car"].ToString());
            car.vin = row["car"].ToString();

            return car;
        }

        private void deleteOrder_Click(object sender, RoutedEventArgs e)
        {
            DataRowView currentRow = (DataRowView)this.orderDataGrid.SelectedItem;

            if (repository.Delete(new Order(currentRow)))
            {
                ReloadData();
            }
        }

        private void showAll_Click(object sender, RoutedEventArgs e)
        {
            ReloadData();
        }
        
        private void find_Click(object sender, RoutedEventArgs e)
        {
            repository.FillOrdersListByCar(new Car(id: -1, vin: carVinFind.Text));
        }
    }
}
