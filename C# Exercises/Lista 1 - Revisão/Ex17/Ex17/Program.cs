int Tam;
Random Z = new Random();
Console.Write("Digite o tamanho do vetor a ser preenchido: ");
Tam = int.Parse(Console.ReadLine());

int[] Vet = new int[Tam];

PreencheVetor(Vet, Z);

Console.Write("VETOR ORIGINAL: ");
for (int i = 0; i < Tam; i++)
{
    Console.Write($"{Vet[i],6}");
}
Console.Write("\n\n");

InverteVetor(Vet);

Console.Write("VETOR INVERTIDO: ");
for (int i = 0; i < Tam; i++)
{
    Console.Write($"{Vet[i],6}");
}

Console.ReadKey();


static int PreencheVetor(int[] X, Random R)
{
    for (int i = 0; i < X.Length; i++)
    {
        X[i] = R.Next(1, 51);
    }
    return X[X.Length - 1];
}

static int InverteVetor(int[] X)
{
    Array.Reverse(X);
    return X[X.Length - 1];
}
