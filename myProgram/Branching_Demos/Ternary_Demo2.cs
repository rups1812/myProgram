using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.Branching_Demos
{
    class Ternary_Demo2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());

            string max = (num < 0) ? "number is negative" : "number is positive";
            string temp = (num == 0) ? "number is zero" : max;
            Console.WriteLine(temp);
        }
    }
}
