using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeModel
{
    public class Employee : IEmployee // (2.c)class Employee implementing IEmployee
    {
        public Employee(int EmpId)//(c.i)Employee class having one constructor with parameter employeeId
        {

        }

        public string Email { get; set; }
        
        public int EmployeeId { get; set; }

        public string Name { get; set; }
       
        public IEmployee ReportingManager { get; set; }
        
    }
}
