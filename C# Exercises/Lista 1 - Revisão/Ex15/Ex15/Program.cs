int N, SuperFat;
Console.Write("DIGITE UM VALOR INTEIRO PARA OBTER O SEU SUPERFATORIAL: ");
N = int.Parse(Console.ReadLine());

SuperFat = SuperFatorial(N);

Console.WriteLine($"O Superfatorial de {N} é: {SuperFat}.");
Console.ReadKey();


static int SuperFatorial(int X)
{
    int Fat = 1;

    if (X == 0)
    {
        return 1;
    }
    else
    {
        for (int i = 1; i <= X; i++)
        {
            Fat = Fat * i;
        }
    }
    return Fat * SuperFatorial(X - 1);

}
