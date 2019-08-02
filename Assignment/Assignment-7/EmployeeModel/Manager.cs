using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeModel
{
    /// <summary>
    /// Manager Class inherited from Employee Class and Manager Interface
    /// </summary>
    public class Manager : Employee, IManager
    {
        /// <summary>
        /// Overridden Employee Interface array for no of sub_ordinates
        /// </summary>
        public IEmployee[] SubOrdinates
        {
            get;
            set;          
        }

        /// <summary>
        /// Constructor of Manager Class inherited from Base Employee class
        /// </summary>
        /// <param name="employeeId"></param>
        public Manager(int employeeId): base(employeeId)
        {
            
        }
    }
}
