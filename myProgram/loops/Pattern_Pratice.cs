using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.loops
{
    class Pattern_Pratice
    {
        static void Main(string[] args)
        {
            for(int i=0; i<=4; i++)
            {
                for(int j=4; j>=i; j--)
                {
                    Console.Write("1 ");
                }
                Console.Write("\n");
            }
            Console.WriteLine();
        }
    }
}
