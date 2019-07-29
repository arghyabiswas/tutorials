using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeModel
{
    public class Employee:IEmployee
    {
        public Employee(int employeeid)
        {
            this.employeeid = employeeid;
        }
        public string email
        {
            get; set;
        }

        public int employeeid
        {
            get;
        }

        public string name
        {
            get; set;
        }

        public IEmployee reportingmanager
        {
            get; set;
        }

    }
}
