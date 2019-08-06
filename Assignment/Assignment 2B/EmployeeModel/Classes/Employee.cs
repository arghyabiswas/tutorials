using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeModel
{
    /// <summary>
    /// Employee class inherit from IEmployee interface
    /// </summary>
    public class Employee : IEmployee
    {
        public Employee()
        {
        }

        /// <summary>
        /// Creating a constructor of Employee Class and accepting parameter employeeid of int data types
        /// </summary>
        /// <param name="employeeid"></param>
        public Employee(int employeeid)
        {
            this.EmployeeId = employeeid;
        }
        public string Email
        {
            get;
            set;
        }

        public int EmployeeId
        {
            get;
        }

        public string Name
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
