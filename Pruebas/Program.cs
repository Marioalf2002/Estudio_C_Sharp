using System;

/*
class Program
{
    static void Main()
    {
        Console.Write("Ingrese la cantidad de filas de la matriz: ");
        int k = int.Parse(Console.ReadLine());
        Console.Write("Ingrese la cantidad de columnas de la matriz: ");
        int p = int.Parse(Console.ReadLine());

        int[,] matriz = new int[k, p];

        for (int i = 0; i < k; i++)
        {
            for (int j = 0; j < p; j++)
            {
                Console.Write("Ingrese el valor para la posición [{0},{1}]: ", i, j);
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\nMatriz:");
        for (int i = 0; i < k; i++)
        {
            for (int j = 0; j < p; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }

        int pares = 0;
        int impares = 0;
        bool tieneNegativos = false;

        for (int i = 0; i < k; i++)
        {
            for (int j = 0; j < p; j++)
            {
                if (matriz[i, j] % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }

                if (matriz[i, j] < 0)
                {
                    tieneNegativos = true;
                    Console.WriteLine("El número {0} está en la posición [{1},{2}]", matriz[i, j], i, j);
                }
            }
        }

        Console.WriteLine("\nCantidad de números pares: {0}", pares);
        Console.WriteLine("Cantidad de números impares: {0}", impares);
        if (!tieneNegativos)
        {
            Console.WriteLine("La matriz no tiene números negativos.");
        }
    }
}
*/
/*
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int mayor = 0, m = 7;
            int[] vnum = new int[m];

            for (int j = 0; j < vnum.Length; j++)
            {
                Console.WriteLine("Ingrese un numero en posicion " + j + ": ");
                vnum[j] = int.Parse(Console.ReadLine());
      
            }
            Console.WriteLine("\n");
            for (int j = 0; j < vnum.Length; j++)
            {
                Console.WriteLine(vnum[j]);
            }
            Console.WriteLine("\n");
            for (int i = 0; i < vnum.Length; i++)
            {
                if (vnum[i]>mayor)
                {
                    mayor = vnum[i];
                }
            }

            Console.WriteLine("el mayor es " + mayor);

        }
    }
}
*/
/*
int c = 0, mayor = 0;

Console.WriteLine("Cuantos empleados desea ingresar: ");
c = int.Parse(Console.ReadLine());

string[] empleados = new string[c];
int[] salarios = new int[c];

for (int i = 0; i < empleados.Length; i++)
{
    Console.WriteLine("\n" + (i + 1) + ". Nombre Empleado: ");
    empleados[i] = Console.ReadLine();
    Console.WriteLine("Salario: ");
    salarios[i] = int.Parse(Console.ReadLine());
}

mayor = salarios[0];

for (int i = 0; i < salarios.Length; i++)
{
    if (mayor < salarios[i])
    {
        mayor = salarios[i];
    }
}

Console.WriteLine("\nSALARIO MAYOR:");

for (int i = 0; i < salarios.Length; i++)
{
    if (mayor == salarios[i])
    {
        Console.WriteLine("\nEmpleado: " + empleados[i]);
        Console.WriteLine("Salario: " + salarios[i]);
    }
}

Console.WriteLine("\nLISTA EMPLEADOS:");

for (int i = 0; i < empleados.Length; i++)
{
    Console.WriteLine("\nNombre: " + empleados[i]);
    Console.WriteLine("Salario: " + salarios[i]);
}
*/
/*
Console.WriteLine("Bienvenido Señor@ Usuario");
Console.WriteLine("Por favor ingrese la cantidad de empleados");
int emp;
emp = int.Parse(Console.ReadLine());
Console.WriteLine("");

string[] vec = new string[emp];
int[] vec2 = new int[emp];

int mayor = 0;
int money = 0, j = 1, i = 0;
string nombre;

for (i = 0; i < emp; i++)
{
    Console.WriteLine("Ingrese el nombre del empleado #" + j++);
    nombre = Console.ReadLine();
    vec[i] = nombre;

    Console.WriteLine("Ingrese el salario del empleado " + nombre + ":");
    money = int.Parse(Console.ReadLine());
    vec2[i] = money;
    Console.WriteLine("");
}

for (i = 0; i < emp; i++)
{
    if (vec2[i] > mayor)
    {
        mayor = vec2[i];
    }

    Console.WriteLine("El empleado " + vec[i] + " tiene un salario de: " + vec2[i]);
    Console.WriteLine("");
}

for (i = 0; i < emp; i++)
{
    if (vec2[i] == mayor)
    {
        Console.WriteLine("El salario mayor lo tiene: " + vec[i] + ": " + mayor);
    }
}
*/

using System;

namespace taller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cant = 0;
            double suma_1 = 0, suma_t = 0, suma_p = 0;


            Console.WriteLine("ingrese la cantidad de numeros: ");
            cant = int.Parse(Console.ReadLine());

            double[] num = new double[cant];

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine($"Ingrese el numero " + i);
                num[i] = double.Parse(Console.ReadLine());
            }

            for (int j = 0; j < num.Length; j++)
            {
                if (num[j] % 5 == 0)
                {
                    Console.WriteLine($"El numero {num[j]} es multiplo de 5");
                }
                else
                {
                    suma_1 = suma_1 + num[j];
                }

                if (num[j] >= 0)
                {
                    suma_p = suma_p + 1;
                }
                suma_t = suma_t + num[j];
            }

            Console.WriteLine($"La suma de los numeros que no son multiplos de 5 es: {suma_1}");
            Console.WriteLine($"El promedio de todos los numeros es: {suma_t / cant}");
            Console.WriteLine($"El porcentaje de los positivos es: {(suma_p * 100) / cant}");
        }
    }
}