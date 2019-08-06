using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public static class DataContext
    {
     
        static DataContext()
        {
            employees = new List<IEmployee>();

            IEmployee[] employee = new IEmployee[12];
            IManager[] manager = new IManager[2];

            manager[0] = new Manager(13)
            {
                Name = "Test Manager1",
                Email = "manager1@esspl.com"
            };

            manager[1] = new Manager(14)
            {
                Name = "Test Manager2",
                Email = "manager2@esspl.com"
            };

            employee[0] = new Employee(1)
            {
                Name = "e1",
                Email = "e1@gmail.com",
                ReportingManager = manager[0]
            };

            employee[1] = new Employee(2)
            {
                Name = "e2",
                Email = "e2@gmail.com",
                ReportingManager = manager[0]
            };

            employee[3] = new Employee(4)
            {
                Name = "e3  ",
                Email = "e3@gmail.com",
                ReportingManager = manager[0]
            };

            employee[4] = new Employee(5)
            {
                Name = "   e4",
                Email = "e4@gmail.com",
                ReportingManager = manager[1]
            };

            employee[5] = new Employee(6)
            {
                Name = "  e5",
                Email = "e5@gmail.com",
                ReportingManager = manager[1]
            };

            employee[6] = new Employee(7)
            {
                Name = "  e6",
                Email = "e6@gmail.com",
                ReportingManager = manager[0]
            };

            employee[7] = new Employee(8)
            {
                Name = " e7",
                Email = "e7@gmail.com",
                ReportingManager = manager[1]
            };

            employee[8] = new Employee(9)
            {
                Name = "   e8",
                Email = "e8@gmail.com",
                ReportingManager = manager[0]
            };

            employee[9] = new Employee(10)
            {
                Name = "  e9",
                Email = "e9@gmail.com",
                ReportingManager = manager[0]
            };

            employee[10] = new Employee(11)
            {
                Name = "e10 Mahto",
                Email = "e10@gmail.com",
                ReportingManager = manager[1]
            };
 

         
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
        public static List<IEmployee> employees { get; private set; }


    }
}