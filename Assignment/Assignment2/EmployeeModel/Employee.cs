using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeModel
{
    public class Employee : IEmployee
    {

        public Employee(int id)
        {
                     
        }

        public string Email { get; set; }
        
        public int EmployeeId { get; set; }

        public string Name { get; set; }

        public IEmployee ReportingManager { get; set; }

    }
}
