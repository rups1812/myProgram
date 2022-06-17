using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.Condition_Demos
{
    class ConditionalDemo2
    {
        static void Main(string[] args)
        {

            /* int n = 21;


             if (n % 2 == 0)
             {
                 Console.WriteLine("Even");
             }
             else
             {
                 Console.WriteLine("Odd");
             }


             if (n < 0)
             {
                 Console.WriteLine("Negative Number!");
             }
             else if (n == 0)
             {
                 Console.WriteLine("Zero");
             }
             else
             {
                 Console.WriteLine("Positive Number!");*/


            /* Console.WriteLine("enter the char");
             char ch = Convert.ToChar(Console.ReadLine());

             if (ch >= 'a' && ch <= 'z')
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
             }*/

            Console.WriteLine("enter the char");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch =='A' ||ch=='E' ||ch=='I' ||ch=='O' ||ch=='U') 
            {
                Console.WriteLine("Vowels");
            }

            else
            {
                Console.WriteLine("Consonents");
            }



        }

    }
}
