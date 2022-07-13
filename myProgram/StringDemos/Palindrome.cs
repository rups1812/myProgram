using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.StringDemos
{
    class Palindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();
            string revs = "";

            for(int i=s.Length-1; i>=0; i--)
            {
                revs = revs + s[i];
            }
            if(revs==s)
            {
                Console.WriteLine("string is palindrome" ,s,revs);
            }
            else
            {
                Console.WriteLine("string is not palindrome", s, revs);
            }
        }
    }
}
