using ConsoleApp7;



List<IAuditable> list = new List<IAuditable>();

string name = string.Empty;
string auditoria = string.Empty;
double salario = 0;

Gerente gerente = new Gerente();
Darrollador darrollador = new Darrollador();
Contador contador = new Contador();

Console.WriteLine("\nGERENTE\n");
gerente.ObtenerNombre(name);
gerente.CalcularSalario(salario);
gerente.RegistrarAuditoria(auditoria);

Console.WriteLine("\nDESARROLLADOR\n");
darrollador.ObtenerNombre(name);
darrollador.CalcularSalario(salario);
darrollador.RegistrarAuditoria(auditoria);

Console.WriteLine("\nCONTADOR\n");
contador.ObtenerNombre(name);
contador.CalcularSalario(salario);
contador.RegistrarAuditoria(auditoria);

list.Add(gerente);
list.Add(darrollador);
list.Add(contador);

foreach (IAuditable i in list)
{
    if (i.GetType().ToString() == "ConsoleApp7.Gerente")
    {
        Console.WriteLine("\nGERENTE\n");
        Console.WriteLine(i.ToString());
    }
    else if(i.GetType().ToString() == "ConsoleApp7.Darrollador")
    {
        Console.WriteLine("\nDESARROLLADOR\n");
        Console.WriteLine(i.ToString());
    }
    else if (i.GetType().ToString() == "ConsoleApp7.Contador")
    {
        Console.WriteLine("\nCONTADOR\n");
        Console.WriteLine(i.ToString());
    }
}

Console.ReadKey();