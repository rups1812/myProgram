using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.Prorigo
{
    class Largest_subarray_length
    {
        public int LargestSubarray(int size, int[] arr)  //input1=4
        {
            int j;                                      //input2=1,2,3,4
            int max = 0;
            int zero, ones;
            for (int i = 0; i < arr.Length; i++)
            {
                zero = 0;
                ones = 0;
                for (j = i; j < arr.Length; j++)
                {
                    if (arr[j] == 0)
                        zero++;
                    else
                        ones++;

                    if (zero == ones)
                    {
                        max = max > (j - i + 1) ? max : j - i + 1;
                    }
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the size");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];

            Console.WriteLine("enter a array");
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Largest_subarray_length L = new Largest_subarray_length();
            Console.WriteLine(L.LargestSubarray(size,arr));
            
        }
    
    }
}
