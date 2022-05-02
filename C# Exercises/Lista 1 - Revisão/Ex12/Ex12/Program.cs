int[] Vet = new int[10];
int Cont = 0;
Random X = new Random();

for (int i = 0; i < 10; i++)
{
    Vet[i] = X.Next(1, 1000);
}

DividePorTres(Vet, Cont);

Console.ReadKey();


static void DividePorTres(int[] Vet, int Cont)
{
    for (int i = 0; i < 10; i++)
    {
        if (Vet[i] % 3 == 0)
        {
            Cont++;
            Console.WriteLine($"O número {Vet[i]} é divisível por 3.");
            Console.WriteLine("\n");
        }
    }
    Console.WriteLine($"Há no vetor {Cont} números divisíveis por 3.");
}
