using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.Array_demos
{
    class Unique_array
    {
        static void Main(string[] args)
        {

            int[] a = { 11, 22, 33, 44, 101, 104 };
            int[] b = { 101, 102, 44, 103, 104, 11, 33 };
            int[] c = new int[a.Length + b.Length];
            int j = 0;

            for (int i = 0; i < a.Length; i++)
            {
                bool isPresent = false;
                for (int k = j - 1; k >= 0; k--)
                {
                    if (c[k] == b[i])
                    {
                        isPresent = true;
                        break;
                    }
                }
                if (isPresent == false)
                {

                    c[j] = a[i];
                    j++;
                }
            }
            for (int i = 0; i < b.Length; i++)
            {
                bool isPresent = false;
                for(int k=j-1;k>=0;k--)
                {
                    if (c[k] == b[i])
                    {
                        isPresent = true;
                        break;
                    }
                }
                if (isPresent == false)
                {
                    c[j] = b[i];
                    j++; 
                }
            }
            Console.WriteLine(string.Join(" ",a));
            Console.WriteLine();
            Console.WriteLine(string.Join(" ", b));
            Console.WriteLine(".............................");

            for(int i=0;i<j;i++)
            {
                Console.Write(c[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
