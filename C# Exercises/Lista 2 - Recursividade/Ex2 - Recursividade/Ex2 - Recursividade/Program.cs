Random x = new Random();
int[] Vet = new int[20];
int n = 0;
int i = 0;
Console.WriteLine("Faça uma função recursiva que mostre o maior número presente em um vetor de 20 posições. ");
Console.Write("========================================================================================\n");
MostraComRecursividade(Vet, i, n, x);
Console.ReadKey();

static void MostraComRecursividade(int[] V, int i, int n, Random x)
{
    if (i < 20)
    {
        if (i == 19)
        {
            V[i] = x.Next(1, 51);
            if (n < V[i])
            {
                n = V[i];
            }
            Console.Write($"Vetor[{i}] = {V[i++],5}\n");
            Console.WriteLine($"Maior Elemento do Vetor = {n}");
        }
        else
        {
            V[i] = x.Next(1, 51);
            if (n < V[i])
            {
                n = V[i];
            }
            Console.Write($"Vetor[{i}] = {V[i++],5}\n");

            MostraComRecursividade(V, i, n, x);
        }
    }
}