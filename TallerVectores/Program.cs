/**********PRIMERO PUNTO**********/
/*
int[] vector = new int[5];
int i = 0, num = 0;

do
{
    Console.WriteLine("Por Favor Digite un numero en posicion " + i + ": ");
    vector[i] = int.Parse(Console.ReadLine());
    i++;
} while (i <= 4);
Console.WriteLine("\n");
for (i = 0;i < 5; i++)
{
    Console.WriteLine("El numero digitado en la posicion " + i + " es: " + vector[i]);
}
*/

/**********SEGUNDO PUNTO**********/
/*
int[] vector = new int[100];
int i = 0, j = 0;

for (i = 2; i<=200; i = i + 2)
{
    vector[j] = i;
    Console.WriteLine(vector[j]+"\n");
    j = j + 1;
}
*/

/**********TERCER PUNTO**********/
/*
int i = 1, j = 0, suma = 0;
int[] vector = new int[10];

for (i = 1; i <= 10; i++)
{
    vector[j] = 3*i;
    Console.WriteLine("3x" + i + " = " + vector[j] + "\n");
    suma = suma + vector[j];
    j = j + 1;
}

Console.WriteLine("La suma total es: " + suma);
*/

/**********CUARTO PUNTO**********/
/*
int[] vector = new int[20];
Random rand = new Random();
int mayor = 0, aux = 0, j = 0;

for (int i = 0;i < vector.Length; i++)
{
    vector[i] = rand.Next(20);
    Console.WriteLine("Posicion " + i + " es: " + vector[i] + "\n");
}

while(j<20)
{
    if (vector[j] > mayor)
    {
        mayor = vector[j];
        aux = j;
    }
    j++;
}

Console.WriteLine("\nEl mayor es: " + mayor + " y esta en la posicion " + aux);
*/

/**********QUINTO PUNTO**********/
/*
int n = 0, i = 0, j = 0, suma = 0;

Console.WriteLine("Tamaño del vector: ");
n = int.Parse(Console.ReadLine());

int[] vector = new int[n];

for (i = 0;i < vector.Length; i++)
{
    Console.WriteLine("Ingrese un numero en posicion " + i + ":");
    vector[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("\nREPETICION NUMERO 10\n");

for (i = 0;i < vector.Length; i++)
{
    if (vector[i] == 10)
    {
        Console.WriteLine("Posicion " + i + " contiene: " + vector[i] + "\n");
        j++;
    }
}
Console.WriteLine("Se repite " + j + " veces\n");

Console.WriteLine("SUMA POSICIONES PARES\n");

for (i = 0; i < vector.Length; i = i + 2)
{
    suma = suma + vector[i];
}

Console.WriteLine("Suma total: " + suma + "\n");

//i = n - 1;
Console.WriteLine("IMPRIMIR VECTOR DESDE ULTIMO ELEMENTO\n");

for (i=n-1; i >= vector.Length; i--)
{
    Console.WriteLine("Numero en posicion " + i + " es " + vector[i] + "\n");
}
/*
while (i>=0)
{
    Console.WriteLine("Numero en posicion " + i + " es " + vector[i] + "\n");
    i--;
}
*/

/**********SEXTO PUNTO**********/
/*
int[] vector = new int[50];
Random rand = new Random();
int pares = 0, impares = 0, negativos = 0, positivos = 0;

for (int i = 0; i < vector.Length; i++)
{
    vector[i] = rand.Next(-25, 25);
    Console.WriteLine("Posicion " + i + " es: " + vector[i] + "\n");
}

for (int i = 0; i < vector.Length; i++)
{
    if (vector[i] % 2 == 0)
    {
        pares++;
    }else if (vector[i] % 2 != 0)
    {
        impares++;
    }
    if (vector[i] > 0)
    {
        positivos++;
    }else if (vector[i] < 0)
    {
        negativos++;
    }
}

Console.WriteLine("Existen, Pares: " + pares + ", Impares: " + impares + ", Positivos: " + positivos + ", Negativos: " + negativos);
*/

/**********SEPTIMO PUNTO**********/
/*
int[] vector = new int[40];
Random rand = new Random();
int suma = 0;

for (int i = 0; i < vector.Length; i++)
{
    vector[i] = rand.Next(40);
    Console.WriteLine("Posicion " + i + " es: " + vector[i] + "\n");
}

for (int i = 0; i < vector.Length; i++)
{
    if (vector[i] > vector[0] && vector[i] < vector[25])
    {
        Console.WriteLine("Elemento " + vector[i] + " Es mayor al " + vector[0] + " y menor a " + vector[25] + "\n");
        suma = suma + vector[i];
    }
}

Console.WriteLine("Total suma: " + suma);
*/

/**********OCTAVO PUNTO**********/
/*
int[] vector = new int[30];
Random rand = new Random();
int mayor = 0, menor = 100, perdieron = 0, prom = 0;

for (int i = 0; i < vector.Length; i++)
{
    vector[i] = rand.Next(10,51);
    Console.WriteLine("Posicion " + i + " es: " + vector[i] + "\n");
    prom = prom + vector[i];
}

for (int i = 0; i < vector.Length; i++)
{
    if (vector[i] > mayor)
    {
        mayor = vector[i];
    }
    if (vector[i] < menor)
    {
        menor = vector[i];
    }
    if (vector[i] < 30)
    {
        perdieron++;
    }
}

Console.WriteLine("mayor: " + mayor + ", menor: " + menor + "\n");
Console.WriteLine("Perdieron: " + perdieron + "\n");
Console.WriteLine("Promedio: " + prom / 30 + "\n");
*/

/**********NOVENO PUNTO**********/
/*
int n = 0;

Console.WriteLine("Tamaño de los vectores: ");
n = int.Parse(Console.ReadLine());

int[] vector1 = new int[n];
int[] vector2 = new int[n];
int[] vector3 = new int[n*n];
Random rand = new Random();
int f = 0;

for (int i = 0; i < n; i++)
{
    vector1[i] = rand.Next(10);
    vector2[i] = rand.Next(10);
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        vector3[f] = vector1[i] * vector2[j];
        Console.WriteLine(vector1[i] + "x" + vector2[j] + " = " + vector3[f] + "\n");
        f++;
    }
}
*/

/**********DECIMO PUNTO**********/
/*
int n = 0, codigo = 0;
char c, j;

Console.WriteLine("Tamaño de los vectores: ");
n = int.Parse(Console.ReadLine());

int[] vector1 = new int[n];
int[] vector2 = new int[n];
int[] vector3 = new int[n];

for (int i = 0; i < n; i++)
{
    Console.WriteLine("\nESTUDAINTE " + i);

    Console.WriteLine("\nCodigo Estudiante: ");
    codigo = int.Parse(Console.ReadLine());

    Console.WriteLine("\nSI(s) / NO(n)");

    Console.WriteLine("\nPerdio C#: ");
    c = char.Parse(Console.ReadLine());

    if (c == 's')
    {
        
        vector1[i] = codigo;
    }

    Console.WriteLine("\nPerdio Java: ");
    j = char.Parse(Console.ReadLine());
    if (j == 's')
    {
        vector2[i] = codigo;
    }

    if (j == 's' && c == 's')
    {
        vector3[i] = codigo;
    }
}

Console.WriteLine("\nEstudiantes que Perdieron C#: \n");
for (int i = 0; i < n; i++)
{
    Console.WriteLine(vector1[i] + "\n");
}
Console.WriteLine("\nEstudiantes que Perdieron J#: \n");
for (int i = 0; i < n; i++)
{
    Console.WriteLine(vector2[i] + "\n");
}
Console.WriteLine("\nEstudiantes que Perdieron Ambos Lenguajes: \n");
for (int i = 0; i < n; i++)
{
    Console.WriteLine(vector3[i] + "\n");
}
*/

/**********PUNTO ONCE**********/
/*
int[] vector = new int[7];
int[] vector1 = new int[7];
vector[0] = 14;
vector[1] = 12;
vector[2] = 6;
vector[3] = 25;
vector[4] = 34;
vector[5] = 23;
vector[6] = 5;

for (int i = 0; i < vector.Length; i++)
{
    Console.WriteLine(vector[i]);
}
Console.WriteLine("-");
for (int i = 6; i >=0 ; --i)
{
    vector1[i] = vector[i];
    Console.WriteLine(vector1[i]);
}
*/

/**********PUNTO DOCE**********/
/*
string[] vector = new string[365];

for (int i = 0; i <= 91; i++)
{
    vector[i] = "v";
    Console.WriteLine("Dia "+i+": "+vector[i]);
}
for (int i = 92; i <= 182; i++)
{
    vector[i] = "i";
    Console.WriteLine("Dia " + i + ": " + vector[i]);
}
for (int i = 183; i <= 273; i++)
{
    vector[i] = "o";
    Console.WriteLine("Dia " + i + ": " + vector[i]);
}
for (int i = 274; i <= 364; i++)
{
    vector[i] = "p";
    Console.WriteLine("Dia " + i + ": " + vector[i]);
}
*/

/**********PUNTO TRECE**********/
/*
int n = 0, i = 0, aux = 0;
Random rand = new Random();

do
{
    Console.WriteLine("Digite el Tamaño del Vector en numero Par: ");
    n = int.Parse(Console.ReadLine());
} while (n % 2 != 0);

int[] vector = new int[n];
Console.WriteLine("\n");
for (i = 0; i < n; i++)
{
    vector[i]= rand.Next(11);
    Console.WriteLine(vector[i]);
}
Console.WriteLine("-");
for (i=0; i < (n - 1); i++)
{
    aux = vector[i];
    vector[i] = vector[i + 1];
    vector[i + 1] = aux;
}

i = 0;

while (i < n)
{
    Console.WriteLine(vector[i]);
    i++;
}
*/

/**********PUNTO CATORCE**********/
/*
int[] vector = new int[144];
Random rand = new Random();
int mayor = 0, aux = 0, suma = 0, c = 0, j = 0;

for (int i = 0; i < vector.Length; i++)
{
    vector[i] = rand.Next(145);
    Console.WriteLine("Posicion " + i + " es: " + vector[i] + "\n");
}

for(int i = 0;i < vector.Length; i++)
{
    if (vector[i] > mayor)
    {
        mayor = vector[i];
        aux = i;
    }
    if (vector[i] % 2 == 0)
    {
        suma = suma + vector[i];
    }
    if (vector[i] > 80 && vector[i] < 120)
    {
        c++;
    }
    if (vector[i] % 7 == 0)
    {
        j++;
    }
}

Console.WriteLine("Numero mayor: " + mayor + ", Suma Posiciones Pares: " + suma + ", Mayores a 80 y Menores a 120: " + c + ", Multiplos de 7: " + j + "\n");

for (int i = 143; i >= 0; --i)
{
    Console.WriteLine(vector[i]);
}
*/

/**********PUNTO QUINCE**********/
/*
int[] vector = new int[125];
int[] vector1 = new int[62];
Random rand = new Random();
int suma = 0, num = 0, cantidad = 0;

for (int i = 0; i < vector.Length; i++)
{
    vector[i] = rand.Next(126);
    Console.WriteLine("Posicion " + i + " es: " + vector[i] + "\n");
}

for (int i = 0; i < vector.Length; i++)
{
    suma = suma + vector[i];
    int x = 0;
    for (int j = 1; j < vector.Length; j = j + 2)
    {
        vector1[x] = vector[j];
        x++;
    }
}

for (int j = 0; j < vector.Length; j++)
{
    if ((vector[j] % 3 == 0) && (vector[j] > 0))
    {
        cantidad = cantidad + 1;
    }
}

Console.WriteLine("Numero a Buscar: ");
num = int.Parse(Console.ReadLine());

for (int j = 0; j < vector.Length; j++)
{
    if (vector[j] == num)
    {
        Console.WriteLine("\nNumero Encontrado en la Posicion " + j);
    }
}

Console.WriteLine("\nPromedio: " + suma / 125 + ", Cantidad numero multilpos de 3 y Positivos: " + cantidad + "\n");

Console.WriteLine("Elementos de las Posiciones Impares");
for (int i = 0; i < vector1.Length; i++)
{
    Console.WriteLine(vector1[i]);
}
*/

using System.Linq.Expressions;

int[] vector = new int[4];
int op = 0, c1 = 0, c2 = 0, c3 = 0, c4 = 0;

Console.WriteLine("\nBienvenido a las Votaciones del año.");

do
{
    Console.WriteLine("--------------------------------------");
    Console.WriteLine("Eliga con determinacion.");
    Console.WriteLine("1. Pepito.");
    Console.WriteLine("2. Chancho.");
    Console.WriteLine("3. juanito.");
    Console.WriteLine("4. Luiza.");
    Console.WriteLine("0. Salir.");
    op = int.Parse(Console.ReadLine());

    switch (op)
    {
        case 1:
            Console.WriteLine("Eligio a Pepito.");
            c1 = c1 + 1;
            break;
        case 2:
            Console.WriteLine("Eligio a Chancho.");
            c2 = c2 + 1;
            break;
        case 3:
            Console.WriteLine("Eligio a Juanito.");
            c3 = c3 + 1;
            break;
        case 4:
            Console.WriteLine("Eligio a Luiza.");
            c4 = c4 + 1;
            break;
        case 0:
            Console.WriteLine("Hasta la proimaaaa.");
            break;
        default:
            Console.WriteLine("Opcion Invalida.");
            break;
    }
} while(op!=0);

Console.WriteLine("--------------------------------------");
Console.WriteLine("Pepito: " + c1);
Console.WriteLine("Chancho: " + c2);
Console.WriteLine("Juanito: " + c3);
Console.WriteLine("Luiza: " + c4);
Console.WriteLine("--------------------------------------");