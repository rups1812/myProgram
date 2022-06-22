using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.StringDemos
{
    class Reverse_words
    {
        public static string ReverseEachWords(string str)
        {
            string[] s = str.Split(' ');
            string reverse = "";
            for (int i = 0; i < s.Length; i++)
            {

                if (i == 0 || i == s.Length - 1)
                {
                    reverse = reverse + " " + s[i];
                }
                else
                {
                    string word = s[i];
                    string reverseword = "";

                    for (int j = word.Length - 1; j >= 0; j--)
                    {
                        reverseword = reverseword + word[j];
                    }
                    reverse = reverse + " " + reverseword;
                }
            }

            return reverse;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();
            string reversenew = ReverseEachWords(s);
            Console.WriteLine(reversenew);
            Console.ReadLine();
            
        }
    }
}
