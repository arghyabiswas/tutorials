using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeModel
{
    public interface IEmployee
    {
        int Id { get; }
        string Name { get; set; }
        string Email { get; set; }
        IEmployee Manager { get; set; }

    }
}
