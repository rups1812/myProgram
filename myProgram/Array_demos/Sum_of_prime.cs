using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.Array_demos
{
    class Sum_of_prime
    {
        static void Main(string[] args)
        {
            int[] a = new int[7];
            int sum = 0;

            Console.WriteLine("Enter Array elements");

            for(int i=0; i<a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < a.Length; i++)
            {
                bool isprime = true;
                int n = a[i];
                for(int j=2; j<n; j++)
                {
                    if(n%j==0)
                    {
                        isprime = false;
                        break;
                    }
                }            
              
                if (isprime==true)
                {
                    sum = sum + a[i];

                }
                

            }
            Console.WriteLine(sum);
        }
    }
}
