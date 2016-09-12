using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InteticsTest.Model
{
    public class Order
    {
        public int id { get; set; }
        public DateTime? date { get; set; }
        public double? amount { get; set; }
        public string status { get; set; }
        public int? carId { get; set; }
        public int? clientId { get; set; }

        public Order() { }

        public Order(int id = -1,
            DateTime? date = null,
            double? amount = null,
            string status = "",
            int? carId = -1,
            int? clientId = -1)
        {
            CreateOrder(id,date,amount,status,carId,clientId);
        }

        public Order(string id = "",
            string date = "",
            string amount = "",
            string status = "",
            string carId = "",
            string clientId = "")
        {
            CreateOrder(id, date, amount, status, carId, clientId);
        }

        public Order(DataRowView row)
        {
            CreateOrder(row);
        }

        private void CreateOrder(int id = -1,
            DateTime? date = null,
            double? amount = null,
            string status = "",
            int? carId = -1,
            int? clientId = -1)
        {
            this.id = id;
            this.date = date;
            if (ValidateAmount(amount)) this.amount = amount;
            this.status = status;
            this.carId = carId;
            this.clientId = clientId;
        }

        private void CreateOrder(string id = "",
            string date = "",
            string amount = "",
            string status = "",
            string carId = "",
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
            DateTime? d;
            try
            {
                d = DateTime.Parse(date);
            }
            catch
            {
                d = null;
            }
            double? a = null;
            if (ValidateAmount(amount))
            {
                a = Double.Parse(amount);
            }
            int cl;
            try
            {
                cl = Int32.Parse(clientId);
            }
            catch
            {
                cl = -1;
            }
            int c;
            try
            {
                c = Int32.Parse(carId);
            }
            catch
            {
                c = -1;
            }
            CreateOrder(i, d, a, status, c, cl);
        }

        private void CreateOrder(DataRowView row)
        {
            if (row != null)
            {
                CreateOrder(row["id_order"].ToString(),
                    row["date"].ToString(),
                    row["amount"].ToString(),
                    row["status"].ToString(),
                    row["id_client"].ToString(),
                    row["id_car"].ToString());
            }
            else
            {
                MessageBox.Show("Error", "Order", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public bool HasEmptyIds()
        {
            if (carId ==null || clientId==null || carId == -1 || clientId == -1)
            { 
                return true;
            }
            return false;
        }

        public static bool ValidateAmount(double? amount)
        {
            if (amount <= 0)
            {
                MessageBox.Show("Amount not valid", "Order", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }

        public static bool ValidateAmount(string amount)
        {
            double a;
            return Double.TryParse(amount,out a) && ValidateAmount(a);
        }

        public void SetAmount(string amount)
        {
            if (ValidateAmount(amount))
            {
                this.amount = Double.Parse(amount);
            }
            else
            {
                this.amount = null;
            }
        }

        public bool HasEmptyData()
        {
            if (date ==null || amount == null || status == null || status == "")
            {
                return true;
            }
            return false;
        }
    }
}
