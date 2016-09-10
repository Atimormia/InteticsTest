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
    /// Interaction logic for NewOrder.xaml
    /// </summary>
    public partial class NewOrder : Window
    {
        int idClient = -1;
        public NewOrder()
        {
            InitializeComponent();
        }

        private void chooseClient_Click(object sender, RoutedEventArgs e)
        {
            ClientCard window = new ClientCard(this);
            window.Show();
        }

        private void chooseCar_Click(object sender, RoutedEventArgs e)
        {
            CarsList window = new CarsList();
            window.Show();
        }

        public void GetClientData(int id, string name, string surname)
        {
            idClient = id;
            clientName.Text = name;
            clientSurname.Text = surname;
        }
    }
}
