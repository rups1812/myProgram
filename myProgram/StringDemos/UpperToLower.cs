using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.StringDemos
{
    class UpperToLower
    {
        public static string ChnageStr(string str)
        {
            string newstring = "";
            for(int i=0; i<str.Length; i++)
            {
                if(char.IsUpper(str[i]))
                {
                    newstring = newstring + char.ToLower(str[i]);
                }
                else if (char.IsLower(str[i]))
                {
                    newstring = newstring + char.ToUpper(str[i]);
                }
                else
                {
                    newstring = newstring + str[i];
                }
            }
            return newstring;

     
        }




         static void Main(string[] args)
        {
            Console.WriteLine("Enter the string ");
            string s = Console.ReadLine();

            Console.WriteLine(ChnageStr(s));

        }
    }
}
