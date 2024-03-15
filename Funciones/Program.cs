using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Crear una solucoin de software que instancie y cree el objeto triangulo. Este
//objeto tendra metodo constructor (Triangulo()) y metodo (Hallartipo()),
//adicional tendra los atributos l1, l2, l3 y tipo. donde tipo guardara de que tipo
//es el triangulo.

namespace ConsoleApp1
{
    //Obejto
    class Triangulo
    {
        public int lado1 { get; set; }
        public int lado2 { get; set; }
        public int lado3 { get; set; }
        public string tipo { get; set; }

        //Metodo Constructor
        public Triangulo(int l1, int l2, int l3)
        {
            lado1 = l1;
            lado2 = l2;
            lado3 = l3;
        }

        //Metodo Constructor
        public Triangulo(int[] _l)
        {
            lado1 = _l[0];
            lado2 = _l[1];
            lado3 = _l[2];
        }
        //Metodo Tipo
        public void HallarTipo()
        {
            if ((lado1 == lado2) && (lado2 == lado3))
            {
                tipo = "Isósceles";
            }
            else
            {
                if ((lado1 == lado2) || (lado1 == lado3) || (lado2 == lado3))
                {
                    tipo = "Equilátero";
                }
                else
                {
                    tipo = "Escaleno";
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //INGRESO MANUAL
            Triangulo t1 = new Triangulo(4, 5, 6);
            Triangulo t2 = new Triangulo(1, 2, 2);
            Triangulo t3 = new Triangulo(1, 1, 1);

            t1.HallarTipo();
            t2.HallarTipo();
            t3.HallarTipo();

            Console.WriteLine(t1.tipo);
            Console.WriteLine(t2.tipo);
            Console.WriteLine(t3.tipo);

            //INGRESO POR CONSOLA
            int l1 = 0, l2 = 0, l3 = 0;

            Console.Write("Digite lado1: ");
            l1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite lado2: ");
            l2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite lado3: ");
            l3 = Convert.ToInt32(Console.ReadLine());

            Triangulo t4 = new Triangulo(l1, l2, l3);

            t4.HallarTipo();
            Console.WriteLine(t4.tipo);

            //INGRESO POR ARREGLO
            int[] lados = new int[3];

            for (int i = 0; i < lados.Length; i++)
            {
                Console.Write("Digite lado" + (i + 1) + ": ");
                lados[i] = Convert.ToInt32(Console.ReadLine());
            }

            Triangulo t5 = new Triangulo(lados);

            t5.HallarTipo();
            Console.WriteLine(t5.tipo);

            Console.ReadKey();
        }
    }
}

/*
namespace ConsoleApp1
{
    //Obejto
    class Persona
    {
        //Atributos, Get=recibir valor, Set=Dar valor;
        public string user { get; set; }
        public string password { get; set; }
        
        //Metodo Constructor nombre igual al objeto
        public Persona(string u, string p)
        {
            user = u;
            password = p;
        }
        
        //Metodo Ordinario
        public void Validar()
        {

        }

        public void Saludar()
        {
            Console.WriteLine("Hola, soy " + user);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Instancio un objeto
            Persona p1 = null;

            //Constructor (construir persona p1)
            p1 = new Persona("Mario", "12346");
            p1.Saludar();

            Persona p2 = new Persona("Azly", "12347");
            p2.Saludar();

            p1.user = "luisana";
            p1.Saludar();

            Console.Write("Digite el nombre de P1: ");
            p1.user = Console.ReadLine();

            Console.Write("Digite el nombre de P2: ");
            p2.user = Console.ReadLine();

            p1.Saludar();
            p2.Saludar();

            Console.ReadKey();
        }
    }
}
*/
