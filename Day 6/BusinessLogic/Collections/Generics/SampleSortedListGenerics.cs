using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Collections
{
    class SampleSortedListGenerics
    {
        public SampleSortedListGenerics()
        {
            collection.Add("ORA", "oracle");
            collection.Add("VB", "vb.net");
            collection.Add("CS", "cs.net");
            collection.Add("ASP", "asp.net");
        }

        SortedList<string, string> collection = new SortedList<string, string>();
        public SortedList<string, string> Collection
        {
            get
            {
                return collection;
            }
        }
    }
}
