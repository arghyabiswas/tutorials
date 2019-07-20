using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Collections
{
    class SampleQueue
    {
        public SampleQueue()
        {
            collection.Enqueue("oracle");
            collection.Enqueue("vb.net");
            collection.Enqueue("cs.net");
            collection.Enqueue("asp.net");
        }

        Queue collection = new Queue();
        public Queue Collection
        {
            get
            {
                return collection;
            }
        }
    }
}
