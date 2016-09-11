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

        bool hasEmptyData = true;

        public Car()
        { }

        public Car(DataRowView row)
        {

            if (row["id_car"].ToString() != "" && row["vin"].ToString() != "" && row["id_client"].ToString() != "")
            {
                id = Int32.Parse(row["id_car"].ToString());
                make = row["make"].ToString();
                model = row["model"].ToString();
                year = Int32.Parse(row["year"].ToString());
                vin = row["vin"].ToString();
                clientId = Int32.Parse(row["id_client"].ToString());
                hasEmptyData = false;
            }
            else
            { 
                MessageBox.Show("Enter car data", "Car", MessageBoxButton.OK, MessageBoxImage.Warning);
                hasEmptyData = true;
            }
            
        }

        public bool HasEmptyData()
        {
            return hasEmptyData;
        }
    }
}
