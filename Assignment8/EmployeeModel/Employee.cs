using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeModel
{
    public class Employee : IEmployee
    {

        public Employee(int employeeId)
        {
            this.employeeId = employeeId;
        }
        public string email
        {
            get;
            set;          
        }

        public int employeeId
        {
            get;
           
        }

        public string name
        {
            get;
            set;        
        }

        public IEmployee ReportingManager
        {
            get;
            set;         
        }
    }
}
