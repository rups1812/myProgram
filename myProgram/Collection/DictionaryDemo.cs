using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.Collection
{
    class DictionaryDemo
    {

        static void Main(string[] args)
        {
            Dictionary<string, int> dd = new Dictionary<string, int>();

            dd.Add("Ajinkya", 90);
            dd.Add("Rupesh", 90);
            dd.Add("Jyoti", 91);


            dd["Ajinkya"] = 95;

            //dd.Remove("Rupesh");

            Console.WriteLine(dd.Count);

            //dd.Clear();

            Console.WriteLine(dd.ContainsKey("Om"));
            Console.WriteLine(dd.ContainsValue(90));

            List<string> keys = dd.Keys.ToList();

            Console.WriteLine(dd["Jyoti"]);

            foreach (KeyValuePair<string, int> kv in dd)
            {
                Console.WriteLine(kv.Key + "==>" + kv.Value);
            }
        }
    }

    class DemoHash
    {
        static void Main(string[] args)
        {
            /*Student s1 = new Student("Akash", 90, "BE");
            Student s2 = new Student("Akash", 90, "BE");

            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s2.GetHashCode());

            string str1 = new string("Ajinkya");
            string str2 = new string("Ajinkya");

            Console.WriteLine(str1.GetHashCode());
            Console.WriteLine(str2.GetHashCode());*/


/*
            Dictionary<Student, string> dd = new Dictionary<Student, string>();
            dd.Add(new Student("jyoti", 90, "BE"), "Java");
            dd.Add(new Student("jyoti", 90, "BE"), "Java");


            foreach(KeyValuePair<Student, string> kv in dd)
            {
                Console.WriteLine(kv.Key+" "+kv.Value);
            }*/

        }
    }
}
