using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.Prorigo
{
    class AP
    {
        public static int AithmaticProgression(int a2, int a3,int n)
        {
            int diff = a3 - a2;
            for (int i = 3; i < n; i++)
            {
                a3 = a3 + diff;
            }
            return a3;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter a 1st number");     //input1=1
            int a2 = Convert.ToInt32(Console.ReadLine());//input=2
            Console.WriteLine("enter a 2nd number");    //input=4
            int a3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter nth number");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(AP.AithmaticProgression(a2,a3,n));
        }
    }
}
