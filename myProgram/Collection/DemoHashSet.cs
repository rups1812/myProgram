using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.Collection
{
    class DemoHashSet
    {
        static void Main(string[] args)
        {
            HashSet<string> hs = new HashSet<string>();

            hs.Add("Amit");
            hs.Add("Amita");
            hs.Add("Amay");
            hs.Add("Amit");

            foreach(string s in hs)
                Console.WriteLine(s);

        }
    }

    class DemoHashSet2
    {
        static void Main(string[] args)
        {
            HashSet<string> hs1 = new HashSet<string>() { "A", "BB", "CC", "ZZ" };
            HashSet<string> hs2 = new HashSet<string>() { "DD", "BB", "CC", "EE", "FF" };

            hs1.Intersect(hs2);
            /* hs2.UnionWith(hs1);*/

            Console.WriteLine(hs2.IsProperSubsetOf(hs1));
            foreach(string s in hs1)
                Console.WriteLine(s);

            Console.WriteLine("*****************");
            foreach(string s in hs2)
                Console.WriteLine(s);






        }
    }

    class DemoSortedSet
    {
        static void Main(string[] args)
        {
            SortedSet<string> ss = new SortedSet<string>();

            ss.Add("Rajesh");
            ss.Add("Vedant");
            ss.Add("Darshan");
            ss.Add("Ajinkya");
            ss.Add("Sanket");

            ss.Remove("Sanket");

            Console.WriteLine(ss.Contains("Vedant"));

            foreach(string s in ss)
                Console.WriteLine(s);
        }
    }
}
