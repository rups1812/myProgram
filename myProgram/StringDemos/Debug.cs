using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.StringDemos
{
    class Debug
    {
        static void Main(string[] args)
        {

            int i = 1; int k = 1;
            while (i++ <= 5)
            {
                k *= i;
            }
            Console.WriteLine("k= " + k + " i= " + i);

        }
    }
}
