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
        public string email { get; set; }

        public Client() {  }

        public Client(int id = -1,
            string firstName = "",
            string lastName = "",
            DateTime? date = null,
            string address = "",
            string phone = "",
            string email = "")
        {
            CreateClient(id, firstName, lastName, date, address, phone, email);
        }

        public Client(string id = "",
            string firstName = "",
            string lastName = "",
            string date = "",
            string address = "",
            string phone = "",
            string email = "")
        {
            CreateClient(id, firstName, lastName, date, address, phone, email);
        }

        public Client(DataRowView row)
        {
            CreateClient(row);
        }
        
        private void CreateClient(int id = -1,
            string firstName = "", 
            string lastName = "", 
            DateTime? date = null, 
            string address = "",
            string phone = "",
            string email = "")
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = date;
            this.address = address;
            this.phone = phone;
            try
            {
                MailAddress em = new MailAddress(email);
                this.email = email;
            }
            catch
            {
                this.email = "";
            }
        }

        private void CreateClient(string id = "",
            string firstName = "",
            string lastName = "",
            string date = "",
            string address = "",
            string phone = "",
            string email = "")

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
            
            CreateClient(i, firstName, lastName, d, address, phone, email);
        }

        private void CreateClient(DataRowView row)
        {
            if (row != null)
            {
                CreateClient(row["id_client"].ToString(),
                 row["first_name"].ToString(),
                 row["last_name"].ToString(),
                 row["date_of_birth"].ToString(),
                 row["address"].ToString(),
                 row["phone"].ToString(),
                 row["email"].ToString());
            }
            else
            {
                MessageBox.Show("Error", "Client", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public bool HasEmptyData()
        {
            if (firstName == "" || lastName == "")
            {
                MessageBox.Show("Enter client data", "Client", MessageBoxButton.OK, MessageBoxImage.Warning);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
