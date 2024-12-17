using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Practice
{
    //Displaying elements without using Generics
    internal class PrintArray
    {
        public static void ToPrint(int[] intArray)
        {
            foreach(int elements in intArray)
            {
                Console.WriteLine(elements);
            }
        }
        public static void ToPrint(double[] doubleArray)
        {
            foreach (double elements in doubleArray)
            {
                Console.WriteLine(elements);
            }
        }
        public static void ToPrint(char[] charArray)
        {
            foreach (char elements in charArray)
            {
                Console.WriteLine(elements);
            }
        }
    }
}
