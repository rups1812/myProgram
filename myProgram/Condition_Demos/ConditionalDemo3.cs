using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.Condition_Demos
{
	class ConditionalDemo3
	{
		public static void Main(string[] args)
		{
			/*int x, y, z;
			Console.Write("Enter first number:");
			x = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter second number:");-
			y = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter third number:");
			z = Convert.ToInt32(Console.ReadLine());

			if (x > y)
			{
				if (x > z)
				{
					Console.WriteLine("Greatest is:" + x);
				}
				else
				{
					Console.WriteLine("Greatest is:" + z);
				}
			}
			else
			{
				if (y > z)
				{
					Console.WriteLine("Greatest is:" + y);
				}
				else
				{
					Console.WriteLine("Greatest is:" + z);
				}


			}*/


			int a;
			int b;
			int c;
			int large;

			
			Console.Write("Enter first number : ");
			a = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter second number: ");
			b = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter third number : ");
			c = Convert.ToInt32(Console.ReadLine());

			if (a > b && a > c)
			{
				large = a;
			}
			else if (b > a && b > c)
			{
				large = b;
			}
			else
			{ large = c; }

			Console.WriteLine("Largest number is {0}", large);



		}
	}
}
