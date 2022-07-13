using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.Prorigo
{
    class Coprime
    {

        public static int CoprimeNumber(int n)
        {
            int gcd = 0;
            int c = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int divisor = 1; divisor <= i; divisor++)
                {
                    if (n % divisor == 0 && i % divisor == 0)
                        gcd = divisor;
                }

                if (gcd == 1)
                    c++;
            }
            return c ;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");   //input=4
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Coprime.CoprimeNumber(n));
        }
    }
}
