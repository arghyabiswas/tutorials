using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface Iemployee
    {
        int employeeid  { get; }
        string Name { get; set; }

        string Email { get; set; }

        Iemployee ReportingManager { get; set; }

    }
}
