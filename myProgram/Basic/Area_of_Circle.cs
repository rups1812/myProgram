using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.Basic
{
    class Area_of_Circle
    {
        static void Main(string[] args)
    
       
    {
        double radius, a;
        const double pi = 3.14;
        radius = 20;
        a=pi* radius* radius;
        Console.WriteLine(a);

        }
    }



    class Addition
    {
        static void Main(string[] args)
        {
            int x=4, y=8, z=15;
            int sum;

            sum = x + y + z;

            Console.WriteLine(sum);
        }
    }
}
