using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Collections
{
    class SampleStackGenerics
    {
        public SampleStackGenerics()
        {
            collection.Push("oracle");
            collection.Push("vb.net");
            collection.Push("cs.net");
            collection.Push("asp.net");
        }

        Stack<string> collection = new Stack<string>();
        public Stack<string> Collection
        {
            get
            {
                return collection;
            }
        }
    }
}
