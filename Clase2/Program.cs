using System;
using System.Drawing;

namespace Vector1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int[] vector = new int[5];

            for (int f = 0; f < 5; f++)
            {
                Console.WriteLine("Por favor Ingrese un numeroen posicion " + (f + 1) + ": ");
                num = int.Parse(Console.ReadLine());
                vector[f] = num;
            }

            Console.WriteLine("\n");


            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine(vector[i]);
            }

        }
    }
}

