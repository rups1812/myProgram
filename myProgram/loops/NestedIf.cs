using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.loops
{
    class NestedIf
    {
        static void Main(string[] args)
        {
            
            int i, j, k;
            for (i = 1; i <=4; i++)
            {
                for(k = 4; k >= i; k--)
                
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }

    class table1_1to5
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write(i * j + "\t");
                }
                Console.Write("\n");
            }

            Console.ReadLine();
        }
    }

    class Pattern
    {
        static void Main(string[] args)
        {
            int i,j;
            for (i = 1; i <= 4; i++)
            {
                for (j = 1; j <= 4; j++)
                {
                    if (i == 1 || i == 4 || j == 1 || j == 4)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }           
        }
    }

    class triangle_pattern
    {
        static void Main(string[] args)
        {
            int i, j;
            
            for (i = 1; i <= 5; i++)
            {
                for (j = i; j < 5; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= (2 * i - 1); j++)
                {
                    if (i == 5 || j == 1 || j == (2 * i - 1))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }

    class N_pattern
    {
        static void Main(string[] args)
        {
            int row, column;
            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (column == 1 || column == 5 || (row == column && column != 0 && column != 6))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
    
    }
    

    class plus_pattern
    {
        static void Main(string[] args)
        {
            int i, j;
            int MAX = 5;
            for (i = 1; i <= MAX; i++)
            {
                for (j = 1; j <= MAX; j++)
                {
                    if (i==3||j==3)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }

    class number_pattern
    {
        static void Main(string[] args)
        {
            int i, j;
            for(i=4; i>=1; i--)
            {
                for(j=1; j<=i; j++)
                {
                    Console.Write(j+" ");
                }
                Console.WriteLine();
            }
        }
    }

    class Pattern2
    {
        static void Main(string[] args)
        {
            int i,j;
            for (i = 1; i <=4; i++)
            {
                for (j = 4; j >= i; j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }

    class Pattern3
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 1; i <= 4; i++)
            {
                for (j = 4; j >= i; j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

        }
    }

    class Pattern4
    {
        static void Main(string[] args)
        {

            
            int i, j, k=1;
            for (i = 1; i <= 3; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(k+"");
                    k++;
                }
               
                Console.WriteLine("");
            }
        }
    }

    class Pattern5
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 1; i <= 4; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(j % 2);
                    
                }

                Console.WriteLine("");
            }
        }
    }

    class Pattern6
    {
        static void Main(string[] args)
        {
            int c = 64;
            for(int i=1; i<5; i++)
            {
                for(int j=1; j<=i; j++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write((char)(c + j));
                    }
                    else
                    {
                        Console.Write(j);
                    }
                }
                Console.WriteLine();
            }
        }
    }

    class sum_of_prime
    {
        static void Main(string[] args)
        {
            int i, p, k, s = 0;

            for (i = 2; i <= 10; i++)
            {
                k = 2;
                p = 1;
                while (k < i)
                {
                    if (i % k == 0)
                    {
                        p = 0;
                        break;
                    }
                    k++;
                }
                if (p == 1)
                {
                    s = s + i;
                }
            }

            Console.WriteLine("Sum of prime numbers:" + s);
        }
    }


    class Disarium
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int count = 0;
            int digit;
            int temp = num;

            while(temp!=0)
            {
                temp = temp / 10;
                count++;

            }

            temp=num;

            while(temp!=0)
            {
                digit = temp % 10;
                sum = sum + (int)Math.Pow(digit, count);
                temp = temp / 10;
                count--;
            }
            if(sum==num)
            {
                Console.WriteLine(num +" Is a Disarium number");
            }
            else
            {
                Console.WriteLine(num +" Is not Disarium number");
            }

            Console.WriteLine();
        }
    }

    class Kaprekar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num;

            int sqr = num * num;
            int count = 0;

            while(num>0)
            {
                count++;
                num = num / 10;
            }

            int power = 1;
            for(int i=1; i<=count; i++)
            {
                power = power * 10;
            }

            int division = sqr / power;
            int remainder = sqr % power;

            int sum = division + remainder;
            if (sum == num)
            {
                Console.WriteLine(num + " Is a Kaprekar number");
            }
            else
            {
                Console.WriteLine(num + " Is not Kaprekar number");
            }

            Console.WriteLine();


        }
    }

    class Automorphic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());

            int count = 0;
            int temp = num;

            while(num>0)
            {
                count++;
                num = num / 10;
            }
            num = temp;
            int sqr = num * num;
            int power = 1;
            for(int i=1; i<=count; i++)
            {
                power = power * 10;
            }

            int end = sqr % power;
            Console.WriteLine(sqr+" "+" end= "+ end);

            if (end == num)
            {
                Console.WriteLine("Automorphic");
            }
            else
            {
                Console.WriteLine("Not Automorphic");
            }
        }
    }
}

