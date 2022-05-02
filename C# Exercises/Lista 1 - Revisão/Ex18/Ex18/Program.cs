// Faça  um  programa  que  contenha  uma  função  capaz  de  receber  uma  matriz  quadrada  de 
// ordem  “n”  (definida  pelo usuário)  e retornar  outra  matriz  que  contenha, nas  mesmas 
// posições, os valores dos elementos pares e o valor 0 (zero) para os elementos ímpares.


int N;
Random X = new Random();              
Console.Write("Digite a ordem da matriz quadrada: ");
N = int.Parse(Console.ReadLine());
Console.WriteLine("\n");
int[,] Mat = new int[N,N];

PreencheMatriz(Mat, X);

Console.WriteLine("MATRIZ ORIGINAL:\n");

for (int i = 0; i < Mat.GetLength(0); i++)
{
    for (int j = 0; j < Mat.GetLength(1); j++)
    {
        Console.Write($"{Mat[i, j],5}");
    }
    Console.WriteLine("\n");
}

MudaMatriz(Mat);

Console.WriteLine("MATRIZ MODIFICADA:\n");

for (int i = 0; i < Mat.GetLength(0); i++)
{
    for (int j = 0; j < Mat.GetLength(1); j++)
    {
        Console.Write($"{Mat[i, j],5}");
    }
    Console.WriteLine("\n");
}

Console.ReadKey();

// ------------------------------------------------

static int PreencheMatriz(int [,] M, Random Y)
{
    for (int i = 0; i< M.GetLength(0); i++)
    {
        for(int j = 0; j < M.GetLength(1); j++)
        {
            M[i, j] = Y.Next(1, 51);
        }
    }
    return M[M.GetLength(0)-1, M.GetLength(1) - 1];
}

static int MudaMatriz(int [,] M)
{
    for (int i = 0; i < M.GetLength(0); i++)
    {
        for (int j = 0; j < M.GetLength(1); j++)
        {
            if (M[i, j] % 2 != 0)
            {
                M[i, j] = 0;
            }
        }
    }
    return M[M.GetLength(0) - 1, M.GetLength(1) - 1];
}