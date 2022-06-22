using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.StringDemos
{
    class Count_words
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string ");
            string str = Console.ReadLine();

            int count = 0;
            for(int i=0; i<str.Length;i++)
            {
                count++;
            }

            Console.WriteLine(count);
        }
    }
}
