using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeModel
{
    public static class DataContext
    {
        static DataContext()
        {

            Employees = new List<IEmployee>();            IEmployee manager1 = new Manager(1);            manager1.name = "Test Manager 1";            manager1.email = "manager1@esspl.com";            Employees.Add(manager1);            IEmployee manager2 = new Manager(2);            manager2.name = "Test Manager 2";            manager2.email = "manager2@esspl.com";            Employees.Add(manager2);            IEmployee employee1 = new Employee(3);            employee1.name = "Bishal Dikhit_1";            employee1.email = "bishal@esspl.com";            employee1.ReportingManager = manager1;            Employees.Add(employee1);            IEmployee employee2 = new Employee(4);            employee2.name = "Bishal Dikhit_2";            employee2.email = "bishal@esspl.com";            employee2.ReportingManager = manager1;            Employees.Add(employee2);            //IEmployee employee3 = new Employee(5);

        }
        public static List<IEmployee> Employees { get; private set; }
    }

}
