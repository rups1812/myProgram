using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.loops
{
    class while_demo
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
                    Console.WriteLine(i*i + " ", n);
                    
                }
                i++;
            }

        }

    
    }

    class Series
    {
        static void Main(string[] args)
        {
            int d, i, n = 10;
            i = 1;

            while (i <= n)
            {
                d = i * i + 1;
                Console.WriteLine(d + " ");
                i++;
            }


        }
    }

    class Series_2to80
    {
        static void Main(string[] args)
        {
            int d, i, n = 10;
            i = 1;

            while (i <= n)
            {
                d = (i * i) + (i*i*i);
                Console.WriteLine(d + " ");
                i++;
            }
        }
    }
    class Series_1to24
    {
        static void Main(string[] args)
        {
            int d, i, n = 10;
            i = 1;

            while (i <= n)
            {
                d = i * i - 1;
                Console.WriteLine(d + " ");
                i++;
            }
        }
    }
    class Spy
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any number");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int product = 1;
            while(num>0)
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

    class Armstrong
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any number");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int t = num;
            
            while (num > 0)
            {
                int r = num % 10;
                sum = sum + (r*r*r);
                
                num = num / 10;
            }
            if (sum == t)
            {
                Console.WriteLine("number is Armstrong");
            }
            else
            {
                Console.WriteLine("number is not Armstrong");
            }
        }
    }

    class Magic_number
    {
        static void Main(string[] args)
        {
            int magic_no = 67;

            while(true)
            {
                Console.WriteLine("enter the number");
                int num = Convert.ToInt32(Console.ReadLine());

                if(num<magic_no)
                {
                    Console.WriteLine("number is less than magic number");
                    continue;
                }
                else if(num>magic_no)
                {
                    Console.WriteLine("number is greater than magic number");
                    continue;
                }
                else
                {
                    Console.WriteLine("congratulation number is match");
                    break;
                }
            }
        }
    }

    class Decimal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the decimal number");
            int num = Convert.ToInt32(Console.ReadLine());

            int r = 1;
            string b = "";

            while(num>0)
            {
                r = num % 2;
                b = r + b;
                num = num / 2;

            }
            Console.WriteLine(b);


        }
    }

    class Problem
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int N = Convert.ToInt32(Console.ReadLine());

            if(N%2!=0)
            {
                Console.WriteLine("Weird");
            }
            else if (N % 2 == 0 && (N <= 2 && N >= 5))
            {
                Console.WriteLine("Not Weird");
            }
            else if (N % 2 == 0 && (N <= 6 && N >= 20))
            {
                Console.WriteLine("Weird");
            }

            else if (N % 2 == 0 && N > 20)
            {
                Console.WriteLine("Not Weird");
            }
        }
    }
    class Maximum_number
    {
        static void Main(string[] args)
        {
        
            int max=0;
            Console.Write("Enter first number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number : ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                max = num1;
            }
            else if (num2 > num3 )
            {
                max = num2;
            }
            else
            { max = num3; }

            Console.WriteLine(max);

        }
    }
    class Factorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            int fact = 1;
            for(int i=1; i<=n; i++)
            {
                fact = fact * i;
            }

            Console.WriteLine(fact);          
            
        }
    }
}
