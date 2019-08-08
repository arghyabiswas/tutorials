using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeModel
{
    /// <summary>
    /// Manager is inherited by <see cref="Employee"/>  as a manager is also an employee, 
    /// </summary>
    public class Manager : Employee, IManager
    {
        /// <summary>
        /// Constructor with employee id parameter
        /// </summary>
        /// <param name="employeeid"></param>
        public Manager(int employeeid) : base(employeeid)
        {

        }

        /// <summary>
        /// People who work under the manager
        /// </summary>
        public List<IEmployee> Subordinates
        {
            get; set;
        }
    }
}
