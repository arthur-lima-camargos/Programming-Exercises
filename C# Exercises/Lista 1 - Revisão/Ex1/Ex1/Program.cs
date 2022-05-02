Console.Write("Digite um número inteiro: ");
int N, Somatorio2 = 100;
double Somatorio = 0;

N = int.Parse(Console.ReadLine());

for (int i = 1; i <= N - 1; i++)
{
    Somatorio += (i / ((double)i + 1));
}

if (N % 2 != 0)
{
    Somatorio2 -= N;
}
else
{
    Somatorio2 += N;
}

Console.WriteLine($"Somatório 1 = {Somatorio:0.000}");
Console.WriteLine($"Somatório 2 = {Somatorio2}");
Console.ReadKey();