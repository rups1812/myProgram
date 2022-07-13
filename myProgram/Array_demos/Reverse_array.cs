using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.Array_demos
{
    class Reverse_array
    {
        static void Main(string[] args)
        {
            /*int[] a = { 5, 7, 3, 4, 1 };
           
            for(int i =0; i<a.Length; i++)
            {
                for(int j=i+1; j<a.Length; j++)
                {
                    if (a[i] < a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", a));*/




            int[] arr = { 2, 3, 4, 5, 6, 7 };
            int[] rev = new int[arr.Length];

            int i = 0;
            for (int j = rev.Length - 1; j >= 0; j--)
            {
                rev[j] = arr[i];
                i++;
            }

            Console.WriteLine(string.Join(" ", rev));
            Console.ReadLine();
        }

    }
}
