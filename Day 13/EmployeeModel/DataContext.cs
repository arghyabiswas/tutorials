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
            Employees = new List<Employee>();

            Employee manager1 = new Manager(1);
            manager1.Name = "Test Manager 1";
            manager1.Email = "manager1@esspl.com";
            Employees.Add(manager1);

            Employee manager2 = new Manager(2);
            manager2.Name = "Test Manager 2";
            manager2.Email = "manager2@esspl.com";
            Employees.Add(manager2);

            Employee employee1 = new Employee(3);
            employee1.Name = "Bishal Dikhit_1";
            employee1.Email = "bishal@esspl.com";
            employee1.ReportingManager = manager1;
            Employees.Add(employee1);

            Employee employee2 = new Employee(4);
            employee2.Name = "Bishal Dikhit_2";
            employee2.Email = "bishal@esspl.com";
            employee2.ReportingManager = manager1;
            Employees.Add(employee2);

            Employee employee3 = new Employee(5);
            employee3.Name = "Bishal Dikhit_3";
            employee3.Email = "bishal@esspl.com";
            employee3.ReportingManager = manager1;
            Employees.Add(employee3);

            Employee employee4 = new Employee(6);
            employee4.Name = "Bishal Dikhit_4";
            employee4.Email = "bishal@esspl.com";
            employee4.ReportingManager = manager1;
            Employees.Add(employee4);

            Employee employee5 = new Employee(7);
            employee5.Name = "Bishal Dikhit_5";
            employee5.Email = "bishal@esspl.com";
            employee5.ReportingManager = manager1;
            Employees.Add(employee5);

            Employee employee6 = new Employee(8);
            employee6.Name = "Bishal Dikhit_6";
            employee6.Email = "bishal@esspl.com";
            employee6.ReportingManager = manager1;
            Employees.Add(employee6);

            Employee employee7 = new Employee(9);
            employee7.Name = "Bishal Dikhit_7";
            employee7.Email = "bishal@esspl.com";
            employee7.ReportingManager = manager2;
            Employees.Add(employee7);

            Employee employee8 = new Employee(10);
            employee8.Name = "Bishal Dikhit_8";
            employee8.Email = "bishal@esspl.com";
            employee8.ReportingManager = manager2;
            Employees.Add(employee8);

            Employee employee9 = new Employee(11);
            employee9.Name = "Bishal Dikhit_9";
            employee9.Email = "bishal@esspl.com";
            employee9.ReportingManager = manager2;
            Employees.Add(employee9);

            Employee employee10 = new Employee(12);
            employee10.Name = "Bishal Dikhit_10";
            employee10.Email = "bishal@esspl.com";
            employee10.ReportingManager = manager2;
            Employees.Add(employee10);

            Employee employee11 = new Employee(13);
            employee11.Name = "Bishal Dikhit_11";
            employee11.Email = "bishal@esspl.com";
            employee11.ReportingManager = manager2;
            Employees.Add(employee11);

            Employee employee12 = new Employee(14);
            employee12.Name = "Bishal Dikhit_12";
            employee12.Email = "bishal@esspl.com";
            employee12.ReportingManager = manager2;
            Employees.Add(employee12);
        }

        public static List<Employee> Employees { get; private set; }
    }
}
