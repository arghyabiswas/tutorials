using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationModels
{
    public class Manager : Employee, IManager
    {
        public Manager(int employeeId)
            : base(employeeId)
        {

        }

        public IEmployee[] Subordinates { get; set; }
    }
}
