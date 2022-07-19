using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.Deligates
{
    class Deligate_Demo
    {
        //Declare delegate
        public delegate void mydelegate(int x);

        public void square(int a)
        {
            Console.WriteLine("square= "+a*a);
        }

        static void Main(string[] args)
        {
            //Set a target
            Deligate_Demo ob = new Deligate_Demo();
            mydelegate d1 = ob.square;
            d1(7);
        }
    }
}


//declare a delecate
//set a target
//Invoke
//Emp e1 -- reference emp object
//delegates variable -- store reference method reference
