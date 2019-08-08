using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessModel
{
    interface Imanager : IEmployee
    {
        IEmployee[] Subordinates { get; set; }
    }
}
