using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.loops
{
    class Assignment_1to15
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Divided by 5 & 10: ");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0 && i % 10 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }

    class Do_While
    {
        static void Main(string[] args)
        {
            int b = 0;
            do
            {
                int a = 2;
                b++;
                Console.WriteLine(a++);
            }
            while (b != 3);
        }

    }

    class Output
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

    class Spy_number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any number");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int product = 1;
            while (num > 0)
            {
                int r = num % 10;
                sum = sum + r;
                product = product * r;
                num = num / 10;
            }
            if (sum == product)
            {
                Console.WriteLine("number is Spy");
            }
            else
            {
                Console.WriteLine("number is not Spy");
            }
        }
    }

    class Trimorphic
    {
        static void Main(string[] args)
        {
            bool flag = true;
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());

            int cube = n * n * n;

            while (n != 0)
            {
                if (n % 10 != cube % 10)
                {
                    flag = false;
                    break;
                }

                n = n / 10;
                cube = cube / 10;
            }
            if (flag)
            {
                Console.WriteLine("Number is Trimorphic");
            }
            else
            {
                Console.WriteLine("Number is not Trimorphic");
            }

        }
    }

    class Pyramid_number
    {
        static void Main(string[] args)
        {
            int i, j, k;
            int z = 1;
            int n = 4;
            for (i = 1; i <= n; i++)
            {
                for (j = n - 1; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= z; k++)
                {
                    Console.Write(i + "");
                }
                z += 2;

                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }

    class Triangle_pattern
    {
        static void Main(string[] args)
        {
            int i, j, k;
            for (i = 4; i >= 1; i--)
            {
                for (j = 4; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (k = 1; k < (i * 2); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }

    class Number_pattern
    {
        static void Main(string[] args)
        {
            int i, j, k;

            int n = 5;
            for (i = 1; i <= n; i++)
            {
                int p = 1;
                for (j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (k = i; k <= n; k++)
                {
                    Console.Write(p++ + "");
                }

                Console.WriteLine("\n");
            }
        }
    }

    class Loop
    {
        static void Main(string[] args)
        {
            for (int i = 5; i > 0; i--)
            {
                int mysteryInt = 100;
                mysteryInt -= i;
                Console.WriteLine(mysteryInt);
            }

        }
    }

    class Twin_prime
    {
        public static void Main()
        {
            Console.Write("Enter 1sr Number : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter 2nd Number : ");
            int num2 = int.Parse(Console.ReadLine());

            bool IsAPrime = true;
            for (int i = 2; i < num1 / 2; i++)
            {
                if (num1 % i == 0)
                {
                    IsAPrime = false;
                    break;
                }
            }

            if (IsAPrime && Math.Abs(num1 - num2) == 2)
            {

                bool IsBPrime = true;

                for (int i = 2; i <= num2 / 2; i++)
                {

                    if (num2 % i == 0)
                    {
                        IsBPrime = false;
                        break;
                    }

                }



                if (IsBPrime)
                {
                    Console.Write("Number is TwinPrime.");
                }
                else
                {
                    Console.Write("Number is not TwinPrime.");
                }
                Console.ReadKey();
            }
        }




        class Print_series
        {
            static void Main(string[] args)
            {

                int d, i, n = 10;
                i = 1;

                while (i <= n)
                {
                    d = (i * i) + (i * i * i);
                    Console.WriteLine(d + " ");
                    i++;
                }
            }
        }

        class Prime_number
        {
            static void Main(string[] args)
            {
                int i = 0;
                Console.WriteLine("enter a number");
                int n = Convert.ToInt32(Console.ReadLine());
                i = n;


                while (i <= n)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(i + " ", n);


                    }
                    else
                    {
                        Console.WriteLine(i * i + " ", n);

                    }
                    i++;
                }
            }
        }

        class Break
        {
            static void Main(string[] args)
            {
                int i = 1;

                while (i <= 5)
                {
                    int j = 1;
                    while (j <= 5)
                    {
                        if (j == 2)
                        {
                            break;
                            Console.WriteLine(j);
                        }
                        j++;
                    }
                    Console.WriteLine(i);
                }


            }
        }

        class Fibonacci_1to20
        {
            static void Main(string[] args)
            {
                int n1 = 0, n2 = 1, n3, i, number;
                Console.Write("Enter the number of elements: ");
                number = int.Parse(Console.ReadLine());
                Console.Write(n1 + " " + n2 + " ");
                for (i = 2; i < number; ++i)
                {
                    n3 = n1 + n2;
                    Console.Write(n3 + " ");
                    n1 = n2;
                    n2 = n3;
                }
            }
        }

        class Factorial_1to5
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter a number");
                int n = int.Parse(Console.ReadLine());
                int fact = 1;
                for (int i = 1; i <= n; i++)
                {
                    fact = fact * i;
                }

                Console.WriteLine(fact);
            }
        }

    }
}
