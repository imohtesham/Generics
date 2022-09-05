using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_practice1
{
    public class GenericsMax<T> where T : IComparable
    {
        public T[] value;
         
     
        public GenericsMax(T[] value)
        {
            this.value = value;
        }     
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        public T Maxvalue(params T[] values)
        {
            var sortedvalues = Sort(values);
            return sortedvalues[0];
        }
        public T Maxvalue()
        {
            var max = Maxvalue(this.value);
            return max;
        }
        public void printmaxvalue()
        {
            var max = Maxvalue(this.value);
            Console.WriteLine("Max value  is " + max);
        }

    }
       
   
}
