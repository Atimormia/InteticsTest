﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InteticsTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Close();
        }

        private void newOrder_Click(object sender, RoutedEventArgs e)
        {
            NewOrder newOrderWindow = new NewOrder();
            newOrderWindow.Show();
        }

        private void clientCard_Click(object sender, RoutedEventArgs e)
        {
            ClientCard clientCardWindow = new ClientCard();
            clientCardWindow.Show();

        }

        private void OrdersByCar_Click(object sender, RoutedEventArgs e)
        {
            OrdersList ordersListWindow = new OrdersList();
            ordersListWindow.Show();
        }
    }
}