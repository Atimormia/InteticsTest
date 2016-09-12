using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InteticsTest.Model
{
    public class Car
    {
        public int id { get; set; }
        public string make { get; set; }
        public string model { get; set; }
        public int? year { get; set; }
        public string vin { get; set; }
        public int? clientId { get; set; }


        public Car()
        { }

        public Car(int id = -1,
            string make = "",
            string model = "",
            int? year = null,
            string vin = "",
            int? clientId = -1)
        {
            CreateCar(id, make, model, year, vin, clientId);
        }

        public Car(string id = "",
            string make = "",
            string model = "",
            string year = "",
            string vin = "",
            string clientId = "")
        {
            CreateCar(id, make, model, year, vin, clientId);
        }

        public Car(DataRowView row)
        {
            CreateCar(row);
        }

        private void CreateCar(int id = -1, 
            string make = "",
            string model = "",
            int? year = null, 
            string vin = "", 
            int? clientId = -1)
        {
            this.id = id;
            this.make = make;
            this.model = model;
            this.year = year;
            this.vin = vin;
            this.clientId = clientId;
        }

        private void CreateCar(string id = "", 
            string make = "", 
            string model = "", 
            string year = "", 
            string vin = "", 
            string clientId = "")
        {
            int i;
            try
            {
                i = Int32.Parse(id);
            }
            catch
            {
                i = -1;
            }
            int? y;
            try
            {
                y = Int32.Parse(year);
            }
            catch
            {
                y = null;
            }
            int? ci;
            try
            {
                ci = Int32.Parse(clientId);
            }
            catch
            {
                ci = -1;
            }

            CreateCar(i, make, model, y, vin, ci);
        }

        private void CreateCar(DataRowView row)
        {
            if (row != null)
            {
                CreateCar(row["id_car"].ToString(),
                      row["make"].ToString(),
                      row["model"].ToString(),
                      row["year"].ToString(),
                      row["vin"].ToString(),
                      row["id_client"].ToString());
            }
            else
            {
                MessageBox.Show("Error", "Car", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public bool HasEmptyData()
        {
            if (vin == "" || clientId == null || clientId == -1)
            {
                MessageBox.Show("Enter car data", "Car", MessageBoxButton.OK, MessageBoxImage.Warning);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
