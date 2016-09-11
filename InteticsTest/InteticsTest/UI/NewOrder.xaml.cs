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
    /// Interaction logic for NewOrder.xaml
    /// </summary>
    public partial class NewOrder : Window
    {
        int clientId = -1;
        int carId = -1;
        int orderId = -1;
        OrdersList ordersListWindow;

        OrderRepository repository = new OrderRepository();
        
        public NewOrder()
        {
            InitializeComponent();
            
        }

        public NewOrder(OrdersList parent) : this()
        {
            ordersListWindow = parent;
        }
        
        public void SetClientData(Client client)
        {
            clientId = client.id;
            clientName.Text = client.firstName;
            clientSurname.Text = client.lastName;
        }

        public void SetCarData(Car car)
        {
            carId = car.id;
            carVIN.Text = car.vin;
        }

        public void SetOrderData(Order order)
        {
            orderId = order.id;
            orderDate.SelectedDate = order.date;
            orderAmount.Text = order.amount.ToString();
            for (int i = 0; i < orderStatus.Items.Count; i++)
            {
                ComboBoxItem item = (ComboBoxItem)orderStatus.Items[i];
                if (item.Content.ToString().ToLower() == order.status.ToLower())
                {
                    orderStatus.SelectedIndex = i;
                }
            }

        }

        private void addOrder_Click(object sender, RoutedEventArgs e)
        {
            Order order = ComposeOrder();
            
            if (!Order.ValidateAmount(order.amount))
            {
                return;
            }
            if (order.HasEmptyIds() || order.HasEmptyData())
            {
                MessageBox.Show("Enter order data", "New Order", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            if (ordersListWindow == null)
            {
                repository.Insert(order);
            }
            else
            {
                repository.Update(order);
                ordersListWindow.ReloadData();               
            }
            Close();
        }

        private Order ComposeOrder()
        {
            Order order = new Order();
            order.id = orderId;
            order.date = orderDate.SelectedDate;
            order.SetAmount(orderAmount.Text);
            order.status = orderStatus.Text;
            order.carId = carId;
            order.clientId = clientId;
            return order;
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
    }
}
