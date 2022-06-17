using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.Basic
{
    class Airthmetic_operator
    {
        public static void Main(string[] agrs)

        {
			double firstNumber = 24.40, secondNumber = 8.60, result;
			int num1 = 36, num2 = 5, rem;

			// Addition operator
			result = firstNumber + secondNumber;
			Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, result);

			// Subtraction operator
			result = firstNumber - secondNumber;
			Console.WriteLine("{0} - {1} = {2}", firstNumber, secondNumber, result);

			// Multiplication operator
			result = firstNumber * secondNumber;
			Console.WriteLine("{0} * {1} = {2}", firstNumber, secondNumber, result);

			// Division operator
			result = firstNumber / secondNumber;
			Console.WriteLine("{0} / {1} = {2}", firstNumber, secondNumber, result);

			// Modulo operator
			rem = num1 % num2;
			Console.WriteLine("{0} % {1} = {2}", num1, num2, rem);

		}
    }
}
