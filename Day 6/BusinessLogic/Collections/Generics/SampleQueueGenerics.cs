using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Collections
{
    class SampleQueueGenerics
    {
        public SampleQueueGenerics()
        {
            collection.Enqueue("oracle");
            collection.Enqueue("vb.net");
            collection.Enqueue("cs.net");
            collection.Enqueue("asp.net");
        }

        Queue<string> collection = new Queue<string>();
        public Queue<string> Collection
        {
            get
            {
                return collection;
            }
        }
    }
}
