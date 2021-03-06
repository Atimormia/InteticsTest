﻿using InteticsTest.ServiceStationDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static InteticsTest.ServiceStationDataSet;

namespace InteticsTest.Model
{
    class OrderRepository
    {
        OrderTableAdapter serviceStationDataSetOrderTableAdapter = new OrderTableAdapter();
        ServiceStationDataSet serviceStationDataSet;

        public OrderRepository() { }

        public OrderRepository(ServiceStationDataSet dataSet)
        {
            serviceStationDataSet = dataSet;
        }

        public bool ValidImportOrder(Order order)
        {
            if (order == null)
            {
                MessageBox.Show("Error", "Operation with data", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }

        private bool OrderHasEmptyData(Order order)
        {
            if (order.HasEmptyIds() || order.HasEmptyData())
            {
                MessageBox.Show("Enter order data", "OrdersList", MessageBoxButton.OK, MessageBoxImage.Warning);
                return true;
            }
            return false;
        }

        public OrderDataTable GetAll()
        {
            return serviceStationDataSetOrderTableAdapter.GetData();
        }

        public bool Delete(Order order)
        {
            if (!ValidImportOrder(order)) return false;
            
            if (serviceStationDataSetOrderTableAdapter.DeleteById(order.id) > 0)
            {
                MessageBox.Show("Success", "Operation with data", MessageBoxButton.OK, MessageBoxImage.Information);
                return true;
            }
            
            return false;
        }

        public OrderDataTable GetOrderByCar(Car car)
        {
            return serviceStationDataSetOrderTableAdapter.GetDataByVin(car.vin);
        }

        public bool Update(Order order)
        {
            if (!ValidImportOrder(order) || OrderHasEmptyData(order)) return false;

            if (serviceStationDataSetOrderTableAdapter.UpdateById(order.date,order.amount,order.status,order.carId,order.clientId,order.id) > 0)
            {
                MessageBox.Show("Success", "Operation with data", MessageBoxButton.OK, MessageBoxImage.Information);
                return true;
            }
            return false;
        }

        public bool Insert(Order order)
        {
            if (!ValidImportOrder(order) || OrderHasEmptyData(order)) return false;

            if (serviceStationDataSetOrderTableAdapter.Insert(order.date, order.amount, order.status, order.carId, order.clientId) > 0)
            {
                MessageBox.Show("Success", "Operation with data", MessageBoxButton.OK, MessageBoxImage.Information);
                return true;
            }
            return true;
        }

        public int FillOrdersList()
        {
            return serviceStationDataSetOrderTableAdapter.FillWithCarClientData(serviceStationDataSet.Order);
        }

        public int FillOrdersListByCar(Car car)
        {
            return serviceStationDataSetOrderTableAdapter.FillByVin(serviceStationDataSet.Order,car.vin);
        }
    }
}
