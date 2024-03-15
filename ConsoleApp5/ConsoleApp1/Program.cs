using ConsoleApp1;

string op = string.Empty;
string descripcion = string.Empty;
int prioridad = 0;

ListaDeTareas listaDeTareas = new ListaDeTareas();

while (true)
{
    Console.Write("\nDesea Agregar un Proyecto? si/no: ");
    op = Console.ReadLine();

    if (op == "si")
    {
        IProyecto proyecto = new Proyecto();

        while (true)
        {
            Console.Write("Descripcion Tarea: ");
            descripcion = Console.ReadLine();

            Console.Write("Prioridad: ");
            prioridad = int.Parse(Console.ReadLine());

            if (prioridad > 0 && prioridad < 6)
            {
                ITarea tarea = new Tarea(descripcion, prioridad);
                proyecto.AgregarTarea(tarea);
            }
            else
            {
                Console.WriteLine("Debe ser entre 1 y 5");
            }

            Console.Write("\nDesea Agregar una Tarea mas? si/no: ");
            op = Console.ReadLine();

            if (op == "no")
            {
                break;
            }
        }
        listaDeTareas.AgregarProyecto(proyecto);
    }
    else
    {
        break;
    }
}

Console.WriteLine("\n===============================================================");
Console.WriteLine("\n" + listaDeTareas.ToString());
int i = 0;

foreach (var proyecto in listaDeTareas.ObtenerProyectos())
{
    i++;
    Console.WriteLine($"Proyecto {i}:");
    var tareasOrdenadas = proyecto.ObtenerTareas().OrderByDescending(t => t.ObtenerPrioridad());

    foreach (var tarea in tareasOrdenadas)
    {
        Console.WriteLine($"- Tarea: {tarea.ObtenerDescripcion()}\n   Prioridad: {tarea.ObtenerPrioridad()}");
    }
}

Console.ReadKey();