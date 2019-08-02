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

            Employees = new List<IEmployee>();

            IManager manager1 = new Manager(1);
            manager1.email = "manager1@esspl.com";
            manager1.name = "Test Manager1";
            Employees.Add(manager1);

            IManager manager2 = new Manager(2);
            manager2.email = "manager2@esspl.com";
            manager2.name = "Test Manager2";
            Employees.Add(manager2);

            IEmployee employee1 = new Employee(3);
            employee1.name = "emp1";
            employee1.email = "empl1@esspl.com";
            employee1.ReportingManager = manager1;
            Employees.Add(employee1);

            IEmployee employee2 = new Employee(4);
            employee2.name = "emp2";
            employee2.email = "empl2@esspl.com";
            employee2.ReportingManager = manager1;
            Employees.Add(employee2);

            IEmployee employee3 = new Employee(5);
            employee3.name = "emp3";
            employee3.email = "empl3@esspl.com";
            employee3.ReportingManager = manager1;
            Employees.Add(employee3);

            IEmployee employee4 = new Employee(6);
            employee4.name = "emp4";
            employee4.email = "empl4@esspl.com";
            employee4.ReportingManager = manager1;
            Employees.Add(employee4);

            IEmployee employee5 = new Employee(7);
            employee5.name = "emp5";
            employee5.email = "empl5@esspl.com";
            employee5.ReportingManager = manager1;
            Employees.Add(employee5);

            IEmployee employee6 = new Employee(8);
            employee6.name = "emp6";
            employee6.email = "empl6@esspl.com";
            employee6.ReportingManager = manager1;
            Employees.Add(employee6);

            IEmployee employee7 = new Employee(9);
            employee7.name = "emp7";
            employee7.email = "empl7@esspl.com";
            employee7.ReportingManager = manager2;
            Employees.Add(employee7);

            IEmployee employee8 = new Employee(10);
            employee8.name = "emp8";
            employee8.email = "empl8@esspl.com";
            employee8.ReportingManager = manager2;
            Employees.Add(employee8);

            IEmployee employee9 = new Employee(11);
            employee9.name = "emp9";
            employee9.email = "empl9@esspl.com";
            employee9.ReportingManager = manager2;
            Employees.Add(employee9);

            IEmployee employee10 = new Employee(12);
            employee10.name = "emp10";
            employee10.email = "empl10@esspl.com";
            employee10.ReportingManager = manager2;
            Employees.Add(employee10);

            IEmployee employee11 = new Employee(13);
            employee11.name = "emp11";
            employee11.email = "empl11@esspl.com";
            employee11.ReportingManager = manager2;
            Employees.Add(employee11);

            IEmployee employee12 = new Employee(14);
            employee12.name = "emp12";
            employee12.email = "empl12@esspl.com";
            employee12.ReportingManager = manager1;
            Employees.Add(employee12);
        }
        public static List<IEmployee> Employees { get; private set; }
    }

}
