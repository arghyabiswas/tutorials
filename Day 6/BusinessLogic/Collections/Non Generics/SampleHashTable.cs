using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Collections
{
    class SampleHashTable
    {
        public SampleHashTable()
        {
            collection.Add("ora", "oracle");
            collection.Add("vb", "vb.net");
            collection.Add("cs", "cs.net");
            collection.Add("asp", "asp.net");

        }
        Hashtable collection = new Hashtable();
        public Hashtable Collection
        {
            get
            {
                return collection;
            }
        }
    }
}
