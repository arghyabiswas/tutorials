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
            employee1.name = "ashirwad";
            employee1.email = "ashirwad@esspl.com";
            employee1.ReportingManager = manager1;
            Employees.Add(employee1);

            IEmployee employee2 = new Employee(4);
            employee2.name = "arun";
            employee2.email = "arun@esspl.com";
            employee2.ReportingManager = manager2;
            Employees.Add(employee2);

            IEmployee employee3 = new Employee(5);
            employee3.name = "deepak";
            employee3.email = "deepak@esspl.com";
            employee3.ReportingManager = manager1;
            Employees.Add(employee3);

            IEmployee employee4 = new Employee(6);
            employee4.name = "chiranjeev";
            employee4.email = "chiranjeev@esspl.com";
            employee4.ReportingManager = manager2;
            Employees.Add(employee4);

            IEmployee employee5 = new Employee(7);
            employee5.name = "nikolash";
            employee5.email = "nikolash@esspl.com";
            employee5.ReportingManager = manager1;
            Employees.Add(employee5);

            IEmployee employee6 = new Employee(8);
            employee6.name = "amlan";
            employee6.email = "amlan@esspl.com";
            employee6.ReportingManager = manager2;
            Employees.Add(employee6);

            IEmployee employee7 = new Employee(9);
            employee7.name = "bishal";
            employee7.email = "bishal@esspl.com";
            employee7.ReportingManager = manager1;
            Employees.Add(employee7);

            IEmployee employee8 = new Employee(10);
            employee8.name = "sobhana";
            employee8.email = "sobhana@esspl.com";
            employee8.ReportingManager = manager2;
            Employees.Add(employee8);

            IEmployee employee9 = new Employee(11);
            employee9.name = "monalisa";
            employee9.email = "monalisa@esspl.com";
            employee9.ReportingManager = manager1;
            Employees.Add(employee9);

            IEmployee employee10 = new Employee(12);
            employee10.name = "aseem";
            employee10.email = "aseem@esspl.com";
            employee10.ReportingManager = manager2;
            Employees.Add(employee10);

            IEmployee employee11 = new Employee(13);
            employee11.name = "ashutosh";
            employee11.email = "ashutosh@esspl.com";
            employee11.ReportingManager = manager1;
            Employees.Add(employee11);

            IEmployee employee12 = new Employee(14);
            employee12.name = "utkal";
            employee12.email = "utkal@esspl.com";
            employee12.ReportingManager = manager2;
            Employees.Add(employee12);
        }
        public static List<IEmployee> Employees { get; private set; }
    }

}
