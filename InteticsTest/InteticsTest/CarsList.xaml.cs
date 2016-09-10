using System;
using System.Collections.Generic;
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
        public CarsList()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            InteticsTest.ServiceStationDataSet serviceStationDataSet = ((InteticsTest.ServiceStationDataSet)(this.FindResource("serviceStationDataSet")));
            // Load data into the table Client. You can modify this code as needed.
            InteticsTest.ServiceStationDataSetTableAdapters.CarTableAdapter serviceStationDataSetCarTableAdapter = new InteticsTest.ServiceStationDataSetTableAdapters.CarTableAdapter();
            serviceStationDataSetCarTableAdapter.Fill(serviceStationDataSet.Car);
            System.Windows.Data.CollectionViewSource carViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("carViewSource")));
            carViewSource.View.MoveCurrentToFirst();
        }
    }
}
