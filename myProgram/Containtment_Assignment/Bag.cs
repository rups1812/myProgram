using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.Containtment_Assignment
{

    class Nib
    {
        string type;


        public string Type
        {
            get { return type; }
            set { type = value; }
        }
    }
    class Pen
    {
        string penname;
        string pencolour;
        Nib n;


        public string Penname
        {
            get { return penname; }
            set { penname = value; }
        }

        public string Pencolour
        {
            get { return pencolour; }
            set { penname = value; }
        }

        public Nib N
        {
            get { return n; }
            set { n = value; }
        }
    }
    class Bag
    {
        string brand;
        string colour;
        int price;
        Pen p;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public Pen P
        {
            get { return p; }
            set { p = value; }
        }

        static void Main(string[] args)
        {
            Bag b = new Bag();
            b.Brand = "Safari";
            b.Colour = "Black";
            b.Price = 2000;
            b.P = new Pen();
            b.P.Penname = "Montex";
            b.P.Pencolour = "Blue";
            b.P.N = new Nib();
            b.P.N.Type = "Metals";

            Console.WriteLine(b.Brand+" "+b.Colour+" "+b.Price+" "+b.P.Penname+" "+b.P.Pencolour+" "+b.P.N.Type+" ");

        }
    }
}
