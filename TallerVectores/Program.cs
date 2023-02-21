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

i = n - 1;
Console.WriteLine("IMPRIMIR VECTOR DESDE ULTIMO ELEMENTO\n");

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
int[] vector3 = new int[n];
Random rand = new Random();

for (int i = 0; i < n; i++)
{
    vector1[i] = rand.Next(10);
    vector2[i] = rand.Next(10);
}

for (int i = 0; i < n; i++)
{
    vector3[i] = vector1[i] * vector2[i];
    Console.WriteLine(vector1[i] + "x" + vector2[i] + " = " + vector3[i] + "\n");
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

int[] vector = new int[365];

for (int i = 1; i <= 365; i++)
{
    
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

