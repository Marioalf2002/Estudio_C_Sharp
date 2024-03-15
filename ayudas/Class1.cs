using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ayudas.Empleado;

namespace ayudas
{
    /*Desarrollar un programa con una clase que represente un empleado.Definir
   como atributos su nombre y su sueldo.Crear los métodos para cargar la
   información,otro para mostrar la información y por último uno que calcule
   y muestre un mensaje si debe pagar impuestos(solo si el sueldo supera
   a 52.000.000).*/
    internal class Empleado
    {
        public string nombre;
        public float sueldo;

        public Empleado(string nombre, float sueldo)
        {
            this.nombre = nombre;
            this.sueldo = sueldo;
        }
        public void Dato()
        {
            Console.WriteLine("El empleado " + this.nombre + " tiene un sueldo de: " + this.sueldo);
        }

        public void Impuesto()
        {
            if (sueldo > 52000000)
            {
                Console.WriteLine("Empleado " + this.nombre + " usted SI debe de pagar impuestos");
            }
            else
            {
                Console.WriteLine("Empleado " + this.nombre + " usted NO debe de pagar impuestos");
            }
        }

        /*Desarrollar un programa de operaciones.Se deben cargar dos valores
        enteros, calcular su suma, calcular resta, calcular multiplicación
        y división, cada operación debe imprimir el resultado.*/

        internal class Operacion
        {
            public int num1;
            public int num2;


            public Operacion(int num1, int num2)
            {
                this.num1 = num1;
                this.num2 = num2;
            }
            public void Suma()
            {
                int total = this.num1 + this.num2;
                Console.WriteLine("La suma de " + this.num1 + " Y " + this.num2 + " Es: " + total);
            }

            public void Resta()
            {
                int total = this.num1 - this.num2;
                Console.WriteLine("La resta de " + this.num1 + " Y " + this.num2 + " Es: " + total);
            }

            public void Multiplicación()
            {
                int total = this.num1 * this.num2;
                Console.WriteLine("La multiplicación de " + this.num1 + " Y " + this.num2 + " Es: " + total);
            }

            public void División()
            {
                float total = this.num1 / this.num2;

                if (this.num1 == 0 || this.num2 == 0)
                {
                    Console.WriteLine("No se puede dividir");
                }

                Console.WriteLine("La división de " + this.num1 + " Y " + this.num2 + " Es: " + total);
            }

            public void Inicializar()
            {
                Console.WriteLine("Bienvenido Señor Usuario");
                Console.WriteLine("ELIGE UNA OPCIÓN");
                Console.WriteLine("\t1.Empleado");
                Console.WriteLine("\t2.Operaciones");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Ingrese el nombre del empleado");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese el sueldo de " + nombre);
                        float sueldo = float.Parse(Console.ReadLine());

                        Empleado dat = new Empleado(nombre, sueldo);

                        Console.WriteLine("ELIGE UNA OPCIÓN");
                        Console.WriteLine("\t3.Ver empleado y sueldo");
                        Console.WriteLine("\t4.Pagar impuestos");
                        option = int.Parse(Console.ReadLine());
                        switch (option)
                        {
                            case 3:
                                dat.Dato();
                                break;
                            case 4:
                                dat.Impuesto();
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el primer número:");
                        int num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número:");
                        int num2 = int.Parse(Console.ReadLine());

                        Operacion dat2 = new Operacion(num1, num2);

                        Console.WriteLine("ELIGE UNA OPCIÓN");
                        Console.WriteLine("\t5.Sumar");
                        Console.WriteLine("\t6.Restar");
                        Console.WriteLine("\t7.Multiplicar");
                        Console.WriteLine("\t8.Dividir");
                        option = int.Parse(Console.ReadLine());

                        switch (option)
                        {
                            case 5:
                                dat2.Suma();
                                break;
                            case 6:
                                dat2.Resta();
                                break;
                            case 7:
                                dat2.Multiplicación();
                                break;
                            case 8:
                                dat2.División();
                                break;

                            default:
                                break;
                        }
                        break;

                        Console.ReadKey();
                }
            }
        }
    }

    internal class Class1
    {
        static void Main(string[] args)
        {
            string nombre = "";
            float sueldo = 0;
            int n1 = 0, n2 = 0;
            
            Console.Write("hola");

            Operacion p1 = new Operacion(n1, n2);
            p1.Inicializar();

            Console.ReadKey();
        }
    }
}
