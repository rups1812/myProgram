using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.Containtment
{

    class Engine_properties
    {
        string type;

        public string Type
        {
            get { return type; }
            set { type = value; }

        }
    }
    class Car_properties
    {
        int modelno;
        string name;
        float price;
        Engine_properties eng;


        public int Modelno
        {
            get { return modelno; }
            set { modelno = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        public Engine_properties Eng
        {
            get { return eng; }
            set { eng = value; }
        }


        static void Main(string[] args)
        {
            Car_properties c = new Car_properties();
            c.Modelno = 789;
            c.Name = "TATA";
            c.Price = 1500000;
            c.Eng = new Engine_properties();

            c.Eng.Type = "Disel";

            Console.WriteLine(c.Modelno+" "+c.Name+" "+c.Price+" "+c.Eng.Type);
        }
    }
}
