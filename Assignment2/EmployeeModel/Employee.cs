using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeModel
{
    public class Employee:IEmployee
    {
        public Employee(int EmployeeId) { }
        public int EmployeeId { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public IEmployee ReportingManager { get; set; }//reference to IEmployee
    }
}
