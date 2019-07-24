using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeModel.BusinessLogic.Interfaces
{
    public interface IEmployee
    {
        /// <summary>
        /// Readonly property which gives the Id of the employee 
        /// </summary>
        int EmployeeId { get; }
        /// <summary>
        /// Property to read and write name of employee    
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// Property to read and write email of employee   
        /// </summary>
        string Email { get; set; }
        /// <summary>
        /// Property to read and write the Reporting Manager for each employee
        /// </summary>
        IEmployee ReportingManager { get; set; }
        



    }
}
