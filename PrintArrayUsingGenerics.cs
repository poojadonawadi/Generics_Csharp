using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Practice
{
    internal class PrintArrayUsingGenerics<T>
        
    {
        private T[] inputArray;
        public PrintArrayUsingGenerics(T[] inputArray)
        {
            this.inputArray = inputArray;
        }
        
        public void ToPrint(T[] array)
        {
            foreach(T elements in inputArray)
            {
                Console.WriteLine(elements);
            }
        }
    }
}
