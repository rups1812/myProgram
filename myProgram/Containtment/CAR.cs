using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.Containtment
{
    //constuctor

    class Engine
    {
        public string type;

        public Engine(string type)
        {
            this.type = type;
        }

        public void show()
        {
            Console.WriteLine(type+" ");
        }
    }
    class CAR
    {
        int modelno;
        string name;
        float price;
        Engine eng;

        CAR(int modelno, string name, float price, Engine eng)
        {
            this.modelno = modelno;
            this.name = name;
            this.price = price;
            this.eng = eng;
        }

        void display()
        {
            Console.Write(modelno + " " + name + " " + price + " ");
            eng.show();
        }

        static void Main(string[] args)
        {
            CAR c = new CAR(789, "BMW", 5500000, new Engine("Petrol"));
            c.display();
        }
    }


}
