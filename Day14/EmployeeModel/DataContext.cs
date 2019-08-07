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
            manager1.Name = "Manager 1";
            manager1.Email = "manager1@esspl.com";
            Employees.Add(manager1);

            IManager manager2 = new Manager(2);
            manager2.Name = "Manager 2";
            manager2.Email = "manager2@esspl.com";
            Employees.Add(manager2);


            IEmployee employee1 = new Employee(3);
            employee1.Name = "Abhishek Parida";
            employee1.Email = "abhishekparida@esspl.com";
            employee1.ReportingManager = manager1;
            Employees.Add(employee1);

            IEmployee employee2 = new Employee(4);
            employee2.Name = "Aseem Ray";
            employee2.Email = "aseemr@esspl.com";
            employee2.ReportingManager = manager1;
            Employees.Add(employee2);

            IEmployee employee3 = new Employee(5);
            employee3.Name = "Ashirwad Satapathi";
            employee3.Email = "ashirwad@esspl.com";
            employee3.ReportingManager = manager1;
            Employees.Add(employee3);

            IEmployee employee4 = new Employee(6);
            employee4.Name = "Ashutosh Dash";
            employee4.Email = "ashutoshd@esspl.com";
            employee4.ReportingManager = manager1;
            Employees.Add(employee4);

            IEmployee employee5 = new Employee(7);
            employee5.Name = "Bishal Dikhit";
            employee5.Email = "bishal@esspl.com";
            employee5.ReportingManager = manager1;
            Employees.Add(employee5);

            IEmployee employee6 = new Employee(8);
            employee6.Name = "Chiranjeev Mazumdar";
            employee6.Email = "chiranjeev@esspl.com";
            employee6.ReportingManager = manager1;
            Employees.Add(employee6);

            IEmployee employee7 = new Employee(9);
            employee7.Name = "Deepak Kumar Jena";
            employee7.Email = "deepakj@esspl.com";
            employee7.ReportingManager = manager2;
            Employees.Add(employee7);

            IEmployee employee8 = new Employee(10);
            employee8.Name = "Monalisa Maharana";
            employee8.Email = "monalisa@esspl.com";
            employee8.ReportingManager = manager2;
            Employees.Add(employee8);

            IEmployee employee9 = new Employee(11);
            employee9.Name = "Nikolash Beura";
            employee9.Email = "nikolash@esspl.com";
            employee9.ReportingManager = manager2;
            Employees.Add(employee9);

            IEmployee employee10 = new Employee(12);
            employee10.Name = "Shreyas Joshi";
            employee10.Email = "shreyas@esspl.com";
            employee10.ReportingManager = manager2;
            Employees.Add(employee10);

            IEmployee employee11 = new Employee(13);
            employee11.Name = "Utkal Sahoo";
            employee11.Email = "utkals@esspl.com";
            employee11.ReportingManager = manager2;
            Employees.Add(employee11);

            IEmployee employee12 = new Employee(14);
            employee12.Name = "Employee 1";
            employee12.Email = "employee1s@esspl.com";
            employee12.ReportingManager = manager2;
            Employees.Add(employee12);

            manager1.Subordinates = new List<IEmployee>();
            manager2.Subordinates = new List<IEmployee>();

            manager1.Subordinates.AddRange(Employees.Where(p => p.ReportingManager != null && p.ReportingManager.EmployeeId == manager1.EmployeeId));
            manager2.Subordinates.AddRange(Employees.Where(p => p.ReportingManager != null && p.ReportingManager.EmployeeId == manager2.EmployeeId));
        }

        public static List<IEmployee> Employees { get; private set; }
    }
}
