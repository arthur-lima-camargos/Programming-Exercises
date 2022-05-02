Console.Write("Digite o valor de N para mostrar os N primeiros elementos da \"Série de Fibonacci\": ");
int N, X = 0, Y = 1, Z = 0;
N = int.Parse(Console.ReadLine());

while(N <= 2)
{
    Console.Write("O Valor de N deve ser maior que 2");
    Console.Write("\nDigite um valor válido para N: ");
    N = int.Parse(Console.ReadLine());
}

Console.Write("1");
for (int i = 0; i < N; i++)
{
    Z = X + Y;
    X = Y;
    Y = Z;
    Console.Write($"{Z,5}");
}

Console.ReadKey();