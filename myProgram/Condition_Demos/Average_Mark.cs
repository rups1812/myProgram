using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.Condition_Demos
{
    class Average_Mark
    {
        static void Main(string[] args)
        {

            int r, marks1, marks2, marks3, marks4, marks5, total;
            float percentage;
            string n;

            Console.WriteLine("Enter Student Roll Number :");
            r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student Name :");
            n = Console.ReadLine();

            Console.WriteLine("Enter Subject-1 Marks : ");
            marks1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Subject-2 Marks : ");
            marks2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Subject-3 Marks :");
            marks3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Subject-4 Marks :");
            marks4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Subject-5 Marks :");
            marks5 = Convert.ToInt32(Console.ReadLine());


            total = marks1 + marks2 + marks3 + marks4 + marks5;


            percentage = total / 5.0f;


            Console.WriteLine("Final result of {0} is:", n);
            Console.WriteLine("Total Marks : " + total);
            Console.WriteLine("Percentage : " + percentage);


        }
    }
}
