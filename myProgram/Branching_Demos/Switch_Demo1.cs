using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.Branching_Demos
{
    class Switch_Demo1
    {
        static void Main(string[] args)
        {



            /* Console.Write("Enter any number to check even or odd: ");
             int num = Convert.ToInt32(Console.ReadLine());

             switch (num % 2)
             {

                 case 1:
                     Console.WriteLine(num + " is even number");
                     break;


                 case 2:
                     Console.WriteLine(num + " is odd number");
                     break;*/

            /* Console.WriteLine("Input day no");
             int dayno = Convert.ToInt32(Console.ReadLine());

             switch(dayno)
             {
                 case 1:
                     Console.WriteLine("monday");
                     break;


                 case 2:
                     Console.WriteLine("tuesday");
                     break;

                 case 3:
                     Console.WriteLine("wednesday");
                     break;

                 case 4:
                     Console.WriteLine("thursday");
                     break;

                 case 5:
                     Console.WriteLine("friday");
                     break;

                 case 6:
                     Console.WriteLine("saturday");
                     break;

                 case 7:
                     Console.WriteLine("sunday");
                     break;

                 default:
                     Console.WriteLine("Invalid day no");
                     break;*/


            float result = 0;
            
            Console.WriteLine("Enter first number");
            float num1 = float.Parse(Console.ReadLine());

            
            Console.WriteLine("Enter second number");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter operator");
            string op = Console.ReadLine();

            switch (op)
            {

                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                case "%":
                    result = num1 % num2;
                    break;

            }
            Console.WriteLine("Result = " + result);


        }

    
    }
}
