int[,] Mat = new int[3, 3];
int[] Vet = new int[6];
int Cont = 0;
Random X = new Random();

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Mat[i, j] = X.Next(1, 100);
    }
}

Console.WriteLine("ELEMENTOS DA MATRIZ:");
Console.Write("\n");

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"{Mat[i, j],6}");
    }
    Console.Write("\n");
}

ChamaVet(Mat, Vet, Cont);
Console.ReadKey();


static void ChamaVet(int[,] X, int[] Y, int Z)
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            if (j > i || i > j)
            {
                Y[Z] = X[i, j];
                Z++;
            }
        }
    }
    Console.Write("\n");
    Console.Write("ELEMENTOS DO VETOR:");
    Console.Write("\n\n");
    for (int i = 0; i < Y.Length; i++)
    {
        Console.Write($"{Y[i],6}");
    }
}
