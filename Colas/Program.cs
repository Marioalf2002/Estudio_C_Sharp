using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas
{
    //COLA MENU SWITCH
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> Cola = new Queue<int>();
            int opcion;//opcion del menu 

            do
            {
                Console.Clear();//se limpia consola
                opcion = menu();//muestra menu y espera opción
                int valor = 0;

                switch (opcion)
                {
                    case 1:
                        Console.Write("\n Ingrese valor: ");
                        valor = int.Parse(Console.ReadLine());
                        try
                        {
                            if (valor > 99 || valor <= 0)
                            {
                                Console.WriteLine("\n=======================================================");
                                Console.WriteLine("Solo números del 1 al 99");
                                Console.WriteLine("=======================================================");
                                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                                Console.ReadKey();
                            }

                            else
                            {
                                Cola.Enqueue(valor);// apilar, colocar elemento al principio
                                if (Cola.Count > 0)
                                {
                                    Console.WriteLine("");
                                    foreach (int dato in Cola)
                                    {
                                        Console.WriteLine(" |      |");
                                        if (dato < 10)
                                            Console.WriteLine(" |   {0}  |", dato);
                                        else
                                            Console.WriteLine(" |  {0}  |", dato);
                                        Console.WriteLine(" |______|");
                                    }
                                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("La Cola esta vacia");
                                }

                            }
                        }
                        catch
                        {
                            Console.WriteLine("Error: Solo números del 1 al 99");
                        }
                        break;

                    case 2:
                        if (Cola.Count > 0)
                        {
                            Cola.Dequeue();//desapilar, extraer dato de la pila
                            Console.WriteLine("\n=======================================================");
                            Console.WriteLine("Elemento eliminado");
                            Console.WriteLine("=======================================================");
                            Console.WriteLine("\nPresione cualquier tecla para continuar...");
                            Console.ReadKey();
                        }
                        break;

                    case 3:
                        Cola.Clear();
                        Console.WriteLine("\n=======================================================");
                        Console.WriteLine("La Cola Se Ha Eliminado");
                        Console.WriteLine("=======================================================");
                        Console.WriteLine("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();

                        break;

                    case 4:
                        if (Cola.Count > 0)// ver pila
                        {
                            Console.WriteLine("");
                            foreach (int dato in Cola)
                            {
                                Console.WriteLine(" |      |");
                                if (dato < 10)
                                    Console.WriteLine(" |   {0}  |", dato);
                                else
                                    Console.WriteLine(" |  {0}  |", dato);
                                Console.WriteLine(" |______|");
                            }

                        }
                        else
                        {
                            Console.WriteLine("\n=======================================================");
                            Console.WriteLine("La Cola esta vacia");
                            Console.WriteLine("=======================================================");
                            Console.WriteLine("\nPresione cualquier tecla para continuar...");
                        }
                        Console.ReadKey();
                        break;

                    case 5: break;
                    default:
                        Console.WriteLine("ERROR: la opción no es valida. Intente de nuevo.");
                        break;
                }

            } while (opcion != 0);
        }

        // crear Menu
        static int menu()
        {
            Console.Clear();
            Console.WriteLine("\n           Menu Cola\n");
            Console.WriteLine(" 1. Agregar elemento");
            Console.WriteLine(" 2. Eliminar elemento");
            Console.WriteLine(" 3. Vaciar Cola");
            Console.WriteLine(" 4. Ver Cola");
            Console.WriteLine(" 0. Termina programa");
            Console.WriteLine("\n");
            Console.Write("     Ingresa tu opción: ");
            try
            {
                int valor = Convert.ToInt32(Console.ReadLine());
                return valor;
            }
            catch
            {
                return 0;
            }

        }
    }
}
