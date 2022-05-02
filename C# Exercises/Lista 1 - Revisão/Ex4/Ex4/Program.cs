Console.Write("Digite um número para saber se ele é um número primo: ");
int N, Contador = 1;
N = int.Parse(Console.ReadLine());

for (int i = 2; i < N; i++)
{
    if (N % i == 0)
    {
        Contador++;
    }
    else if(Contador > 2)
    {
        break;
    }
}

if (Contador > 2)
{
    Console.WriteLine($"O número {N} NÃO É PRIMO!!!");
}
else
{
    Console.WriteLine($"O número {N} É PRIMO!!!");
}

Console.ReadKey();  