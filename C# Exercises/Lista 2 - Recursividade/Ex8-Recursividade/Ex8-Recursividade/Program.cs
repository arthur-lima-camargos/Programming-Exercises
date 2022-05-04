Console.Write("Faça uma função recursiva que conte o número de dígitos um determinado número fornecido pelo usuário. \n");
Console.Write("=====================================================================================================\n");
int N;
int QtdDig;

Console.Write("Digite um Número: ");
N = int.Parse(Console.ReadLine());

QtdDig = ContaDig(N);

Console.WriteLine($"Esse número tem {QtdDig} dígitos!");

Console.ReadKey();

static int ContaDig(int n)
{
    if (n != 0)
        return 1 + ContaDig(n / 10);

    return 0;
}