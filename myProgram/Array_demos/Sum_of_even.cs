using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.Array_demos
{
    class Sum_of_even
    {
        static void Main(string[] args)
        {
            int[] a = { 7, 8, 9, 4, 5 };

            int even = 0;

            for(int i=0; i<a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    even = even + a[i];
                }
            }
            Console.WriteLine("Sum of even= " + even);
        }
    }
}
