using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Collections
{
    class SampleList
    {
        public SampleList()
        {
            collection.Add("oracle");
            collection.Add("vb.net");
            collection.Add("cs.net");
            collection.Add("asp.net");
        }

        List<string> collection = new List<string>();
        public List<string> Collection
        {
            get
            {
                return collection;
            }
        }
    }
}
