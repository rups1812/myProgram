using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.Containtment_Assignment
{

    class SubEngine
    {
        string cleanupDate;


        public string CleanupDate
        {
            get { return cleanupDate; }
            set { cleanupDate = value; }
        }

    }

    class Engine
    {
        string type;
        SubEngine sub;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public SubEngine Sub
        {
            get { return sub; }
            set { sub = value; }
        }
    }
    class Car
    {
        int model;
        string name;
        int price;
        Engine e;


        public int Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public Engine E
        {
            get { return e; }
            set { e = value; }
        }

        static void Main(string[] args)
        {
            Car c = new Car();
            c.Model = 856;
            c.Name = "BMW";
            c.Price = 4500000;
            c.E = new Engine();
            c.E.Type = "Petrol";
            c.E.Sub = new SubEngine();
            c.E.Sub.CleanupDate = "18/12/2050";

            Console.WriteLine(c.Model+" "+c.Name+" "+c.Price+" "+c.E.Type+" "+c.E.Sub.CleanupDate+" ");
        }
    }


}
