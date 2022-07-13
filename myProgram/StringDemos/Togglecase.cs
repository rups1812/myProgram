using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.StringDemos
{
    class Togglecase
    {

        public static string Toggleword(string str)
        {
            string newcasestr = " ";
            for(int i=0; i<str.Length; i++)
            {
                if(str[i]>='A' && str[i]<='Z')
                {
                    newcasestr = newcasestr + ((char)(str[i] + 32));
                }
                else if(str[i]>='a' && str[i]<='z')
                {
                    newcasestr = newcasestr + ((char)(str[i] - 32));
                }
                else
                {
                    newcasestr = newcasestr + str[i];
                }
            }
            return newcasestr;
        }


        static void Main(string[] args)
        {

            Console.WriteLine("Enter the string ");
            string s = Console.ReadLine();

            Console.WriteLine(Toggleword(s));
        }
    }


}
