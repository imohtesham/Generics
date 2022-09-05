using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_practice1
{
    class PrintArray<T>
    {
        public T[] inputArray;
        public PrintArray(T[] inputArray)
        {
            this.inputArray = inputArray;
        }

        public void toprint()
        {
            foreach (var i in inputArray)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("*************");
        }

    }
  
}
