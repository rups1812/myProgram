using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.Branching_Demos
{
    class Ternary_Demo1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int number = int.Parse(Console.ReadLine());

            string result = (number % 2 == 0) ? "number is even" : "number is odd";
            Console.WriteLine(result);

        }
    }
}
