using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessModel
{
    public interface IEmployee
    {
        int Id { get; }

        string Name { get; set; }

        string Email { get; set; }

        IEmployee ReportingManager { get; set; }
    }
}
