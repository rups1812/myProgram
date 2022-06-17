using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.Method_Overriding
{

    class Animal
    {
        public string colour = "white";
    }

    class Cat:Animal
    {
        string colour = "black";
        public void showColor()
        {
            Console.WriteLine(colour+" "+base.colour);
        }

    }
    class Base_keyword
    {
        static void Main(string[] args)
        {
            Cat c = new Cat();
            c.showColor();
        }
    }




    class Loans
    {
        public virtual void type()
        {
            Console.WriteLine("Bank loans");
        }
    }

    class Home_loan:Loans
    {
        public override void type()
        {
            Console.WriteLine("The interest rate of home laon is 14%");
        }
    }

    class Gold_loan:Loans
    {
        public override void type()
        {
            Console.WriteLine("The interest rate of gold is 9%");
        }
    }

    class MethodOverriding
    {
        static void Main(string[] args)
        {
            Loans l = new Gold_loan();
            l.type();
            l = new Home_loan();
            l.type();
        }
    }


}
