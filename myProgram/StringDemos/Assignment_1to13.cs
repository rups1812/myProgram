using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.StringDemos
{
    class Assignment_1to13
    {

        static void Main(string[] args)
        {
            string str = "I love India Country because India is best country";
            str = str.ToLower();

            string[] word = str.Split(' ');


            int count;
            for (int i = 0; i < word.Length; i++)
            {
                count = 1;
                for (int j = i + 1; j < word.Length; j++)
                {

                    if (word[i].Equals(word[j]))
                        count++;

                    
                }
                if (count > 1 && word[i] != "0")

                    Console.WriteLine("Duplicate word= "+ word[i]+"   Occurrence = "+ count);
            }
        }

    }



    class Count_String
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string ");
            string str = Console.ReadLine();

            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                count++;
            }

            Console.WriteLine(count);
        }
    }



    class Anagram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st string");
            string str1 = Console.ReadLine();
            Console.WriteLine("enter 2nd string");
            string str2 = Console.ReadLine();


            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);

            string s1 = new string(ch1);
            string s2 = new string(ch2);


            if(s1==s2)
            {
                Console.WriteLine("string are Anagram");
            }
            else
            {
                Console.WriteLine("string are not anagram");
            }
        }
    }


    class Array_sort
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 5, 7, 4, 9, 2, 3, 10, 6, 8 };

            Array.Sort(a);

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] < a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", a));
        }
    }


    class Specialchar_string
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a string ");
            string str = Console.ReadLine();

            int alp, digit, splch, i;
            alp = digit = splch = i = 0;


            while (i<str.Length)
            {
                if ((str[i] >= 'a' && str[i] <='z') || (str[i]>='A' && str[i]<='Z'))
                {
                    alp++;
                }
                else if(str[i]>='0' && str[i]<='9')
                {
                    digit++;
                }
                else
                {
                    splch++;
                }
                i++;
            }

            Console.WriteLine("Number of Alphabets in the string is = "+ alp);
            Console.WriteLine("Number of Digit in the string is = "+ digit);
            Console.WriteLine("Number of SpecialChar in the string is = "+ splch);
        }
    }

    class UpeerTolower
    {
        public static string ChnageStr(string str)
        {
            string newstring = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                {
                    newstring = newstring + char.ToLower(str[i]);
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
