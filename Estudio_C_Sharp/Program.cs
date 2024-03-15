int[] vec1 = new int[4];
vec1[0] = 4;
vec1[1] = 6;
vec1[2] = 2;
vec1[3] = 9;

int[] vec2 = new int[4];
vec2[0] = 0;
vec2[1] = 7;
vec2[2] = 2;
vec2[3] = 5;

int llevando = 0;

Console.WriteLine(1 + " " + 1 + " ");
Console.WriteLine(4629);
Console.WriteLine(" "+729);
Console.WriteLine("----");
Console.WriteLine(4629 + 729 + "\n");

for (int i = 3; i >= 0; i--)
{
    if (vec1[i] + vec2[i] > 9)
    {
        llevando++;
        Console.WriteLine("Llevamos Cifra: " + 1);
    }
}

Console.WriteLine("Cantidad: " + llevando + "\n");
