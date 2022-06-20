using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.Array_demos
{
    class Max_number
    {
        static void Main(string[] args)
        {
            
            int[] a = { 1, 2, 3, 4, 75, 6, 7, 8, 55, 10 };
            int max = a[0];
          
            for(int i=0; i<a.Length; i++)
            {      
                if(a[i]>max)
                {
                    max = a[i];
                }
            }
            Console.WriteLine(max);
        }
    }

    class Min_number
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 75, 6, 7, 8, 55, 10 };
            int min = a[0];

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            Console.WriteLine(min);

        }
    }
}
