using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InteticsTest.Model
{
    public class Car: Entity
    {
        //public int id { get; set; }
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
            this.id = id;
            this.make = make;
            this.model = model;
            this.year = year;
            this.vin = vin;
            this.clientId = clientId;
        }
        
        private static int? ParseYear(string year)
        {
            int? y;
            try
            {
                y = Int32.Parse(year);
            }
            catch
            {
                y = null;
            }
            return y;
        }

        public Car(string id = "",
            string make = "",
            string model = "",
            string year = "",
            string vin = "",
            string clientId = ""):this(ParseId(id), make, model, ParseYear(year), vin, ParseId(clientId))
        { }

        public Car(DataRowView row) : this(row["id_car"].ToString(),
                      row["make"].ToString(),
                      row["model"].ToString(),
                      row["year"].ToString(),
                      row["vin"].ToString(),
                      row["id_client"].ToString())
        { }

        public override bool HasEmptyData()
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
