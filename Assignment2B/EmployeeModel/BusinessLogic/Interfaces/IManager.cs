
namespace EmployeeModel.BusinessLogic.Interfaces
{
    /// <summary>
    /// Interface which inherited from IEmployee and Holds abstact Property and methods of the Manager
    /// </summary>
    public interface IManager : IEmployee
    {
        /// <summary>
        /// Property holds the Array of Sub-Ordinates for the Manager
        /// </summary>
        IEmployee[] Subordinates { get; set; }
    }
}
