
using System;
using System.Drawing;

namespace Vector1
{
    class Program
    {
        static void Main(string[] args)
        {
            //========================INGRESAR/IMPRIMIR EDADES==========================//
            /*Se desea guardar la edad de 5 estudiantes y mostrar las edades ingresadas*/
            /*
            String[] estudiantes = new string[5];
            
            for (int f = 0; f < estudiantes.Length; f++)
            {
                Console.WriteLine("Por favor Ingrese la Edad del estudiante " + (f + 1) + ": ");
                string nombre;
                nombre = Console.ReadLine();
                estudiantes[f] = nombre;
            }
            
            Console.WriteLine("\n");

            for (int i = 0; i < estudiantes.Length; i++)
            {
                Console.WriteLine("Edad del estudiante " + i + " es: " + estudiantes[i]);
            }
            */
            //====================PROMEDIO ALTURRA=================//
            /*Se desea saber la altura de 5 personas y el promedio de la altura.*/
            /*
            float[] alturas = new float[5];
            float prom = 0;

            for (int f = 0; f < alturas.Length; f++)
            {
                Console.WriteLine("Por favor Ingrese la Altura del estudiante " + (f + 1) + ": ");
                float altura;
                altura = float.Parse(Console.ReadLine());
                alturas[f] = altura;

                prom = prom + alturas[f];
            }

            prom = prom / 5;
            
            Console.WriteLine("el promedio de las alturas es "+prom);
            */
            //====================VALORES=================//
            /*
             * Desarrollar un programa que permita ingresar un vector de 8 elementos, e informe: 
             * El valor acumulado de todos los elementos.
             * El valor acumulado de los elementos del vector que sean mayores a 10.
             * Cantidad de valores mayores a 20.
             */
            /*
            int[] elementos = new int[8];
            int valor = 0, suma = 0, mayores = 0, c = 0;

            for (int f = 0; f < elementos.Length; f++)
            {
                Console.WriteLine("Ingrese Valor posicion: " + (f + 1) + ": ");
                valor = int.Parse(Console.ReadLine());
                elementos[f] = valor;
                suma = suma + elementos[f];

                if (elementos[f]>10)
                {
                    mayores = mayores + elementos[f];
                }
                if (elementos[f] > 20)
                {
                    c = c + 1;
                }
            }
            
            Console.WriteLine("Suma de todos los Valores: " + suma + "\n");
            Console.WriteLine("Suma de todos los Valores mayores a 10: " + mayores + "\n");
            Console.WriteLine("Cantidad de numeros mayores a 20: " + c + "\n");
            */
            //====================VECTOR DINAMICO=================//
            /*
             *  Realizar el ejercicio 1 de forma dinámica, es decir, 
             *  puede cambiar el tamaño del vector, 
             *  ingresando el tamaño desde el teclado.
             */
            
            int tamaño = 0;

            Console.WriteLine("Cuantas Edades desea ingresar: ");
            tamaño = int.Parse(Console.ReadLine());
            
            String[] estudiantes = new string[tamaño];

            for (int f = 0; f < estudiantes.Length; f++)
            {
                Console.WriteLine("Por favor Ingrese la Edad del estudiante " + (f + 1) + ": ");
                string nombre;
                nombre = Console.ReadLine();
                estudiantes[f] = nombre;
            }

            Console.WriteLine("\n");

            for (int i = 0; i < estudiantes.Length; i++)
            {
                Console.WriteLine(estudiantes[i]);
            }
            
        }
    }
}
