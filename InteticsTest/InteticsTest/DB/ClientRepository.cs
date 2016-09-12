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
        ClientTableAdapter serviceStationDataSetClientTableAdapter = new ClientTableAdapter();

        ServiceStationDataSet serviceStationDataSet;

        public ClientRepository() { }

        public ClientRepository(ServiceStationDataSet dataSet)
        {
            serviceStationDataSet = dataSet;
        }

        public bool ValidImportClient(Client client)
        {
            if (client == null)
            {
                MessageBox.Show("Error", "Operation with data", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }

        private bool ClientHasEmptyData(Client client)
        {
            if (client.HasEmptyData())
            {
                MessageBox.Show("Enter Client data", "ClientsList", MessageBoxButton.OK, MessageBoxImage.Warning);
                return true;
            }
            return false;
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
            if (ValidImportClient(client) &&
                !ClientHasEmptyData(client) && serviceStationDataSetClientTableAdapter.Insert(client.firstName, client.lastName, client.dateOfBirth, client.address, client.phone, client.email.ToString()) > 0)
            {
                MessageBox.Show("Success", "Operation with data", MessageBoxButton.OK, MessageBoxImage.Information);
                return true;
            }

            return false;
        }

        public int FillClientsList()
        {
            return serviceStationDataSetClientTableAdapter.Fill(serviceStationDataSet.Client);
        }

        public int FillClientsListByNameSuname(Client client)
        {
            return serviceStationDataSetClientTableAdapter.FillByNameSurname(serviceStationDataSet.Client, client.firstName, client.lastName);
        }
    }
}
