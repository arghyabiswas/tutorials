using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESSPL.Model
{
    public interface IClassRoom
    {
        int Id { get;  }

        IStudent[] students { get; set; }
    }
}
