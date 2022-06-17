using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.OOPS
{
    class Arithmetic_operation
    {

        void Calculate(int x, int y)
        {
            Console.WriteLine("Add= "+ (x+y));
        }

        void Calculate(int x, int y, int z)
        {
            Console.WriteLine("Substarct= "+ (x-y-z));
        }

        void Calculate(float x, float y)
        {
            Console.WriteLine("Multiply= "+ (x*y));
        }

        void Calculate(double x, double y)
        {
            Console.WriteLine("Division= "+ (x/y));
        }
        static void Main(string[] args)
        {
            Arithmetic_operation A = new Arithmetic_operation();
            A.Calculate(8, 9);
            A.Calculate(20, 8, 7);
            A.Calculate(4.5, 5.6);
            A.Calculate(20.20, 10.26);
        }
    }

    class OverlaodDemo
    {

        void Area(float x)
        {
            Console.WriteLine("The area of square= "+ (x*x));
        }

        void Area(float x, float y)
        {
            Console.WriteLine("The area of rectangle= "+ (x*y));
        }

        void Area(double x)
        {
            Console.WriteLine("The area of circle= "+ (3.14*x*x));
        }

        void Area(double x, double y)
        {
            Console.WriteLine("The area of traingle= "+ (x+y/2));
        }


        static void Main(string[] args)
        {
            OverlaodDemo A = new OverlaodDemo();
            A.Area(5);
            A.Area(8,6);
            A.Area(8);
            A.Area(14,18);
        }
    }

    class StaticOverloading
    {
        static void Show()
        {
            Console.WriteLine("this is static");
        }

        static void Show(string hii)
        {
            Console.WriteLine("string= "+ hii);
        }

        static void Show(int x, int y)
        {
            Console.WriteLine("Multipy= " + (x*y));
        }


        static void Main(string[] args)
        {
            StaticOverloading s = new StaticOverloading();
            Show();
            Show(8, 2);
            Show("hello");

        }

    }

    class StaticConstructor
    {

        static StaticConstructor()
        {
            Console.WriteLine("This is constructor");
        }

          StaticConstructor(string name)
        {
            Console.WriteLine("string= "+ name);
        }

          StaticConstructor(int a, int b)
        {
            Console.WriteLine("Sum= "+ (a+b));
        }


        static void Main(string[] args)
        {
           // StaticConstructor c = new StaticConstructor();
            StaticConstructor c1 = new StaticConstructor("Rupesh");
            StaticConstructor c2 = new StaticConstructor(8, 15);
        }
    }

}
