using EmployeeModel.BusinessLogic.Interfaces;
using System.Collections.Generic;

namespace Assignment2.BusinessLogic.Interfaces
{
    public interface IManageEmployee
    {
        /// <summary>
        /// Prints Total Number of Employee Present in the Organization
        /// </summary>
        /// <param name="employee">List of Employee</param>
        void GetTotalEmployee(List<IEmployee> employee);

        /// <summary>
        /// Prints the Employee Details under a Manager, Uses Expression Mathod
        /// </summary>
        /// <param name="employee">List of Employee</param>
        /// <param name="employeeId">ManagerId</param>
        void GetSubOrdinates(List<IEmployee> employee, int employeeId);

        /// <summary>
        /// Prints Details of All the Employee
        /// </summary>
        /// <param name="employee">List of Employee</param>
        void GetEmployeeDetails(List<IEmployee> employee);

        /// <summary>
        /// Prints the Employee Details under a Manager, Uses LINQ Query
        /// </summary>
        /// <param name="employee">List of Employee</param>
        /// <param name="employeeId">ManagerId</param>
        void GetSubOrdinatesByLINQ(List<IEmployee> employee, int employeeId);

    }
}
