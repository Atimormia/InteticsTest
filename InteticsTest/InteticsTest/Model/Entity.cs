using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteticsTest.Model
{
    abstract public class Entity
    {
        public int id { get; set; }

        protected static int ParseId(string id)
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
            return i;
        }

        protected static DateTime? ParseDate(string date)
        {
            DateTime? d;
            try
            {
                d = DateTime.Parse(date);
            }
            catch
            {
                d = null;
            }
            return d;
        }

        abstract public bool HasEmptyData();
    }
}
