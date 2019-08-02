using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeModel
{
    public class DataContext
    {
        static DataContext()
        {
            Employees = new List<IEmployee>();
            IEmployee manager1 = new Manager(1);
            manager1.Name = "Manager 1";
            manager1.Email = "manager1@esspl.com";
            Employees.Add(manager1);

            IEmployee manager2 = new Manager(2);
            manager2.Name = "Manager 2";
            manager2.Email = "manager2@esspl.com";
            Employees.Add(manager2);

            IEmployee employee1 = new Employee(3);
            employee1.Name = "Shreyas_1";
            employee1.Email = "shreyas1@esspl.com";
            employee1.ReportingManager = manager1;
            Employees.Add(employee1);

            IEmployee employee2 = new Employee(4);
            employee2.Name = "Shreyas_2";
            employee2.Email = "shreyas1@esspl.com";
            employee2.ReportingManager = manager1;
            Employees.Add(employee2);

            IEmployee employee3 = new Employee(5);
            employee3.Name = "Shreyas_3";
            employee3.Email = "shreyas1@esspl.com";
            employee3.ReportingManager = manager1;
            Employees.Add(employee3);

            IEmployee employee4 = new Employee(6);
            employee4.Name = "Shreyas_4";
            employee4.Email = "shreyas1@esspl.com";
            employee4.ReportingManager = manager1;
            Employees.Add(employee4);

            IEmployee employee5 = new Employee(7);
            employee5.Name = "Shreyas_5";
            employee5.Email = "shreyas1@esspl.com";
            employee5.ReportingManager = manager1;
            Employees.Add(employee5);

            IEmployee employee6 = new Employee(8);
            employee6.Name = "Shreyas_6";
            employee6.Email = "shreyas1@esspl.com";
            employee6.ReportingManager = manager1;
            Employees.Add(employee6);

            IEmployee employee7 = new Employee(9);
            employee7.Name = "Shreyas_7";
            employee7.Email = "shreyas1@esspl.com";
            employee7.ReportingManager = manager2;
            Employees.Add(employee7);

            IEmployee employee8 = new Employee(10);
            employee8.Name = "Shreyas_8";
            employee8.Email = "shreyas1@esspl.com";
            employee8.ReportingManager = manager2;
            Employees.Add(employee8);

            IEmployee employee9 = new Employee(11);
            employee9.Name = "Shreyas_9";
            employee9.Email = "shreyas1@esspl.com";
            employee9.ReportingManager = manager2;
            Employees.Add(employee9);

            IEmployee employee10 = new Employee(12);
            employee10.Name = "Shreyas_10";
            employee10.Email = "shreyas1@esspl.com";
            employee10.ReportingManager = manager2;
            Employees.Add(employee10);

            IEmployee employee11 = new Employee(13);
            employee11.Name = "Shreyas_11";
            employee11.Email = "shreyas1@esspl.com";
            employee11.ReportingManager = manager2;
            Employees.Add(employee11);

            IEmployee employee12 = new Employee(14);
            employee12.Name = "Shreyas_12";
            employee12.Email = "shreyas1@esspl.com";
            employee12.ReportingManager = manager2;
            Employees.Add(employee12);
        }


        public static List<IEmployee> Employees { get; private set; }
    }
}
