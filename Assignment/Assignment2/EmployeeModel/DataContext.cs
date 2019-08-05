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

            IEmployee[] employee = new IEmployee[12];
            IManager[] manager = new IManager[2];

            manager[0] = new Manager(1)
            {
                Name = "Test Manager1",
                Email = "manager1@esspl.com"
            };

            manager[1] = new Manager(2)
            {
                Name = "Test Manager2",
                Email = "manager2@esspl.com"
            };

            employee[0] = new Employee(1)
            {
                Name = "Alok Nath",
                Email = "alok@gmail.com",
                ReportingManager = manager[0]
            };

            employee[1] = new Employee(2)
            {
                Name = "Basundhara Devi",
                Email = "bdevi@gmail.com",
                ReportingManager = manager[0]
            };

            employee[3] = new Employee(4)
            {
                Name = "Gajendra Singh",
                Email = "gajendra@gmail.com",
                ReportingManager = manager[0]
            };

            employee[4] = new Employee(5)
            {
                Name = "Raghunath Chauhan",
                Email = "raghuc@gmail.com",
                ReportingManager = manager[1]
            };

            employee[5] = new Employee(6)
            {
                Name = "Satyavati Yadav",
                Email = "syadav@gmail.com",
                ReportingManager = manager[1]
            };

            employee[6] = new Employee(7)
            {
                Name = "Kasturi Kumari",
                Email = "kkasturi@gmail.com",
                ReportingManager = manager[0]
            };

            employee[7] = new Employee(8)
            {
                Name = "Digbijay Patel",
                Email = "digpatel@gmail.com",
                ReportingManager = manager[1]
            };

            employee[8] = new Employee(9)
            {
                Name = "Ramgopal Nath",
                Email = "ramnath@gmail.com",
                ReportingManager = manager[0]
            };

            employee[9] = new Employee(10)
            {
                Name = "Biswa Lal",
                Email = "biswa@gmail.com",
                ReportingManager = manager[0]
            };

            employee[10] = new Employee(11)
            {
                Name = "Rajeshwari Mahto",
                Email = "rajeshwarim@gmail.com",
                ReportingManager = manager[1]
            };

            employee[11] = new Employee(12)
            {
                Name = "Sundarlal Tripathy",
                Email = "tripathysundarlal@gmail.com",
                ReportingManager = manager[1]
            };

            employee[2] = new Employee(3)
            {
                Name = "Rajkishore Tiwary",
                Email = "traj@gmail.com",
                ReportingManager = manager[0]
            };

            List<IEmployee> employees = new List<IEmployee>();
            employees.Add(manager[0]);
            employees.Add(manager[1]);
            employees.Add(employee[0]);
            employees.Add(employee[1]);
            employees.Add(employee[2]);
            employees.Add(employee[3]);
            employees.Add(employee[4]);
            employees.Add(employee[5]);
            employees.Add(employee[6]);
            employees.Add(employee[7]);
            employees.Add(employee[8]);
            employees.Add(employee[9]);
            employees.Add(employee[10]);
            employees.Add(employee[11]);

        }
        public static List<IEmployee> Employees { get; private set; }

    }
}
