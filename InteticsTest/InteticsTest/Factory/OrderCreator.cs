using InteticsTest.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteticsTest.Factory
{
    public class OrderCreator : Creator
    {
        public override Entity Create()
        {
            return new Order();
        }

        public Order Create(int id = -1,
            DateTime? date = null,
            double? amount = null,
            string status = "",
            int? carId = -1,
            int? clientId = -1)
        {
            return new Order(id, date, amount, status, carId, clientId);
        }

        public Order Create(string id = "",
            string date = "",
            string amount = "",
            string status = "",
            string carId = "",
            string clientId = "")
        {

            return new Order(id, date, amount, status, carId, clientId);
        }

        public override Entity Create(DataRowView row)
        {
            if (row != null)
            {
                return new Order(row);
            }
            else
            {
                throw new ArgumentNullException("Error, empty data");
            }
        }
    }
}
