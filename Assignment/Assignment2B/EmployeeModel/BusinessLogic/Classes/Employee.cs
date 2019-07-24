using EmployeeModel.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeModel.BusinessLogic.Classes
{
    public class Employee : IEmployee
    {
        public Employee(int EmployeeId)
        {
            this.EmployeeId = EmployeeId;
        }

        public string Email { get; set; }


        public int EmployeeId { get; }


        public string Name { get; set; }


        public IEmployee ReportingManager { get; set; }
 
    }
}
