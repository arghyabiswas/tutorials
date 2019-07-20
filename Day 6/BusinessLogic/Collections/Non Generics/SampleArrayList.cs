using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Collections
{
    class SampleArrayList
    {
        public SampleArrayList()
        {
            string str = "Sample text";
            int x = 7;
            DateTime d = DateTime.Parse("8-oct-1985");
            collection.Add(str);
            collection.Add(x);
            collection.Add(d);
        }
        ArrayList collection = new ArrayList();
        public ArrayList Collection {
            get
            {
                return collection;
            }
        }
    }
}
