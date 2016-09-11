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

        bool hasEmptyData = true;

        public Order() { }

        public Order(DataRowView row)
        {
            if (row["id_order"].ToString() != "" && row["id_car"].ToString() != "" && row["id_client"].ToString() != "")
            {
                id = Int32.Parse(row["id_order"].ToString());
                date = DateTime.Parse(row["date"].ToString());
                SetAmount(row["amount"].ToString());
                status = row["status"].ToString();
                clientId = Int32.Parse(row["id_client"].ToString());
                carId = Int32.Parse(row["id_car"].ToString());

                hasEmptyData = false;
            }
            else
            {
                MessageBox.Show("Enter order data", "Order", MessageBoxButton.OK, MessageBoxImage.Warning);
                hasEmptyData = true;
            }
        }

        public bool HasEmptyIds()
        {
            if (id == -1 || carId ==null || clientId==null || carId == -1 || clientId == -1)
            { 
                return true;
            }
            return hasEmptyData;
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
