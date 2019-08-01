
namespace EmployeeModel.BusinessLogic.Interfaces
{
    /// <summary>
    /// Interface that holds the Abstact Property and Methods of the Employee
    /// </summary>
    public interface IEmployee
    {
        /// <summary>
        /// EployeeID Property of the Employee Class, Which is readonly
        /// </summary>
        int EmployeeId { get; }

        /// <summary>
        /// Name Property of the Employee Class
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Email Property of the Employee Class
        /// </summary>
        string Email { get; set; }


        /// <summary>
        /// Property that Reference to the object od same type if the Employee has one Reporting Manager
        /// </summary>
        IEmployee ReportingManager { get; set; }

    }
}
