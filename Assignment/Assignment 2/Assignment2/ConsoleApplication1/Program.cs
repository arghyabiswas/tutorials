using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessModel;
using System.Collections;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IEmployee[] Employee_Array = new IEmployee[3];
            Employee_Array[0] = new Manager(1);
            Employee_Array[0].Name = "Debaprasad Acharya";
            Employee_Array[0].Email = "deb@esspl.com";


            Employee_Array[1] = new Employee(2);
            Employee_Array[1].Name = "Bishal Dikhit";
            Employee_Array[1].Email = "bishal@esspl.com";
            Employee_Array[1].ReportingManager = Employee_Array[0];

            Employee_Array[2] = new Employee(3);
            Employee_Array[2].Name = "Rajesh Mishra";
            Employee_Array[2].Email = "Rajesh@esspl.com";
            Employee_Array[2].ReportingManager = Employee_Array[0];

            for(int i=1;i<3;i++)
            {
                Console.WriteLine("Employee Name: {0}, Email id:{1}  <<< Manager Name: {2}, Email id{3}",
                                     Employee_Array[i].Name, Employee_Array[i].Email, Employee_Array[i].ReportingManager.Name, Employee_Array[i].ReportingManager.Email);
            }
            Console.ReadKey();
        }
    }
}
