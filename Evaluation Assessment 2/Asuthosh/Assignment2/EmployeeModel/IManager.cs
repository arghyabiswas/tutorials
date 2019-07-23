using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeModel
{
    public interface IManager:IEmployee
    {
            IEmployee[] Subordinates { get; set; }
        
    }
}
