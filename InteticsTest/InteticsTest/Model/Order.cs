using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InteticsTest.Model
{
    public class Order: Entity
    {
        //public int id { get; set; }
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
            this.id = id;
            this.date = date;
            if (ValidateAmount(amount)) this.amount = amount;
            this.status = status;
            this.carId = carId;
            this.clientId = clientId;
        }

        public Order(string id = "",
            string date = "",
            string amount = "",
            string status = "",
            string carId = "",
            string clientId = "") : this(ParseId(id), ParseDate(date), ParseAmount(amount),status,ParseId(carId),ParseId(clientId))
        { }

        public Order(DataRowView row):this(row["id_order"].ToString(),
                    row["date"].ToString(),
                    row["amount"].ToString(),
                    row["status"].ToString(),
                    row["id_client"].ToString(),
                    row["id_car"].ToString())
        { }
        
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

        public static double? ParseAmount(string amount)
        {
            if (ValidateAmount(amount))
            {
                return Double.Parse(amount);
            }
            else
            {
                return null;
            }
        }

        public override bool HasEmptyData()
        {
            if (date ==null || amount == null || status == null || status == "")
            {
                return true;
            }
            return false;
        }
    }
}
