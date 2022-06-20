using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.Array_demos
{
    class Merge_array
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = { 11, 22, 33, 44, 55 };
            int[] c = { a.Length + b.Length };
            int j = 0;

            for(int i=0; i<a.Length; i++)
            {
                c[j] = a[i];
                j++;
            }
            for(int i=0; i<b.Length; i++)
            {
                c[j] = b[i];
                j++;
            }
            for(int i=0; i<c.Length; i++)
            {
                Console.WriteLine(c[i]);
            }

            Console.WriteLine("      ");
        }
    }
}
