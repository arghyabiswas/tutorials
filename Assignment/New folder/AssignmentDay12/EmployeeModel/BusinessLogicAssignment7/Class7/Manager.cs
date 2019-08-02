using EmployeeModel.BusinessLogic.Interfaces;
using System;

namespace EmployeeModel.BusinessLogic.Classes
{
    /// <summary>
    /// Manager class which Implemants Imanger and Inherits Employee
    /// </summary>
    [Serializable]
    public class Manager : Employee, IManager
    {
        /// <summary>
        /// Constructor of the Manager Class Which hold the int type Paramter to Set the value in base Constructor
        /// </summary>
        /// <param name="EmployeeId"></param>
        public Manager(int EmployeeId) : base(EmployeeId)
        {

        }

        /// <summary>
        /// Property holds the Array of Sub-Ordinates for the Manager
        /// </summary>
        public IEmployee[] Subordinates { get; set; }
        public int Data { get; set; }
    }
}
