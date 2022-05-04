Console.WriteLine("Faça um programa que contenha funções recursivas capazes de gerar, mostrar e somar os elementos da diagonal principal de uma matriz quadrada. \n");

int Tam;

Console.Write("Ordem da Matriz: ");
Tam = int.Parse(Console.ReadLine());

int[,] Matriz = new int[Tam, Tam];
int SomaDiag;

Random x = new Random();

Console.WriteLine("\n");

MostraMatriz(Matriz, 0, 0, x);
SomaDiag = MostraSomaDiagonal(Matriz, 0, 0);
Console.WriteLine("\n");
Console.WriteLine($"DIAGONAL PRINCIPAL: {SomaDiag}");
Console.ReadKey();

static void MostraMatriz(int[,] M, int i, int j, Random x)
{
    int Tam = M.GetLength(0);

    if (i < Tam && j < Tam)
    {
        M[i, j] = x.Next(0, 50);
        Console.Write($"{M[i, j],7}");
        
        j++;

        MostraMatriz(M, i, j, x);
    }
    else if (i < Tam && j == Tam)
    {
        i++;
        j = 0;

        Console.Write("\n");

        MostraMatriz(M, i, j, x);
    }
}

static int MostraSomaDiagonal(int[,] M, int i, int j)
{
    int Tam = M.GetLength(0);

    if (i < Tam && j < Tam)
    {
        if(i == j)
        {
           
           return M[i,j] + MostraSomaDiagonal(M, ++i, ++j);
        }
    }
    else if (i < Tam && j == Tam)
    {
        i++;
        j = 0;
        return MostraSomaDiagonal(M, i, j);
    }
    return 0;
}