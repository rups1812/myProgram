using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.Inheritance
{
    class Teacher
    {
        public void Teach()
        {
            Console.WriteLine("Teach");
        }
    }


    class Student:Teacher
    {
        public void Learn()
        {
            Console.WriteLine("Learn");
        }
    }

    class Single_Inheritance
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Learn();
            s.Teach();

        }

    }

    public class Parent
    {
        public void DisplayParentsAB()
        {
            Console.WriteLine("A and B are my parents");
        }
    }

    public class Son : Parent
    {
        public void DisplaySonC()
        {
            Console.WriteLine("I am the son C");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Son s = new Son();
            s.DisplaySonC();
            s.DisplayParentsAB();
        }
    }
}
