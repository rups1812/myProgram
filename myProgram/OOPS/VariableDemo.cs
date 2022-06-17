using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.OOPS
{
    class VariableDemo
    {
        public int x;


        public void Accept()
        {
            x = 201;
        }

        public void Display()
        {
            Console.WriteLine(x);
        }

        static void Main(string[] args)
        {
            VariableDemo v = new VariableDemo();

            v.Accept();
            v.Display();
        }
    }
}
