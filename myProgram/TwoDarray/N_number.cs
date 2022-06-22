using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.TwoDarray
{
    class N_number
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 5, 4, 3 }, { 2, 7, 8, 1 } };

            for(int i=0; i<=a.GetUpperBound(0); i++)
            {
                for(int j=0; j<=a.GetUpperBound(1); j++)
                {
                    Console.Write(a[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("......................................");
            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= a.GetUpperBound(1); j++)
                {
                    if (j == 0 || j == 3 || (i==j && j !=a.GetUpperBound(0) && j !=a.GetUpperBound(1)))
                    {
                        Console.Write(a[i,j]);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }


            Console.WriteLine(".........................................");


            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= a.GetUpperBound(1); j++)
                {
                    if (j == 0 || j == 3 || (i == j && j != a.GetUpperBound(0) && j != a.GetUpperBound(1)))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }


        }
    }
}
