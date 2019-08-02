using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeModel
{
   public static  class DataContext
    {
        static DataContext()
        {
            Employees = new List<IEmployee>();

            IManager manager1 = new Manager(1);
            manager1.email = "manager1@esspl.com";
            manager1.name = "Test Manager1";
            Employees.Add(manager1);

            IManager manager2 = new Manager(2);
            manager2.email = "manager2@esspl.com";
            manager2.name = "Test Manager2";
            Employees.Add(manager2);

           
        }
        public static List<IEmployee> Employees { get; private set; }
    }
}
