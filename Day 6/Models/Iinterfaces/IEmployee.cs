using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationModels
{
    public interface IEmployee
    {
        int EmployeeId { get; }

        string Name { get; set; }

        string Email { get; set; }

        double Salary { get; set; }

        DepartmentType Department { get; set; }

        IManager ReportingManager { get; set; }

        IHr HrManager { get; set; }
    }
}
