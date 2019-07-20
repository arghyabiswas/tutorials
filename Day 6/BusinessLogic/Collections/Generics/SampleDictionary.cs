using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Collections
{
    class SampleDictionary
    {
        public SampleDictionary()
        {
            collection.Add(1, "oracle");
            collection.Add(2, "vb.net");
            collection.Add(3, "cs.net");
            collection.Add(4, "asp.net");
        }

        Dictionary<int, string> collection = new Dictionary<int, string>();
        public Dictionary<int, string> Collection
        {
            get
            {
                return collection;
            }
        }
    }
}
