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
    public class Client:Entity
    {
        //public int id { get; set; }
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
        
        public Client(string id = "",
            string firstName = "",
            string lastName = "",
            string date = "",
            string address = "",
            string phone = "",
            string email = "") : this(ParseId(id), firstName, lastName, ParseDate(date), address, phone, email)
        { }

        public Client(DataRowView row): this(row["id_client"].ToString(),
                 row["first_name"].ToString(),
                 row["last_name"].ToString(),
                 row["date_of_birth"].ToString(),
                 row["address"].ToString(),
                 row["phone"].ToString(),
                 row["email"].ToString())
        { }
        
        public override bool HasEmptyData()
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
