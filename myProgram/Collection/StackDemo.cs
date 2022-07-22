using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.Collection
{
    class StackDemo
    {
        static void Main(string[] args)
        {
            Stack<int> st = new Stack<int>();

            st.Push(101);
            st.Push(201);
            st.Push(301);


            st.Pop();

            


            foreach(int elem in st)
            {
                Console.WriteLine(elem);
            }



        }
    }
}
