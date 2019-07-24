using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeModel;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {

            IEmployee[] employees = new IEmployee[3];

            employees[0] = new Manager(1);
            employees[0].Name = "Reporting Manager";
            employees[0].Email = "ashirwad@esspl.com";

            employees[1] = new Employee(2);
            employees[1].Name = "Subordinates";
            employees[1].Email = "deepak@esspl.com";
            employees[1].Manager = employees[0];

            employees[2] = new Employee(3);
            employees[2].Name = "subordinates";
            employees[2].Email = "utkal@esspl.com";
            employees[2].Manager = employees[0];

            for (int i = 1; i < 3; i++)
            {
                Console.WriteLine("Employee Name : {0} \nEmployee Email : {1} \nEmployee Manager : {2}\n", employees[i].Name,
                                    employees[i].Email, employees[i].Manager.Name);
            }
 
            ((IManager)employees[0]).subordinates = new Employee[2];

             for (int count = 0; count < 2; count++)
                        {
                            ((IManager)employees[0]).subordinates[count] = employees[count + 1];

                        }
            Console.WriteLine($"Manager Name: {employees[0].Name} \nManager Email :{employees[0].Email}\nNo of Sub-Ordinate {((IManager)employees[0]).subordinates.Count()}");
                        
            
            Console.ReadLine();
        }
    }
}
