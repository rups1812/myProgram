using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.Array_demos
{
    class Char_Array
    {
        static void Main(string[] args)
        {
            char[] ch = new char[5];

            for(int i=0; i< ch.Length; i++)
            {
                ch[i] = char.Parse(Console.ReadLine());
            }

            for(int i=0; i< ch.Length; i++)
            {
                Console.WriteLine(ch[i]);
            }
        }
    }
}
