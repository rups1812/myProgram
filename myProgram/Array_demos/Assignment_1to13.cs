using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.Array_demos
{
    class Assignment_1to13
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int i, evennum, oddnum;

            Console.WriteLine("Enter  the array: ");
            

            for (i = 0; i <arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            evennum = 0; 
            oddnum = 0; 

            for (i = 0; i <arr.Length; i++)
            {
                
                if (arr[i] % 2 == 0)
                {
                    evennum++;
                }
                else
                {
                    oddnum++; 
                }
            }

            Console.WriteLine("Total even  numbers: " + evennum);
            Console.WriteLine("Total odd numbers: " + oddnum);


            Console.ReadLine();
        }

    
    }

    class Test
    {
        static int mcCartyCounter = 100;
        public static int mcCarthy(int n)
        {
            mcCartyCounter++;
            if (n > 100)
                return n - 10;
            else
                return mcCarthy(n + 11);
        }
        public static void Main(String[] args)
        {
            Console.WriteLine(mcCarthy(100) + "  " + mcCartyCounter);
        }

    }

    class Minimum_frequency
    {
        static void Main(string[] args)
        {
            char[] c = { 'a', 'b', 'b', 'c', 'c', 'b' };
            char min = c[0];
            int x = 0;

            for(int i=0; i<c.Length; i++)
            {
                x = c[i];
                if(c[i]<min)
                {
                    min = c[i];

                }

            }
            Console.WriteLine(min);

        }
    }


    class Nib
    {
        string materialtype;
        int width;


        public string Materialtype
        {
            get { return materialtype; }
            set { materialtype = value; }
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

    }
    class Refil
    {
        string inkcolor;
        int length;
        int tip;
        Nib n;


        public string Inkcolor
        {
            get { return inkcolor; }
            set { inkcolor = value; }
        }

        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        public Nib N
        {
            get { return n; }
            set { n = value; }
        }
    }
    class Pen
    {
        string brand;
        int caplength;
        Refil r;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public int Caplength
        {
            get { return caplength; }
            set { caplength = value; }
        }

        public Refil R
        {
            get { return r; }
            set { r = value; }
        }

        static void Main(string[] args)
        {
            Pen p = new Pen();
            p.Brand = "Parker";
            p.Caplength = 3;
            p.R = new Refil();
            p.R.Inkcolor = "Blue";
            p.R.Length = 14;
            p.R.N = new Nib();
            p.R.N.Materialtype = "Metal";
            p.R.N.Width = 1;

            Console.WriteLine(p.Brand+" "+p.Caplength+" " + p.R.Inkcolor+" "+p.R.Length+" "+p.R.N.Materialtype+" "+p.R.N.Width);
        }
    }

    class Seperate_zero
    { 
        static void pushZerosToEnd(int[] arr, int n)
        {
         
            int count = 0;
            for (int i = 0; i < n; i++)
                if (arr[i] != 0)

                    arr[count++] = arr[i];

            while (count < n)
                arr[count++] = 0;
        }
        public static void Main()
        {
            int[] arr = { 12, 0, 7, 0, 8, 0, 3 };
            int n = arr.Length;
            pushZerosToEnd(arr, n);
            Console.WriteLine("Array after pushing all zeros to the back: ");
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
        }
    }


    class Dupliate_array
    {
        static void Main(string[] args)
        {
            int i = 0, j = 0;
            int[] arr1 = new int[] { 4, 3, 2, 4, 9, 2 };
            for (i = 0; i < arr1.Length; i++)
            {
                for (j = 0; j < arr1.Length; j++)
                {
                    if (i == j)
                        continue;
                    if (arr1[j] == arr1[i])
                        break;
                }
                if (arr1.Length == j)
                {
                    Console.Write(arr1[i] + " ");
                }
            }
        }
        
    }



    class Gear
    {
        string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
    }


    class SubEngine
    {
        string cleanupDate;
        Gear ge;

        public string CleanupDate
        {
            get { return cleanupDate; }
            set { cleanupDate = value; }
        }

        public Gear Ge
        {
            get { return ge; }
            set { ge = value; }
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
            c.E.Sub.Ge = new Gear();
            c.E.Sub.Ge.Type = "Manual";

            Console.WriteLine(c.Model + " " + c.Name + " " + c.Price + " " + c.E.Type + " " + c.E.Sub.CleanupDate + " "+" "+c.E.Sub.Ge.Type);
        }
    }

    class Buzzfizz
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 50; i++)
            {
                if (i % 3 == 0 & i % 5 == 0)
                {
                    Console.Write("fizzbuzz" + ",");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("fizz" + ",");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("buzz" + ",");
                }
                else
                {
                    i = i + 0;
                }

                Console.Write(i + ",");
            }

        }
    }

}
