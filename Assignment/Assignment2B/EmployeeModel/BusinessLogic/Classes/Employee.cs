using EmployeeModel.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeModel.BusinessLogic.Classes
{

    /// <summary>
    /// creating public class employee with interface implementation of IEmployee 
    /// </summary>
    public class Employee : IEmployee
    {
        /// <summary>
        /// Employee Constructor that takes int employeeId while Creating the Object for the Employee
        /// </summary>
        /// <param name="EmployeeId"></param>
        public Employee(int EmployeeId)
        {
            this.EmployeeId = EmployeeId;
        }

        ///<summary>
        /// Email  of the Employee Class
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Read only property EmployeeId of employee class
        /// </summary>
        public int EmployeeId { get; }

        /// <summary>
        /// Name as property of employee class
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Property that is used as Reference to the object of same type if the Employee has one Reporting Manager
        /// </summary>
        public IEmployee ReportingManager { get; set; }
 
    }
}
