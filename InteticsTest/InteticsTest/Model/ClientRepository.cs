using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InteticsTest.ServiceStationDataSetTableAdapters;
using InteticsTest;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Data.Objects;
using static InteticsTest.ServiceStationDataSet;
using System.Windows;

namespace InteticsTest.Model
{
    public class ClientRepository
    {
        ClientTableAdapter serviceStationDataSetClientTableAdapter;

        public ClientRepository()
        {
            serviceStationDataSetClientTableAdapter = new ClientTableAdapter();
            serviceStationDataSetClientTableAdapter.Connection.ConnectionString = ConfigurationManager.ConnectionStrings["InteticsTest.Properties.Settings.ServiceStationConnectionString"].ConnectionString;
        }

        public ClientDataTable GetClientByNameSurname(Client client)
        {
            return serviceStationDataSetClientTableAdapter.GetDataByNameSurname(client.firstName, client.lastName);
        }

        public ClientDataTable GetAllClients()
        {
            return serviceStationDataSetClientTableAdapter.GetData();
        }

        public bool Insert(Client client)
        {
            if (client == null)
            {
                MessageBox.Show("Error", "Operation with data", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            if (serviceStationDataSetClientTableAdapter.Insert(client.firstName, client.lastName, client.dateOfBirth, client.address, client.phone, client.email.ToString()) > 0)
            {
                MessageBox.Show("Success", "Operation with data", MessageBoxButton.OK, MessageBoxImage.Information);
                return true;
            }

            return false;
        }
    }
}
