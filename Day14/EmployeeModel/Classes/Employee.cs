using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeModel
{
    /// <summary>
    /// Employee class inherited by <see cref="IEmployee"/>
    /// </summary>
    public class Employee : IEmployee
    {
        /// <summary>
        /// Constructor with employee id 
        /// </summary>
        /// <param name="employeeid"></param>
        public Employee(int employeeid)
        {
            this.EmployeeId = employeeid;
        }

        /// <summary>
        /// Employee Id is used to uniquely identify the employee.
        /// It is the primary Key
        /// Outside of the class this key is read-only, as "set" is private
        /// </summary>
        public int EmployeeId
        {
            get; private set;
        }

        /// <summary>
        /// Name of the employee
        /// </summary>
        public string Name
        {
            get; set;
        }

        /// <summary>
        /// Email of the employee
        /// </summary>
        public string Email
        {
            get; set;
        }

        /// <summary>
        /// Reporting manager is another employee  
        /// </summary>
        public IEmployee ReportingManager
        {
            get; set;
        }

    }
}
