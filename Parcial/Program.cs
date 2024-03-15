using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0, l = 0, suma = 0;
            
            do
            {
                Console.Write("Ingrese un número entero de dos cifras: ");
                numero = int.Parse(Console.ReadLine());
            } while ((numero < 9) || (numero > 99));
            
            string revez = numero.ToString();

            while (revez != new string(revez.Reverse().ToArray()))
            {
                suma = int.Parse(revez) + int.Parse(new string(revez.Reverse().ToArray()));

                Console.WriteLine($"{revez} + {new string(revez.Reverse().ToArray())} = {suma}");

                revez = suma.ToString();

                l++;
            }

            Console.WriteLine($"Número Capicúa es {revez}");
            Console.WriteLine($"Interacciones: {l}");
            Console.ReadKey();
        }
    }
}
