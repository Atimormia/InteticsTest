using InteticsTest.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteticsTest.Factory
{
    public class ClientCreator : Creator
    {
        public override Entity Create()
        {
            return new Client();
        }

        public Client Create(int id = -1,
            string firstName = "",
            string lastName = "",
            DateTime? date = null,
            string address = "",
            string phone = "",
            string email = "")
        {
            return new Client(id, firstName, lastName, date, address, phone, email);
        }

        public Client Create(string id = "",
            string firstName = "",
            string lastName = "",
            string date = "",
            string address = "",
            string phone = "",
            string email = "")
        {

            return new Client(id, firstName, lastName, date, address, phone, email);
        }

        public override Entity Create(DataRowView row)
        {
            if (row != null)
            {
                return new Client(row);
            }
            else
            {
                throw new ArgumentNullException("Error, empty data");
            }
        }
    }
}
