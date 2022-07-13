using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.StringDemos
{
    class String_sort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string str = Console.ReadLine();
            string[] s = str.Split(" ");

            for (int i=0; i<s.Length;i++)
            {
                for(int j=i+1; j<s.Length; j++)
                {
                    if(s[i].CompareTo(s[j])==-1)
                    {
                        string temp = s[i];
                        s[i] = s[j];
                        s[j] = temp;
                    }
                }
            }

            Console.WriteLine(string.Join(" ",s));
        }
    }
}
