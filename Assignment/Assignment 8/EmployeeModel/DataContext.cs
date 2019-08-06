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
            employee1.Name = "Ashirwad Satapathi";
            employee1.Email = "ashirwad@esspl.com";
            employee1.ReportingManager = manager1;
            Employees.Add(employee1);

            IEmployee employee2 = new Employee(4);
            employee2.Name = "Deepak Jena";
            employee2.Email = "deepak@esspl.com";
            employee2.ReportingManager = manager1;
            Employees.Add(employee2);

            IEmployee employee3 = new Employee(5);
            employee3.Name = "Bishal Dixit";
            employee3.Email = "bishal@esspl.com";
            employee3.ReportingManager = manager1;
            Employees.Add(employee3);

            IEmployee employee4 = new Employee(6);
            employee4.Name = "Ashutosh Dash";
            employee4.Email = "ashutosh@esspl.com";
            employee4.ReportingManager = manager1;
            Employees.Add(employee4);

            IEmployee employee5 = new Employee(7);
            employee5.Name = "Nicolash Beura";
            employee5.Email = "nicolash@esspl.com";
            employee5.ReportingManager = manager1;
            Employees.Add(employee5);

            IEmployee employee6 = new Employee(8);
            employee6.Name = "Aseem Ray";
            employee6.Email = "assem@esspl.com";
            employee6.ReportingManager = manager1;
            Employees.Add(employee6);

            IEmployee employee7 = new Employee(9);
            employee7.Name = "Abhishek Parida";
            employee7.Email = "abhishek@esspl.com";
            employee7.ReportingManager = manager2;
            Employees.Add(employee7);

            IEmployee employee8 = new Employee(10);
            employee8.Name = "Utkal sahoo";
            employee8.Email = "utkal@esspl.com";
            employee8.ReportingManager = manager2;
            Employees.Add(employee8);

            IEmployee employee9 = new Employee(11);
            employee9.Name = "Monalisha Maharana";
            employee9.Email = "monalisha@esspl.com";
            employee9.ReportingManager = manager2;
            Employees.Add(employee9);
            
        }


        public static List<IEmployee> Employees { get; private set; }
    }
}
