using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.Interface
{

    public interface Iaddable
    {
        static int a = 10;
        
    }

    abstract class Add
    {
        public static int b = 50;
    }



    class Addition:Add,Iaddable
    {

        public void Calculate()
        {
            Console.WriteLine("addition= "+ (Iaddable.a+Add.b));
        }

    }



    class Abstraction_Interface
    {
        static void Main(string[] args)
        {
            Addition a = new Addition();
            a.Calculate();
        }
    }

}
