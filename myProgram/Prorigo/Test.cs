using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.Prorigo
{
    
    public class Test
    {
        
        public static void Main(string[] args)
        {
         

          
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
