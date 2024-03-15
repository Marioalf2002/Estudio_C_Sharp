using System;

namespace matrices
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*
             int[,] vec = new int[3,5];

            for (int i = 0; i < vec.GetLength(0); i++)
            {
                for (int j = 0; j < vec.GetLength(1); j++)
                {
                    Console.Write($"Ingrese un numero en posicion {i},{j}: ");
                    vec[i,j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < vec.GetLength(0); i++)
            {
                for (int j = 0; j < vec.GetLength(1); j++)
                {
                    Console.WriteLine("Numero " + vec[i, j] + " en Posicion " + i + j);
                }
            }

            for (int i = 0; i < vec.GetLength(0); i++)
            {
                for (int j = 0; j < vec.GetLength(1); j++)
                {
                    Console.WriteLine(vec[i, j] + " ");
                }
                Console.WriteLine();
            }
             */

            //PRIMERA FORMA
            /*
            //se crea la matriz de 3x4 de tipo entero
            int[,] matriz = new int[3, 4];
            // se llena la matriz

            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.Write($"Ingrese el valor de posicion {f} {c}: ");
                    string linea = Console.ReadLine();
                    //se utiliza el int.parse, para convertir el valor leído
                    matriz[f, c] = int.Parse(linea);
                }
            }
            //mostrar la información que se guarda en la matriz
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.WriteLine($"La posicion {f},{c} tiene el valor[{matriz[f, c]}], ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            */

            //SEGUNDA FORMA
            
            int[,] matriz = new int[3, 4];
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.Write($"Ingrese el valor de posicion {f} {c}:");
                    matriz[f, c] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\n" + "MATRIZ COMPLETA");
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.Write("\t" + matriz[f, c]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

