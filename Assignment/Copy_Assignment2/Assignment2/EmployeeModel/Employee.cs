using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeModel
{
    /// <summary>
    /// Employee Class inherited from Interface Employee
    /// </summary>
    public class Employee : IEmployee
    {
        /// <summary>
        /// Parameterised Constructor of Employee having employeeId as an argument
        /// </summary>
        /// <param name="employeeId"></param>
        public Employee(int employeeId)
        {
            this.employeeId = employeeId;
        }

        /// <summary>
        /// getter and setter of email
        /// </summary>
        public string email
        {
            get;
            set;          
        }

        /// <summary>
        /// as it is only readable so it has only getter
        /// </summary>
        public int employeeId
        {
            get;
           
        }

        /// <summary>
        /// getter and setter of name
        /// </summary>
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
