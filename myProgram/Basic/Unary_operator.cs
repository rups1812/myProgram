using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.Basic
{
    class Unary_operator
    {
        public static void Main(string[] args)
        {
            int a = 4;
            int b = 4;

            int x = ++a + ++b;
            Console.WriteLine(x + " " + a + " " + b);

            x = --a + --b;
            Console.WriteLine(x + " " + a + " " + b);

            x = ++a - --b + b;
            Console.WriteLine(x + " " + a + " " + b);

            /* int x = a++ + b++;
             Console.WriteLine(x + " " + a + " " + b);

             x = ++a + b++ + a;
             Console.WriteLine(x + " " + a + " " + b);*/


        }
    }
}
