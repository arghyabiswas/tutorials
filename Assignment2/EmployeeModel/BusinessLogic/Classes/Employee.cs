using EmployeeModel.BusinessLogic.Interfaces;


namespace EmployeeModel.BusinessLogic.Classes
{
    /// <summary>
    /// Employee Class that Implements of the Employee Interface
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


        /// <summary>
        /// Email Property of the Employee Class
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// EployeeID Property of the Employee Class, Which is readonly
        /// </summary>
        public int EmployeeId { get; }

        /// <summary>
        /// Name Property of the Employee Class
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// Property that Reference to the object od same type if the Employee has one Reporting Manager
        /// </summary>
        public IEmployee ReportingManager { get; set; }
    }
}
