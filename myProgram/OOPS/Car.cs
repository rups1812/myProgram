using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.OOPS
{
    class Car
    {
        public int modelno;
        public string name;
        public string colour;
        public int price;

        
        static void Main(string[] args)
        {
            Car BMW;
            BMW = new Car();

            BMW.modelno = 101;
            BMW.name = "BMW";
            BMW.colour = "Blue";
            BMW.price = 6000000;


            Car Honda = new Car();

            Honda.modelno = 202;
            Honda.name = "HondaCity";
            Honda.colour = "Black";
            Honda.price = 1200000;


            Car Tata = new Car();

            Tata.modelno = 303;
            Tata.name = "TataNexon";
            Tata.colour = "Red";
            Tata.price = 1000000;


            Console.WriteLine(BMW.modelno+" "+BMW.name+" "+BMW.colour+" "+BMW.price);
            Console.WriteLine(Honda.modelno + " " + Honda.name + " " + Honda.colour+" "+Honda.price);
            Console.WriteLine(Tata.modelno + " " + Tata.name + " " + Tata.colour+" "+Tata.price);


        }

    }


    class student
    {
        public int id;
        public string name;
        public int m1, m2, m3;
        int per;

        public void AcceptDetails(int sid, string sname, int sub1, int sub2, int sub3)
        {
            id = sid;
            name = sname;
            m1 = sub1;
            m2 = sub2;
            m3 = sub3;

        }

        public void Calculate()
        {
            per = (m1 + m2 + m3) / 3;
        }

        public void Display()
        {
            Console.WriteLine(id+"  "+name+"  "+m1+"  "+m2+"  "+m3+"  "+per);
        }

        static void Main(string[] args)
        {
            student Rupesh;
            Rupesh = new student();

            Rupesh.AcceptDetails(1, "Rupesh", 85, 90, 95);
            Rupesh.Calculate();
            Rupesh.Display();

        }
    }

    class MethodDemo
    {
        //1. no return type no parameter

        public void show()
        {
            Console.WriteLine("show method");
        }

        //2. no return type with parameter

        public void Addition(int x, int y, double z)
        {
            Console.WriteLine("Addition= "+ (x+y+z));

        }

        //3. with return type no parameter

        public double Area()
        {
            double area = 3.14 * 4 * 4;
            return area;
        }



        //4. with return type with parameter

        public float Calculate(int x, float y)
        {
            float ans = x * y;
            return ans;
        }



        static void Main(string[] args)
        {
            MethodDemo d = new MethodDemo();
            d.show();
            d.Addition(4, 3, 5.3);


            Console.WriteLine("Area of circle= "+ d.Area());

            float result = d.Calculate(5, 4.5f); 
            Console.WriteLine(result);
        }


    }
}
