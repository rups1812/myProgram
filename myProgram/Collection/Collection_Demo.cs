using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.Collection
{
    //non generic
    class k
    {
        private object ob;
        public object Ob { get => ob; set => ob = value; }
    }

    //generic 
    class kk<T>
    {
        private T ob;
        public T Ob { get => ob; set => ob = value; }
    }


    class Collection_Demo
    {
        static void Main(string[] args)
        {
            kk<string> obj = new kk<string>();
            obj.Ob = "xyz";
            string s = obj.Ob;

            Console.WriteLine(s);



            k k = new k();
            k.Ob = "sima";
            k.Ob = 90;

            int m = (int)k.Ob;

            Console.WriteLine(m);
        }

    }
}
