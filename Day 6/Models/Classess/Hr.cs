using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationModels
{
    public class Hr : Employee,IHr
    {
        public Hr(int employeeId)
           : base(employeeId)
        {

        }

        public IEmployee[] Employees { get; set; }
    }
}
