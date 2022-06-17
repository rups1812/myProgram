using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.loops
{
    class Assignment_1to10
    {
        static void Main(string[] args)
        {
            //Equilateral triangle
            Console.Write("Enter the Length of Side:");
            float side = float.Parse(Console.ReadLine());

            float root = (float)Math.Sqrt(3) / 4;
            float area = root * side * side;

            Console.WriteLine("Area of Equilateral Triangle is:" + area);
        }
    }

    class Percentage
    {
        static void Main(string[] args)
        {
            float average, percentage, total = 500f;
            float maths, science, english, physics, chemistry;
            
         
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Enter Marks for Maths for range 0-100");
            maths = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Marks for Science for range 0-100");
            science = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Marks for English for range 0-100");
            english = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Marks for Physics for range 0-100");
            physics = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Marks for Chemistry for range 0-100");
            chemistry = float.Parse(Console.ReadLine());
            Console.WriteLine("Validating Marks....");
            System.Threading.Thread.Sleep(3000);
            average = (maths + science + english + physics + chemistry) / total;
            Console.WriteLine("Average score is :{0}", average);
            percentage = average * 100;
            Console.WriteLine("Percentage obtained by student is: {0}", percentage);
            Console.ReadLine();
        }
    }
    
    class Operator_math
    {
        static void Main(string[] args)
        {
            int a = 5; int b = 4; int c = 3;
            Console.WriteLine(a++ + b * ++c);
            Console.WriteLine("a = " + a + " b= " + b + " c = " + c);
            Console.WriteLine(b * 5 / a + b++ + b);
            Console.WriteLine("a = " + a + " b= " + b + " c = " + c);

        }
    }

    class leapyear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0)
            {
                if ((year % 100 == 0) && (year % 400 != 0))
                    Console.Write("{0} is not a leap year", year);
                else
                    Console.Write("{0} is a leap year", year);
            }
            else
                Console.Write("{0} is not a leap year", year);
        } 
    }
    
    class Divisible_5and11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num%5==0 && num%11==0)
            {
                Console.WriteLine("Divisible by 5 and 11");
            }
            else
            {
                Console.WriteLine("Not divisible by 5 and 11");
            }
        }
    }

    class maximum
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
           
            num1 = 10;
            num2 = 20;
            num3 = 50;
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("Number one is the largest!\n");
                }
                else
                {
                    Console.Write("Number three is the largest!\n");
                }
            }
            else if (num2 > num3)
                Console.Write("Number two is the largest!\n");
            else
                Console.Write("Number three is the largest!\n");
        }
    }
    
    class vowels
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any character");
            char ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("Vowels");
            }
            else
            {
                Console.WriteLine("Consonants");
            }

        }
    }

    class Simple_calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Add");
            Console.WriteLine("2.Substract");
            Console.WriteLine("3.Multiply");
            Console.WriteLine("4.Divide");
            Console.Write("Enter Choice(1-4):");
            int ch = Int32.Parse(Console.ReadLine());
            int a, b, c;
            if (ch == 1)
            {
                Console.Write("Enter A:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter B:");
                b = Convert.ToInt32(Console.ReadLine());
                c = a + b;
                Console.WriteLine("Sum = {0}", c);
            }
            else if (ch == 2)
            {
                Console.Write("Enter A:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter B:");
                b = Convert.ToInt32(Console.ReadLine());
                c = a - b;
                Console.WriteLine("Difference = {0}", c);
            }
            else if (ch == 3)
            {
                Console.Write("Enter A:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter B:");
                b = Convert.ToInt32(Console.ReadLine());
                c = a * b;
                Console.WriteLine("Product = {0}", c);
            }
            else if (ch == 4)
            {
                Console.Write("Enter A:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter B:");
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine("Quotient = {0}", c);
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }
        }
    }

    class Special_character
    {
        static void Main(string[] args)
        {
            char ch;

            Console.WriteLine("Enter any character: ");
            ch = Convert.ToChar(Console.ReadLine());


            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine(ch + "is an Alphabet. ");
            }
            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine(ch + "is a Digit. ");
            }
            else
            {
                Console.WriteLine(ch + "is a Special character.. ");
            }
        }
    }

    class Even_odd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Even number");
            }
            else
            {
                Console.WriteLine("Odd number");
            }
        }
    }
}
