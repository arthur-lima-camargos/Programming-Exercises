Random x = new Random();
int[] Vet = new int[10];
int n = 0;
int i = 0;
Console.WriteLine("Faça uma função recursiva que conte quantos números pares um vetor de 10 posições de números aleatórios possui.");
Console.Write("========================================================================================\n");
MostraComRecursividade(Vet, i, n, x);
Console.ReadKey();

static void MostraComRecursividade(int[] V, int i, int n, Random x)
{
    if (i < 10)
    {
        if (i == 9)
        {
            V[i] = x.Next(1, 51);
            if (V[i] % 2 == 0)
            {
                n++;
            }
            Console.Write($"Vetor[{i}] = {V[i++],5}\n");
            Console.WriteLine($"Quantidade de Elementos Pares = {n}");
        }
        else
        {
            V[i] = x.Next(1, 51);
            if (V[i] % 2 == 0)
            {
                n++;
            }
            Console.Write($"Vetor[{i}] = {V[i++],5}\n");

            MostraComRecursividade(V, i, n, x);
        }
    }
}