using EmployeeModel.BusinessLogic.Interfaces;
using System.Collections.Generic;

namespace Assignment2.BusinessLogic.Interfaces
{
    public interface IManageEmployee
    {
        
        void GetTotalEmployee(List<IEmployee> employee);

        
        void GetSubOrdinates(List<IEmployee> employee, int employeeId);

        
        void GetEmployeeDetails(List<IEmployee> employee);

        
        void GetSubOrdinatesByLINQ(List<IEmployee> employee, int employeeId);

    }
}
