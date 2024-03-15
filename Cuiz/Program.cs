using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp1
{
    public class empleado
    {
        public string nombre { get; set; }
        public int sueldo { get; set; }
        public empleado(string nm, int sl)
        {
            nombre = nm;
            sueldo = sl;
        }

        public void inicio_empleados()
        {
            int op = 0;
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("1. Cargar Informacion.");
            Console.WriteLine("2. Mostrar Informacion.");
            Console.WriteLine("3. Impuestos.");
            Console.WriteLine("0. salir.");
            Console.Write("Opcion: ");
            op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    informacion();
                    break;
                case 2:
                    mostrar_informacion(nombre, sueldo);
                    break;
                case 3:
                    impuestos(sueldo);
                    break;
                case 0:
                    Console.WriteLine("-------------------------------------------------------------");
                    Console.WriteLine("Ha salido del Programa IMPUESTOS.");
                    Console.WriteLine("-------------------------------------------------------------");
                    break;
                default:
                    Console.WriteLine("-------------------------------------------------------------");
                    Console.WriteLine("Opcion Invalida.");
                    Console.WriteLine("-------------------------------------------------------------");
                    break;
            }
        }

        public void informacion()
        {
            string nem = "";
            int sul = 0;
            Console.WriteLine("-------------------------------------------------------------");
            Console.Write("Ingrese Nombre: ");
            nem = Console.ReadLine();
            Console.Write("Ingrese Sueldo: $");
            sul = int.Parse(Console.ReadLine());

            empleado p1 = new empleado(nem, sul);
            p1.inicio_empleados();
        }

        public void mostrar_informacion(string n, int s)
        {
            string nom = n;
            int sel = s;

            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Nombre: " + nom);
            Console.WriteLine("Sueldo: $" + sel);
            inicio_empleados();
        }

        public void impuestos(int s)
        {
            int sel = s;

            Console.WriteLine("-------------------------------------------------------------");
            if (sel>52000000)
            {
                Console.WriteLine("Debe Pagar Impuestos ya que su sueldo supera los $52.000.000.");
            }
            else
            {
                Console.WriteLine("No Debe Pagar Impuestos.");
            }
            inicio_empleados();
        }
    }

    public class operaciones
    {
        public float n1 { get; set; }
        public float n2 { get; set; }

        public operaciones(float num1, float num2)
        {
            n1 = num1;
            n2 = num2;
        }

        public void inicio_operaciones()
        {
            int op = 0;

            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("1. Ingresar Numeros.");
            Console.WriteLine("2. Suma.");
            Console.WriteLine("3. Resta.");
            Console.WriteLine("4. Multiplicacion.");
            Console.WriteLine("5. Division.");
            Console.WriteLine("0. salir.");
            Console.Write("Opcion: ");
            op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    numeros();
                    break;
                case 2:
                    suma(n1, n2);
                    break;
                case 3:
                    resta(n1, n2);
                    break;
                case 4:
                    multiplicacion(n1, n2);
                    break;
                case 5:
                    division(n1, n2);
                    break;
                case 0:
                    Console.WriteLine("-------------------------------------------------------------");
                    Console.WriteLine("Ha salido del Programa CALCULADORA.");
                    Console.WriteLine("-------------------------------------------------------------");
                    break;
                default:
                    Console.WriteLine("-------------------------------------------------------------");
                    Console.WriteLine("Opcion Invalida.");
                    Console.WriteLine("-------------------------------------------------------------");
                    break;
            }
        }

        public void numeros()
        {
            float nm1 = 0, nm2 = 0;
            Console.WriteLine("-------------------------------------------------------------");
            Console.Write("Ingrese Numero 1: ");
            nm1 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese Numero 2: ");
            nm2 = float.Parse(Console.ReadLine());

            operaciones num = new operaciones(nm1, nm2);
            num.inicio_operaciones();
        }

        public void suma(float n1, float n2)
        {
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("La Suma de los numeros " + n1 + " + " + n2 + " es: " + (n1 + n2));
            inicio_operaciones();
        }
        public void resta(float n1, float n2)
        {
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("La Resta de los numeros " + n1 + " - " + n2 + " es: " + (n1 - n2));
            inicio_operaciones();
        }
        public void multiplicacion(float n1, float n2)
        {
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("La Multipliacion de los numeros " + n1 + " * " + n2 + " es: " + (n1 * n2));
            inicio_operaciones();
        }
        public void division(float n1, float n2)
        {
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("La Division de los numeros " + n1 + " / " + n2 + " es: " + (n1 / n2));
            inicio_operaciones();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int op = 0, sul = 0, nm1 = 0, nm2 = 0;
            string nem = "";

            empleado p1 = new empleado(nem, sul);
            operaciones num = new operaciones(nm1, nm2);

            do
            {
                Console.WriteLine("BIENVENID@ ELIJA UN PROGRAMA");
                Console.WriteLine("1. Impuestos.");
                Console.WriteLine("2. Calculadora.");
                Console.WriteLine("0. salir.");
                Console.Write("Opcion: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        p1.inicio_empleados();
                        break;
                    case 2:
                        num.inicio_operaciones();
                        break;
                    case 0:
                        Console.WriteLine("-------------------------------------------------------------");
                        Console.WriteLine("Hasta Luego!");
                        Console.WriteLine("-------------------------------------------------------------");
                        break;
                    default:
                        Console.WriteLine("-------------------------------------------------------------");
                        Console.WriteLine("Opcion Invalida.");
                        Console.WriteLine("-------------------------------------------------------------");
                        break;
                }
            } while (op != 0);
            Console.ReadKey();
        }
    }
}