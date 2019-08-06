using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessModel
{
    public static class DataContext
    {
        static DataContext()
        {
            Employees = new List<IEmployee>();
            Imanager manager1 = new Manager(1);
            manager1.Email = "manager1@esspl.com";
            manager1.Name = "Manager1";
            Employees.Add(manager1);

            Imanager manager2 = new Manager(2);
            manager2.Email = "manager2@esspl.com";
            manager2.Name = "Manager2";
            Employees.Add(manager2);

            IEmployee employee1 = new Employee(3);
            employee1.Name = "emp1dummy";
            employee1.Email = "empl1@esspl.com";
            employee1.ReportingManager = manager1;
            Employees.Add(employee1);

            IEmployee employee2 = new Employee(4);
            employee2.Name = "emp2dummy";
            employee2.Email = "empl2@esspl.com";
            employee2.ReportingManager = manager1;
            Employees.Add(employee2);

            IEmployee employee3 = new Employee(5);
            employee3.Name = "emp3dummy";
            employee3.Email = "empl3@esspl.com";
            employee3.ReportingManager = manager1;
            Employees.Add(employee3);

            IEmployee employee4 = new Employee(6);
            employee4.Name = "emp4dummy";
            employee4.Email = "empl4@esspl.com";
            employee4.ReportingManager = manager1;
            Employees.Add(employee4);

            IEmployee employee5 = new Employee(7);
            employee5.Name = "emp5dummy";
            employee5.Email = "empl5@esspl.com";
            employee5.ReportingManager = manager1;
            Employees.Add(employee5);

            IEmployee employee6 = new Employee(8);
            employee6.Name = "emp6dummy";
            employee6.Email = "empl6@esspl.com";
            employee6.ReportingManager = manager1;
            Employees.Add(employee6);

            IEmployee employee7 = new Employee(9);
            employee7.Name = "emp7dummy";
            employee7.Email = "empl7@esspl.com";
            employee7.ReportingManager = manager2;
            Employees.Add(employee7);

            IEmployee employee8 = new Employee(10);
            employee8.Name = "emp8dummy";
            employee8.Email = "empl8@esspl.com";
            employee8.ReportingManager = manager2;
            Employees.Add(employee8);

            IEmployee employee9 = new Employee(11);
            employee9.Name = "emp9dummy";
            employee9.Email = "empl9@esspl.com";
            employee9.ReportingManager = manager2;
            Employees.Add(employee9);

            IEmployee employee10 = new Employee(12);
            employee10.Name = "emp10dummy";
            employee10.Email = "empl10@esspl.com";
            employee10.ReportingManager = manager2;
            Employees.Add(employee10);

            IEmployee employee11 = new Employee(13);
            employee11.Name = "emp11dummy";
            employee11.Email = "empl11@esspl.com";
            employee11.ReportingManager = manager2;
            Employees.Add(employee11);

            IEmployee employee12 = new Employee(14);
            employee12.Name = "emp12dummy";
            employee12.Email = "empl12@esspl.com";
            employee12.ReportingManager = manager1;
            Employees.Add(employee12);
        }
        public static List<IEmployee> Employees { get; private set; }

    }
}
