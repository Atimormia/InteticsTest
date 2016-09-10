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
        InteticsTest.ServiceStationDataSet serviceStationDataSet;
        InteticsTest.ServiceStationDataSetTableAdapters.OrderTableAdapter serviceStationDataSetOrderTableAdapter;

        public OrdersList()
        {
            InitializeComponent();

            serviceStationDataSet = ((InteticsTest.ServiceStationDataSet)(this.FindResource("serviceStationDataSet")));
            serviceStationDataSetOrderTableAdapter = new InteticsTest.ServiceStationDataSetTableAdapters.OrderTableAdapter();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            serviceStationDataSetOrderTableAdapter.FillWithCarClientData(serviceStationDataSet.Order);
            System.Windows.Data.CollectionViewSource orderViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("orderViewSource")));
            orderViewSource.View.MoveCurrentToFirst();
        }

        private void addOrder_Click(object sender, RoutedEventArgs e)
        {
            NewOrder newOrderWindow = new NewOrder(this);
            newOrderWindow.Show();
        }

        private void editOrder_Click(object sender, RoutedEventArgs e)
        {
            DataRowView currentRow = (DataRowView)this.orderDataGrid.SelectedItem;
            if (currentRow == null)
            {
                MessageBox.Show("Error","Error",MessageBoxButton.OK,MessageBoxImage.Error);
                return;
            }
            string[] client = currentRow["client"].ToString().Split(' ');

            NewOrder newOrderWindow = new NewOrder(this);
            newOrderWindow.SetClientData(Int32.Parse(currentRow["id_client"].ToString()), client[0], client[1]);
            newOrderWindow.SetCarData(Int32.Parse(currentRow["id_car"].ToString()), currentRow["car"].ToString());
            newOrderWindow.SetOrderData(DateTime.Parse(currentRow["date"].ToString()), Double.Parse(currentRow["amount"].ToString()), currentRow["status"].ToString());
            newOrderWindow.Show();
        }

        private void deleteOrder_Click(object sender, RoutedEventArgs e)
        {
            DataRowView currentRow = (DataRowView)this.orderDataGrid.SelectedItem;

            if (serviceStationDataSetOrderTableAdapter.DeleteById(Int32.Parse(currentRow["id_order"].ToString())) > 0)
            {
                MessageBox.Show("Success");
                ReloadData();
            }
        }

        private void showAll_Click(object sender, RoutedEventArgs e)
        {
            ReloadData();
        }

        public void ReloadData()
        {
            serviceStationDataSetOrderTableAdapter.FillWithCarClientData(serviceStationDataSet.Order);
        }

        private void find_Click(object sender, RoutedEventArgs e)
        {
            serviceStationDataSetOrderTableAdapter.FillByVin(serviceStationDataSet.Order, carVinFind.Text);
        }
    }
}
