using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.Array_demos
{
    class Alternate_element
    {
        static void printAlter(int[] arr, int N)
        {
            for (int i = 0; i< N; i++)
            {

                if (i % 2 == 0)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }

        public static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int N = arr.Length;

            printAlter(arr, N);
        }
    }
}

