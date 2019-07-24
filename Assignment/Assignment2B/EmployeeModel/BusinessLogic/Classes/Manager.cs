using EmployeeModel.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeModel.BusinessLogic.Classes
{
    /// <summary>
    /// Manager class which implements Imanger and Inherits Employee
    /// </summary>
    public class Manager : Employee, IManager
    {
        /// <summary>
        /// Constructor of the Manager Class which holds the int type paramter to set the value in base Constructor
        /// </summary>
        /// <param name="EmployeeId"></param>
        public Manager(int EmployeeId ):base(EmployeeId)
        {
            
        }

        /// <summary>
        /// This property holds the Array of Sub-Ordinate employees for the Manager in the organisation
        /// </summary>
        public IEmployee[] Subordinates { get; set; }



    }
}
