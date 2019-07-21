using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationModels
{
    public interface IHr : IEmployee
    {
        IEmployee[] Employees { get; set; }
    }
}
