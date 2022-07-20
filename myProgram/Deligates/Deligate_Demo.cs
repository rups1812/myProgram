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
            Console.WriteLine("square= " + a * a);
        }

        static void Main(string[] args)
        {
            //Set a target
            Deligate_Demo ob = new Deligate_Demo();                  //declare a delecate
                                                                     //set a target
                                                                     //Invoke
                                                                     //Emp e1 -- reference emp object
                                                                     //delegates variable -- store reference method reference
            mydelegate d1 = ob.square;
            d1(7);
        }
    }






    class Demo
    {
        public delegate int Mydelegate1(int x);

        public static int Factorial(int a)
        {
            int f = 1;
            for (int i = 1; i <= a; i++)
            {
                f = f * i;
            }
            return f;
        }


        static void Main(string[] args)
        {
            Mydelegate1 d1 = Factorial;
            d1(7);

        }
    }



    class Demo1
    {
        public delegate void mydelegate2(int x);

        public void square(int a)
        {
            Console.WriteLine("square= " + a * a);
        }

        public void cube(int x)
        {
            Console.WriteLine("Cube= "+x*x*x);
        }

        public void doubleup(int a)
        {
            Console.WriteLine("Double_up= "+2*a);
        }
        static void Main(string[] args)
        {
            Demo1 db = new Demo1();
            mydelegate2 d2 = db.square;
            d2 = d2 + db.cube;
            d2=d2+ db.doubleup;
            d2(6);
            
        }
    }





    public delegate void mydel1(int x, int y);

    class Demo2
    {
        static void Main(string[] args)
        {
            mydel1 d1 = delegate (int x, int y)
            {
                Console.WriteLine("sum= " + (x + y));
            };

            d1(10, 20);



            //lambda expression

            mydel1 d2 = (x, y) =>
            {
                Console.WriteLine("Addition= " + (x + y));
            };

            d2(11, 12);
        }
    }



    public delegate bool mydel3(int a);
    class Prime
    {
        static bool isPrime(int n)
        {
            bool isPrime = true;
            for(int i=2; i<=n/2; i++)
            {
                if(n%i==0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }
        static void Main(string[] args)
        {
            mydel3 d3 = (n) =>
             {
                 bool isPrime = true;
                 for (int i = 2; i <= n / 2; i++)
                 {
                     if (n % i == 0)
                     {
                         isPrime = false;
                         break;
                     }
                 }
                 return isPrime;
             };
        }
    }



    class Demo3
    {
        static string greet()
        {
            return "Good Morning";
        }

        static int product(int a, int b, int c)
        {
            return a * b * c;
        }

        static bool iseven(int x)
        {
            if (x % 2 == 0)
                return true;
            else
                return false;
            //or
            // return x%2==0;
        }

        static void Main(string[] args)
        {
            Func<string> p1 = greet;
            Func<int, int, int, int> p2 = product;
            int prod = p2(2,3, 4);
            Console.WriteLine("Multiplication= "+prod);

            //Action

            Action<int, int> p3 = (a, b) => Console.WriteLine("Addition= "+(a+b));


            //Predicate

            Func<int, bool> p4 = iseven;
            bool q = p4(89);

            Predicate<int> p5 = iseven;
            bool qq = p5(78);
        }
    }


    class Mycallback
    {
        public static void display()
        {
            Console.WriteLine("Good Morning");
        }

        public static void square(int a, Action d1)
        {
            Console.WriteLine("square= " + a * a);
            d1();
        }

        static void Main(string[] args)
        {
            square(9, display);

            //square(10, () => Console.WriteLine("Good Morning");
        }
    }
}


