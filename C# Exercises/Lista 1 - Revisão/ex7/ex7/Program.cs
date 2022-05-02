int[] A = new int[10];
int[] B = new int[10];
int[] C = new int[10];
int Pos = 0, Cont = 0;

Random x = new Random();

for (int i = 0; i < 10; i++)
{
    A[i] = x.Next(1, 21);
    B[i] = x.Next(1, 21);
}

// Interseção dos Vetores

for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        if (A[i] == B[j])
        {
            for(int k = 0; k<10; k++)
            {
                if(A[i] == C[k])
                {
                    Cont++;
                }
            }
            if(Cont == 0)
            {
                C[Pos] = A[i];
                Pos++;
            }
            Cont = 0;
        }
    }    
}

Console.WriteLine("ELEMENTOS NO VETOR A: ");
Mostra(A);
Console.WriteLine("\nELEMENTOS NO VETOR B: ");
Mostra(B);
Console.WriteLine("\nELEMENTOS NO VETOR C: ");
Mostra2(C, Pos);

static void Mostra(int[] V)
{
    for (int i = 0; i < V.Length; i++)
    {
        Console.Write($"{V[i],7}");
    }
    Console.Write("\n");
    Console.ReadKey();
}
static void Mostra2(int[] V, int Tam)
{
    for (int i = 0; i < Tam; i++)
    {
        Console.Write($"{V[i],7}");
    }
    Console.Write("\n");
    Console.ReadKey();
}

