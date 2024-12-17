using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Practice
{
    internal class FindMaximum
    {
        public static T GetMax<T>(T  a, T b, T c) where T: IComparable<T>
        {
            T max;
            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0)
            {
                max = a;
                Console.WriteLine($"The maximum number amoung 3 is {max}");
            }
            else if (b.CompareTo(a) > 0 && b.CompareTo(c) > 0)
            {
                max = b;
                Console.WriteLine($"The maximum number is {max}");
            }
            else
            {
                max = c;
                Console.WriteLine($"The maximum number is {max}");
            }
            return max;
        }
    }
}
