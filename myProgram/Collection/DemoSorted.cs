using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.Collection
{
    class DemoSorted
    {
        static void Main(string[] args)
        {
            SortedList<string, int> sl = new SortedList<string, int>();

            sl.Add("Rupesh", 90);
            sl.Add("Ajinkya", 90);
            sl.Add("Vijay", 90);
            sl.Add("Sanjay", 90);
            sl.Add("Tushar", 90);
            sl.Add("Nilesh", 90);


            sl.Remove("Vijay");

            sl["Tushar"] = 95;

            Console.WriteLine(sl.ContainsKey("RR"));

            Console.WriteLine(sl.Count);

            foreach(var s in sl)
            {
                Console.WriteLine(s);
            }
        }
    }



    class SBSort:IComparer<StringBuilder>
    {
        public int Compare(StringBuilder x, StringBuilder y)
        {
            return x.ToString().CompareTo(y.ToString());
        }
    }

    class Demoss
    {
        static void Main(string[] args)
        {
            SortedList<StringBuilder, int> ss = new SortedList<StringBuilder, int>(new SBSort());

            ss.Add(new StringBuilder("Amit"), 90);
            ss.Add(new StringBuilder("Amita"), 90);
            ss.Add(new StringBuilder("Adu"), 90);
            ss.Add(new StringBuilder("ciya"), 90);


            foreach(var v in ss)
                Console.WriteLine(v.Key+"==>"+v.Value);

        }
    }
}
