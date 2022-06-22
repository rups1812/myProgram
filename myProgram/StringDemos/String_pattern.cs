using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.StringDemos
{
    class String_pattern
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string ");
            string str = Console.ReadLine();
            string[] s = str.Split(' ') ;
            for (int i = 0; i <s.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(s[j]+' ');

                }
                Console.WriteLine();
            }

        }
    }
}
