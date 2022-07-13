using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.StringDemos
{
    class String_pratice
    {
        static void Main(string[] args)
        {
            string s = "Hello";
            string str = "Hello";
            string st = new string("Hello");

            Console.WriteLine(st == s);
            Console.WriteLine(str==st);
            Console.WriteLine(str.GetHashCode());

            str = str + "c#";

            Console.WriteLine(str.GetHashCode());
            Console.WriteLine(str);           

        }
    }


    class Pratice_SrtingDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            String str = Console.ReadLine();
            int l = str.Length;
            Console.WriteLine(l);
            Console.WriteLine("...............");
            string newUpper = str.ToUpper();
            Console.WriteLine(newUpper);
            Console.WriteLine("////////////");

            string newLower = newUpper.ToLower();
            Console.WriteLine(newLower);
            Console.WriteLine("...............");


            char[] ch = str.ToCharArray();
            Console.WriteLine(string.Join("",ch));
            Console.WriteLine("////////////////////");
            string substringnew = str.Substring(3);
            Console.WriteLine(substringnew);
            Console.WriteLine("..........................");


            string sub2 = str.Substring(3, 6);
            Console.WriteLine(sub2);
            Console.WriteLine("/////////////////////////");


            Console.WriteLine(str[0]+" "+str[str.Length-1]);
            Console.WriteLine(".................");

            string[] word = str.Split(" ");

            foreach(string st in word)
            {
                Console.WriteLine(st);
            }


            Console.WriteLine(str.IndexOf('i'));
            Console.WriteLine(str.LastIndexOf('i'));

            
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
        }
    }
}
