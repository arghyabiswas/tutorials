using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessModel
{
    public class Employee : IEmployee//Implimenting IEmployee(interface)

    {

        public Employee(int EmployeeId)//Constructor with parameter of type int 
        {
            this.EmployeeId = EmployeeId;
        }
        public int EmployeeId { get; }//restricted to be readonly outside the interface

        public string Name { get; set; }
        

        public string Email { get; set; }
        

        IEmployee IEmployee.ReportingManager { get; set; }
        
    }
}
