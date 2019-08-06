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
            manager1.email = "somali@esspl.com";
            manager1.name = "Somali";
            Employees.Add(manager1);

            IManager manager2 = new Manager(2);
            manager2.email = "priyanka@esspl.com";
            manager2.name = "Priyanka";
            Employees.Add(manager2);

            IEmployee employee1 = new Employee(3);
            employee1.name = "Monalisa";
            employee1.email = "monalisa@esspl.com";
            employee1.ReportingManager = manager1;
            Employees.Add(employee1);

            IEmployee employee2 = new Employee(4);
            employee2.name = "Ashutosh";
            employee2.email = "Ashutosh@esspl.com";
            employee2.ReportingManager = manager1;
            Employees.Add(employee2);

            IEmployee employee3 = new Employee(5);
            employee3.name = "Aseem";
            employee3.email = "aseem@esspl.com";
            employee3.ReportingManager = manager1;
            Employees.Add(employee3);

            IEmployee employee4 = new Employee(6);
            employee4.name = "Nikolash";
            employee4.email = "nik@esspl.com";
            employee4.ReportingManager = manager1;
            Employees.Add(employee4);

            IEmployee employee5 = new Employee(7);
            employee5.name = "Utkal";
            employee5.email = "utkal@esspl.com";
            employee5.ReportingManager = manager1;
            Employees.Add(employee5);

            IEmployee employee6 = new Employee(8);
            employee6.name = "Ashirwad";
            employee6.email = "ashirwad@esspl.com";
            employee6.ReportingManager = manager1;
            Employees.Add(employee6);

            IEmployee employee7 = new Employee(9);
            employee7.name = "Vishal";
            employee7.email = "vishal@esspl.com";
            employee7.ReportingManager = manager2;
            Employees.Add(employee7);

            IEmployee employee8 = new Employee(10);
            employee8.name = "Shreyash";
            employee8.email = "shreyash@esspl.com";
            employee8.ReportingManager = manager2;
            Employees.Add(employee8);

            IEmployee employee9 = new Employee(11);
            employee9.name = "Sobhana";
            employee9.email = "sobhana@esspl.com";
            employee9.ReportingManager = manager2;
            Employees.Add(employee9);

           

          
        }
        public static List<IEmployee> Employees { get; private set; }
    }

}
