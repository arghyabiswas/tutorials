using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Collections
{
    class SampleSortedList
    {
        public SampleSortedList()
        {
            collection.Add("ora", "oracle");
            collection.Add("vb", "vb.net");
            collection.Add("cs", "cs.net");
            collection.Add("asp", "asp.net");
        }

        SortedList collection = new SortedList();
        public SortedList Collection
        {
            get
            {
                return collection;
            }
        }
    }
}
