using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.Collection
{
    class Generic
    {
        static void Main(string[] args)
        {
            // array is growable and default array is 4
            //duplicate,insertion,index base


            List<string> l2 = new List<string>() { "deepa", "medha", "kriti" };

            List<string> lst = new List<string>(20);
            Console.WriteLine(lst.Count);
            Console.WriteLine(lst.Capacity);
            lst.Add("A");
            lst.Add("B");
            lst.Add("A");
            lst.Add("D");
            lst.Add("A");
            lst.Add("E");
            lst.Add("H");



            //lst.AddRange(l2);
            lst.InsertRange(0, l2);

            //lst.Remove("A");
            //lst.RemoveAt(0);
           // lst.Add("chitra");
            //lst.Insert(3, "chitra");

            string[] str = lst.ToArray();
            //lst.Claer();

            int idx1 = lst.IndexOf("A");
            int idx2 = lst.LastIndexOf("A");

            Console.WriteLine(lst.Contains("kavita"));




        }
    }


    class A
    {
        static bool isOdd(int n)
        {
            Console.WriteLine("in odd "+n);
            return n % 2 == 1;

        }

        static void Main(string[] args)
        {/*
            List<string> lst = new List<string>() { "rupesh", "akash", "Sam", "Darshan" };
            lst.Sort();
            lst.Reverse();
            foreach(string s in lst)
            {
                Console.WriteLine(s + " ");
            }*/


            List<int> l2 = new List<int> { 23, 44, 56, 77, 89, 90, 35 };
            List<int> oddlist = l2.FindAll(isOdd);
            foreach(int s in oddlist )
                Console.WriteLine(s + " ");

        }
    }
}
