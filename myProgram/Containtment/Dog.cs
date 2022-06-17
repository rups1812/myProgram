using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.Containtment
{
    class Dog
    {
        string breed;

        public void bark()
        {
            Console.WriteLine("Bark Bark !!");

        }

        static void Main(string[] args)
        {
         
            Dog bullDog = new Dog();
            bullDog.breed = "Bull Dog";
            Console.WriteLine(bullDog.breed);
            bullDog.bark();

            Console.ReadLine();
        }
    }


    //class Dog
    //{
    //    string breed;

    //    public void bark()
    //    {
    //        Console.WriteLine("Bark Bark !!");

    //    }

    //    static void Main(string[] args)
    //    {

    //        Dog bullDog = new Dog();
    //        bullDog.breed = "Bull Dog";
    //        Console.WriteLine(bullDog.breed);
    //        bullDog.bark();

    //        Console.ReadLine();
    //    }
    //}


    //class Dog
    //{
    //    string breed;

    //    public void bark()
    //    {
    //        Console.WriteLine("Bark Bark !!");

    //    }

    //    static void Main(string[] args)
    //    {

    //        Dog bullDog = new Dog();
    //        bullDog.breed = "Bull Dog";
    //        Console.WriteLine(bullDog.breed);
    //        bullDog.bark();

    //        Console.ReadLine();
    //    }
    //}
}
