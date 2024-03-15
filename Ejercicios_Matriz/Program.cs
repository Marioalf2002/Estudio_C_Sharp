using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicios_Matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //PRIMER PUNTO
            int[,] matz = new int[3, 5];

            for (int i = 0; i < matz.GetLength(0); i++)
            {
                for (int j = 0; j < matz.GetLength(1); j++)
                {
                    Console.Write($"Ingrese numero {i},{j}: ");
                    matz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nMATRIZ");
            for (int i = 0; i < matz.GetLength(0); i++)
            {
                for (int j = 0; j < matz.GetLength(1); j++)
                {
                    Console.Write("\t" + matz[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            */
            
            //SEGUNDO PUNTO
            int[,] matz1 = new int[4, 4];

            for (int i = 0; i < matz1.GetLength(0); i++)
            {
                for (int j = 0; j < matz1.GetLength(1); j++)
                {
                    Console.Write($"Ingrese numero {i},{j}: ");
                    matz1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\nMATRIZ");
            for (int i = 0; i < matz1.GetLength(0); i++)
            {
                for (int j = 0; j < matz1.GetLength(1); j++)
                {
                    Console.Write("\t" + matz1[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nDIAGONAL PRINCIPAL");
            for (int i = 0; i < matz1.GetLength(0); i++)
            {
                for (int j = 0; j < matz1.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.Write("\t" + matz1[i, j]);
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nDIAGONAL SEGUNDARIA");
            int b = matz1.GetLength(1) - 1;
            for (int i = 0; i < matz1.GetLength(0); i++)
            {
                Console.WriteLine(matz1[i, b]);
                b--;
            }

            Console.ReadKey();
            
            /*
            //TERCER PUNTO
            int[,] matz2 = new int[3, 4];

            for (int i = 0; i < matz2.GetLength(0); i++)
            {
                for (int j = 0; j < matz2.GetLength(1); j++)
                {
                    Console.Write($"Ingrese numero {i},{j}: ");
                    matz2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nMATRIZ");
            for (int i = 0; i < matz2.GetLength(0); i++)
            {
                for (int j = 0; j < matz2.GetLength(1); j++)
                {
                    Console.Write("\t" + matz2[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nPrimer Fila");
            for (int i = 0; i <=0 ; i++)
            {
                for (int j = 0; j < matz2.GetLength(1); j++)
                {
                    Console.Write("\t" + matz2[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nUltima Fila");
            for (int i = 2; i <= 2; i++)
            {
                for (int j = 0; j < matz2.GetLength(1); j++)
                {
                    Console.Write("\t" + matz2[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nPrimer Columna");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j <= 0; j++)
                {
                    Console.Write("\t" + matz2[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
            */

            /*
            //CUARTO PUNTO
            int f = 0, c = 0;

            Console.Write("Tamaño de Filas: ");
            f = int.Parse(Console.ReadLine());
            Console.Write("Tamaño de Columnas: ");
            c = int.Parse(Console.ReadLine());

            int[,] matz4 = new int[f, c];

            for (int i = 0; i < matz4.GetLength(0); i++)
            {
                for (int j = 0; j < matz4.GetLength(1); j++)
                {
                    Console.Write($"Ingrese numero {i},{j}: ");
                    matz4[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nMATRIZ");
            for (int i = 0; i < matz4.GetLength(0); i++)
            {
                for (int j = 0; j < matz4.GetLength(1); j++)
                {
                    Console.Write("\t" + matz4[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nUltima Fila");
            for (int i = (f-1); i <= (f-1); i++)
            {
                for (int j = 0; j < matz4.GetLength(1); j++)
                {
                    Console.Write("\t" + matz4[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
           */
            /*
            int f = 0, c = 0;

            Console.Write("Tamaño Filas: ");
            f = int.Parse(Console.ReadLine());

            Console.Write("Tamaño Columnas: ");
            c = int.Parse(Console.ReadLine());

            int[,] matz1 = new int[f, c];
            int[,] matz2 = new int[f, c];
            int[,] matz3 = new int[f, c];

            Console.WriteLine("MATRIZ #1");
            for (int i = 0; i < matz1.GetLength(0); i++)
            {
                for (int j = 0; j < matz1.GetLength(1); j++)
                {
                    Console.Write($"Ingrese numero {i},{j}: ");
                    matz1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();
            for (int i = 0; i < matz1.GetLength(0); i++)
            {
                for (int j = 0; j < matz1.GetLength(1); j++)
                {
                    Console.Write("\t" + matz1[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nMATRIZ #2");
            for (int i = 0; i < matz2.GetLength(0); i++)
            {
                for (int j = 0; j < matz2.GetLength(1); j++)
                {
                    Console.Write($"Ingrese numero {i},{j}: ");
                    matz2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
            for (int i = 0; i < matz2.GetLength(0); i++)
            {
                for (int j = 0; j < matz2.GetLength(1); j++)
                {
                    Console.Write("\t" + matz2[i, j]);
                }
                Console.WriteLine();
            }

            for (int i = 0; i < matz3.GetLength(0); i++)
            {
                for (int j = 0; j < matz3.GetLength(1); j++)
                {
                    matz3[i, j] = matz1[i, j] + matz2[i, j];
                }
            }

            Console.WriteLine("\nMATRIZ #3");
            for (int i = 0; i < matz3.GetLength(0); i++)
            {
                for (int j = 0; j < matz3.GetLength(1); j++)
                {
                    Console.Write("\t" + matz3[i, j]);
                }
                Console.WriteLine();
            }
            */
            Console.ReadKey();
        }
    }
}
