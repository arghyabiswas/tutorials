using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Collections
{
    class SampleStack
    {
        public SampleStack()
        {
            collection.Push("oracle");
            collection.Push("vb.net");
            collection.Push("cs.net");
            collection.Push("asp.net");
        }

        Stack collection = new Stack();
        public Stack Collection
        {
            get
            {
                return collection;
            }
        }
    }
}
