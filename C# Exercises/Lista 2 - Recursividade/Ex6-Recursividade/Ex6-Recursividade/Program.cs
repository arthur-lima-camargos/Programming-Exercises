Console.WriteLine("Crie uma função recursiva que receba uma matriz e mostre o maior elemento par que ela possui. \n");
int Tam;
int Maior;

Console.Write("Ordem da Matriz: ");
Tam = int.Parse(Console.ReadLine());

Console.Write("\n");

int[,] Matriz = new int[Tam, Tam];

Random x = new Random();

for (int i = 0; i < Tam; i++)
{
    for (int j = 0; j < Tam; j++)
    {
        Matriz[i, j] = x.Next(0, 50);
        Console.Write($"{Matriz[i, j],7}");
    }
    Console.Write("\n");
}

Maior = MostraMaior(Matriz, 0, 0, 0, Tam);

Console.WriteLine($"\nMaior Par encontrado na Matriz: {Maior} !\n\n");

Console.WriteLine("\n");

Console.ReadKey();

static int MostraMaior(int[,] M, int i, int j, int Maior, int Tam)
{
    if (i < Tam && j < Tam)
    {
        if (M[i, j] % 2 == 0 && M[i, j] > Maior)
        {
            Maior = M[i, j];
        }

        Maior = MostraMaior(M, i, j + 1, Maior, Tam);

    }
    else if (i < Tam && j == Tam)
    {
        Maior = MostraMaior(M, i + 1, 0, Maior, Tam);
    }

    return Maior;
}