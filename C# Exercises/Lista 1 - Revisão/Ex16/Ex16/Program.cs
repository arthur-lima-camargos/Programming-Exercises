int[] Vet = new int[10];
Random X = new Random();

for (int i = 0; i < Vet.Length; i++)
{
    Vet[i] = X.Next(1, 21);
}

for (int i = 0; i < Vet.Length; i++)
{
    for (int j = i + 1; j < Vet.Length; j++)
    {
        if (Vet[i] == Vet[j])
        {
            Console.WriteLine($"O Valor {Vet[i]} se repete ao longo do vetor.");
            break;
        }
    }
}

Console.ReadKey();
