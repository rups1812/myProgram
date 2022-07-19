using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.Exception_handling
{
    class Exception_demos
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Enter 2 numbers");
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Divison="+ (n1/n2));
                Console.WriteLine("try ends");
            }
             catch(DivideByZeroException e)
            {
                Console.WriteLine("in catch 1");
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine("in catch 2");
                Console.WriteLine(e.Message);
            }
            catch(SystemException e)
            {
                Console.WriteLine("in catch 3");
                Console.WriteLine(e.Message);
            }



            Console.WriteLine("enter a name");
            string str = Console.ReadLine();

            for (int i = 2; i <= 10; i = i + 2)
            {
                Console.WriteLine(i);
            }
        }
    }



    class Exception_demo2
    {

        public static void m1(int a, int b)
        {
            Console.WriteLine("m1 starts");
            Console.WriteLine("Division="+ a/b);
            Console.WriteLine("m1 ends");
        }
        public static void m2(int x, int y)
        {
            Console.WriteLine("in m2 starts");
            m1(x, y);
            Console.WriteLine("in m2 ends");
        }
        static void Main(string[] args)
        {
            Console.WriteLine(" main starts");
            try
            {
                m2(10, 0);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Main ends");
        }

    }


    class Exception_nested
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Enter 2 numbers");
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Divison=" + (n1 / n2));
                Console.WriteLine("try ends");


                try
                {
                    Console.WriteLine("enter name");
                    string nm = Console.ReadLine();
                    Console.WriteLine("Enter marks");
                    int mks = int.Parse(Console.ReadLine());
                    Console.WriteLine("3rd character in name "+nm[2]);
                }
                catch(IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(SystemException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
