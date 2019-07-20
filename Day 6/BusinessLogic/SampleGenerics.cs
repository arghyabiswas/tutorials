using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    class SampleGenerics<T> where T : class
    {
        private T instance;

        public T Instance
        {
            get
            {
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        public SampleGenerics(T value)
        {
            instance = value;
        }

        public void GetGenericMethod(T param)
        {
            Console.WriteLine("GEneric Parameter of the type {0}, value {1}", typeof(T), param);
            Console.WriteLine("GEneric member variable of the type {0}, value {1}", typeof(T), instance);
            Console.WriteLine("GEneric Property of the type {0}, value {1}", typeof(T), Instance);
        }
    }
}
