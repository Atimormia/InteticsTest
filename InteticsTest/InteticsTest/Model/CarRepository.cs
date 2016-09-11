using InteticsTest.ServiceStationDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static InteticsTest.ServiceStationDataSet;

namespace InteticsTest.Model
{
    public class CarRepository
    {
        CarTableAdapter serviceStationDataSetCarTableAdapter;
        //ClientDataTable clientTable;

        public CarRepository()
        {
            serviceStationDataSetCarTableAdapter = new CarTableAdapter();
            serviceStationDataSetCarTableAdapter.Connection.ConnectionString = ConfigurationManager.ConnectionStrings["InteticsTest.Properties.Settings.ServiceStationConnectionString"].ConnectionString;

        }

        public CarDataTable GetAllC()
        {
            return serviceStationDataSetCarTableAdapter.GetData();
        }

        public bool Delete(Car car)
        {
            if (car == null)
            {
                MessageBox.Show("Error", "Operation with data", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            int ordersCount = (int)serviceStationDataSetCarTableAdapter.CountOrdersByClientId(car.id);
            if (ordersCount == 0)
            {
                if (serviceStationDataSetCarTableAdapter.DeleteByCarId(car.id) > 0)
                {
                    MessageBox.Show("Success","Operation with data",MessageBoxButton.OK,MessageBoxImage.Information);
                    return true;
                }
            }

            return false;
        }

        public CarDataTable GetCarByClient(Client client)
        {
            return serviceStationDataSetCarTableAdapter.GetDataByClientId(client.id);
        }

        public bool Update(Car car)
        {
            if (car == null)
            {
                MessageBox.Show("Error", "Operation with data", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            if (serviceStationDataSetCarTableAdapter.UpdateByCarId(car.make,car.model,car.year,car.vin,car.clientId,car.id) > 0)
            {
                MessageBox.Show("Success", "Operation with data", MessageBoxButton.OK, MessageBoxImage.Information);
                return true;
            }
            return false;
        }

        public bool Insert(Car car)
        {
            if (car == null)
            {
                MessageBox.Show("Error", "Operation with data", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            if (car.HasEmptyData())
            {
                MessageBox.Show("Enter car data", "CarsList", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }
            
            if (serviceStationDataSetCarTableAdapter.Insert(car.make,car.model,car.year,car.vin,car.clientId) > 0)
            {
                MessageBox.Show("Success", "Operation with data", MessageBoxButton.OK, MessageBoxImage.Information);
                return true;
            }
            return true;
        }
    }
}
