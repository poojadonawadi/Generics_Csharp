using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Practice
{
    //Displaying elements using generics class
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Integer elements");
            //int[] intArray = { 1, 2, 3, 4, 5, 6 };
            //PrintArray.ToPrint(intArray);
            //Console.WriteLine("Float Elements");
            //double[] doubleArray = { 1.1, 1.2, 1.3, 1.4 };
            //PrintArray.ToPrint(doubleArrayc);
            //Console.WriteLine("Character Elements");
            //char[] charArray = { 'a', 'b', 'c', };
            //PrintArray.ToPrint(charArray);

            //new PrintArrayUsingGenerics<int>(intArray).ToPrint(intArray);
            //new PrintArrayUsingGenerics<double>(doubleArray).ToPrint(doubleArray);
            //new PrintArrayUsingGenerics<char>(charArray).ToPrint(charArray);
            
            Console.WriteLine(FindMaximum.GetMax<int>(3, 6, 10));
            Console.WriteLine(FindMaximum.GetMax<double>(1.2, 2.21, 3.12));
            Console.WriteLine(FindMaximum.GetMax<string>("Pooja", "Chetan", "Shivanand"));
        }
    }
}
