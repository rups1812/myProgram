using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.TwoDarray
{
    class Average_array
    {
            static void Main(string[] args)
            {
                int[,] a = { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    int sum = 0;
                    float average = 0.07f;
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        sum = sum + a[i, j];
                        Console.Write(a[i, j] + " ");
                    }
                    average = (float)sum / a.GetLength(1);
                    Console.Write("average= " + average);
                    Console.WriteLine();
                }
            }
        }


        class Sum_coloumn
        {
            static void Main(string[] args)
            {
                int[,] a = { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    int sum = 0;

                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        sum = sum + a[i, j];
                        Console.Write(a[j, i] + " ");
                    }

                    Console.Write("sum= " + sum);
                    Console.WriteLine();
                }
            }
        }

        class Addition_twomatrix
        {
            static void Main(string[] args)
            {
                int i, j, n;
                int[,] arr1 = new int[20, 20];
                int[,] arr2 = new int[20, 20];
                int[,] arr3 = new int[20, 20];
               
                n = 3;
                Console.Write("Enter elements in the first matrix:\n");
                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.Write("Enter elements in the second matrix:\n");
                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.Write("\nFirst matrix is:\n");
                for (i = 0; i < n; i++)
                {
                    Console.Write("\n");
                    for (j = 0; j < n; j++)
                        Console.Write("{0}\t", arr1[i, j]);
                }
                Console.Write("\nSecond matrix is:\n");
                for (i = 0; i < n; i++)
                {
                    Console.Write("\n");
                    for (j = 0; j < n; j++)
                        Console.Write("{0}\t", arr2[i, j]);
                }
                for (i = 0; i < n; i++)
                    for (j = 0; j < n; j++)
                        arr3[i, j] = arr1[i, j] + arr2[i, j];
                Console.Write("\nAdding two matrices: \n");
                for (i = 0; i < n; i++)
                {
                    Console.Write("\n");
                    for (j = 0; j < n; j++)
                        Console.Write("{0}\t", arr3[i, j]);
                }
            }
        }

    

}
