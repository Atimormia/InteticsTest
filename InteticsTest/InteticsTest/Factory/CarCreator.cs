using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InteticsTest.Model;
using System.Data;

namespace InteticsTest.Factory
{
    public class CarCreator: Creator
    {
        public override Entity Create()
        {
            return new Car();
        }

        public Car Create(int id = -1,
            string make = "",
            string model = "",
            int? year = null,
            string vin = "",
            int? clientId = -1)
        {
            return new Car(id, make, model, year, vin, clientId);
        }
        
        public Car Create(string id = "",
            string make = "",
            string model = "",
            string year = "",
            string vin = "",
            string clientId = "")
        {
           
            return new Car(id, make, model, year, vin, clientId);
        }

        public override Entity Create(DataRowView row)
        {
            if (row != null)
            {
                return new Car(row);
            }
            else
            {
                throw new ArgumentNullException("Error, empty data");
            }
        }
    }
}
