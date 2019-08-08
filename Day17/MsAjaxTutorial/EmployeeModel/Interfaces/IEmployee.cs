using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeModel
{
    /// <summary>
    /// Structure of the employee
    /// </summary>
    public interface IEmployee
    {
        /// <summary>
        /// Employee Id is used to uniquely identify the employee.
        /// It is the primary Key
        /// </summary>
        int EmployeeId { get; }
        
        /// <summary>
        /// Name of the employee
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Email of the employee
        /// </summary>
        string Email { get; set; }

        /// <summary>
        /// Reporting manager is another employee  
        /// </summary>
        IEmployee ReportingManager { get; set; }
    }
}
