using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.Basic
{
    class Swap
    {

        public static void Main(string[] args)
        {
            int a = 75, b = 84, t;
            t = a;
            a = b;
            b = t;
            Console.WriteLine("Values after swapping:");
            Console.WriteLine("a is :" + a);
            Console.WriteLine("b is :" + b);

        }
    }
    
 }




