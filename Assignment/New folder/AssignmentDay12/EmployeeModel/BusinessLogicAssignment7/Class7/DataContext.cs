using EmployeeModel.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeModel.BusinessLogic.Classes
{
    public static class DataContext
    {
        static DataContext()
        {

            //Declaring of List type of IEmployee
            Employees = new List<IEmployee>();

            //Object Manager one
            IEmployee _employee1 = new Manager(1)
            {
                Email = "manager1@esspl.com",
                Name = "Test Manager1"
            };
            Employees.Add(_employee1);

            //Object Manager one
            IEmployee _employee2 = new Manager(2)
            {
                Email = "manager2@esspl.com",
                Name = "Test Manager2"
            };
            Employees.Add(_employee2);


            //Object Employee
            IEmployee _employee3 = new Employee(3)
            {
                Email = "employee3@esspl.com",
                Name = "Employee3",
                ReportingManager = _employee2
            };
            Employees.Add(_employee3);



            //Object Employee
            IEmployee _employee4 = new Employee(4)
            {
                Email = "employee4@esspl.com",
                Name = "Employee4",
                ReportingManager = _employee2
            };
            Employees.Add(_employee4);

            //Object Employee
            IEmployee _employee5 = new Employee(5)
            {
                Email = "employee5@esspl.com",
                Name = "Employee5",
                ReportingManager = _employee2
            };
            Employees.Add(_employee5);

            //Object Employee
            IEmployee _employee6 = new Employee(6)
            {
                Email = "employee6@esspl.com",
                Name = "Employee6",
                ReportingManager = _employee1
            };
            Employees.Add(_employee6);

            //Object Employee
            IEmployee _employee7 = new Employee(7)
            {
                Email = "employee7@esspl.com",
                Name = "Employee7",
                ReportingManager = _employee1
            };
            Employees.Add(_employee7);

            //Object  Employee
            IEmployee _employee8 = new Employee(8)
            {
                Email = "employee8@esspl.com",
                Name = "Employee8",
                ReportingManager = _employee2
            };
            Employees.Add(_employee8);

            //Object Employee
            IEmployee _employee9 = new Employee(9)
            {
                Email = "employee9@esspl.com",
                Name = "Employee9",
                ReportingManager = _employee2
            };
            Employees.Add(_employee9);

            //Object Employee
            IEmployee _employee10 = new Employee(10)
            {
                Email = "employee10@esspl.com",
                Name = "Employee10",
                ReportingManager = _employee2
            };
            Employees.Add(_employee10);

            //Object Employee
            IEmployee _employee11 = new Employee(11)
            {
                Email = "employee11@esspl.com",
                Name = "Employee11",
                ReportingManager = _employee1
            };
            Employees.Add(_employee11);

            //Object Employee
            IEmployee _employee12 = new Employee(12)
            {
                Email = "employee12@esspl.com",
                Name = "Employee12",
                ReportingManager = _employee1
            };
            Employees.Add(_employee12);

            //Object Employee
            IEmployee _employee13 = new Employee(13)
            {
                Email = "employee13@esspl.com",
                Name = "Employee13",
                ReportingManager = _employee1
            };
            Employees.Add(_employee13);

            //Object Employee
            IEmployee _employee14 = new Employee(14)
            {
                Email = "employee14@esspl.com",
                Name = "Employee14",
                ReportingManager = _employee1
            };
            Employees.Add(_employee14);
        }

        public static List<IEmployee> Employees { get; set; }
    }
}
