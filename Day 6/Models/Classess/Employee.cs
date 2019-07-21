using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationModels
{
    public class Employee : IEmployee
    {
        public Employee(int employeeId)
        {
            this.EmployeeId = employeeId;
        }
        public int EmployeeId { get; private set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }
        public DepartmentType Department { get; set; }
        public IManager ReportingManager { get; set; }
        public IHr HrManager { get; set; }
    }
}
