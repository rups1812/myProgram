using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.Array_demos
{
    class Odd_position
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Elements of given array present on odd position: ");
            
            for (int i = 0; i < arr.Length; i = i + 2)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
