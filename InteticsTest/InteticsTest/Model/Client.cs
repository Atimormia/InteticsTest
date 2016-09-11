using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InteticsTest.Model
{
    public class Client
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime? dateOfBirth { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public MailAddress email { get; set; }

        bool hasEmptyData = true;

        public Client() {  }

        public Client(DataRowView row)
        {
            if (row["id_client"].ToString() != "" && row["first_name"].ToString() != "" && row["last_name"].ToString() != "")
            {
                id = Int32.Parse(row["id_client"].ToString());
                firstName = row["first_name"].ToString();
                lastName = row["last_name"].ToString();
                dateOfBirth = DateTime.Parse(row["date_of_birth"].ToString());
                address = row["address"].ToString();
                phone = row["phone"].ToString();
                try
                {
                    email = new MailAddress(row["clientId"].ToString());
                }
                catch
                {
                    email = null;
                }
                hasEmptyData = false;
            }
            else
            {
                MessageBox.Show("Enter client data", "Client", MessageBoxButton.OK, MessageBoxImage.Warning);
                hasEmptyData = true;
            }
        }

        public bool HasEmptyData()
        {
            return hasEmptyData;
        }
    }
}
