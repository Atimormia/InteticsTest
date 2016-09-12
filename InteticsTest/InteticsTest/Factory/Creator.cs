using InteticsTest.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteticsTest.Factory
{
    abstract public class Creator
    {
        abstract public Entity Create();
        abstract public Entity Create(DataRowView row);
    }
}
