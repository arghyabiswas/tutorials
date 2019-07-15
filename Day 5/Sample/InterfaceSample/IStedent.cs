using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSample
{
    public interface IStedent
    {
        int Id { get; set; }
        
        string FirstName { get; set; }

        string LastName { get; set; }

        string Depaertment { get; set; }
    }
}
