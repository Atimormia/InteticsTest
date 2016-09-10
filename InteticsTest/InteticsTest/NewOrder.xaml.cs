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
    /// Interaction logic for NewOrder.xaml
    /// </summary>
    public partial class NewOrder : Window
    {
        InteticsTest.ServiceStationDataSet serviceStationDataSet;
        InteticsTest.ServiceStationDataSetTableAdapters.OrderTableAdapter serviceStationDataSetOrderTableAdapter;

        int clientId = -1;
        int carId = -1;
        OrdersList ordersListWindow;
        
        public NewOrder()
        {
            InitializeComponent();

            serviceStationDataSet = ((InteticsTest.ServiceStationDataSet)(this.FindResource("serviceStationDataSet")));
            serviceStationDataSetOrderTableAdapter = new InteticsTest.ServiceStationDataSetTableAdapters.OrderTableAdapter();
        }

        public NewOrder(OrdersList parent) : this()
        {
            ordersListWindow = parent;
        }

        private void chooseClient_Click(object sender, RoutedEventArgs e)
        {
            ClientCard window = new ClientCard(this);
            window.Show();
        }

        private void chooseCar_Click(object sender, RoutedEventArgs e)
        {
            if (clientId != -1)
            {
                CarsList window = new CarsList(this,clientId, clientName.Text, clientSurname.Text);
                window.Show();
            }
            else
            {
                MessageBox.Show("Choose client at first", "New Order", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        public void SetClientData(int id, string name, string surname)
        {
            clientId = id;
            clientName.Text = name;
            clientSurname.Text = surname;
        }

        public void SetCarData(int id,string vin)
        {
            carId = id;
            carVIN.Text = vin;
        }

        public void SetOrderData(DateTime date, double amount, string status)
        {
            orderDate.SelectedDate = date;
            orderAmount.Text = amount.ToString();
            for (int i = 0; i < orderStatus.Items.Count; i++)
            {
                ComboBoxItem item = (ComboBoxItem)orderStatus.Items[i];
                if (item.Content.ToString().ToLower() == status.ToLower())
                {
                    orderStatus.SelectedIndex = i;
                }
            }

        }

        private void addOrder_Click(object sender, RoutedEventArgs e)
        {
            if (clientId == -1 || carId== -1 || orderDate.SelectedDate == null || orderAmount.Text == "" || orderStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Enter order data", "New Order", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            double amount = Double.Parse(orderAmount.Text);
            if (amount <= 0)
            {
                MessageBox.Show("Amount not valid", "New Order", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (serviceStationDataSetOrderTableAdapter.Insert(orderDate.SelectedDate, amount, orderStatus.Text, carId, clientId) > 0)
            {
                MessageBox.Show("Success");
                ordersListWindow.ReloadData();
                Close();
            }

        }
    }
}
