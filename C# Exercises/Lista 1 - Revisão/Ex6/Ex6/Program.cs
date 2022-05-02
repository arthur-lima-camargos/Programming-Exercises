int[] A = new int[10];
int[] B = new int[10];
int[] C = new int[20];
bool Existe = false;

int Pos = 0;
Random x = new Random();

for (int i = 0; i < 10; i++)
{
    A[i] = x.Next(1, 21);
    B[i] = x.Next(1, 21);
}
// União dos Vetors
for (int i = 0; i < 10; i++) // Vetor A
{
    Existe = false;
    for (int j = 0; j < Pos; j++)
    {
        if (A[i] == C[j])
        {
            Existe = true;
        }
    }
    if (!Existe)
    {
        C[Pos] = A[i];
        Pos++;
    }
}

for (int i = 0; i < 10; i++) // Vetor B
{
    Existe = false;
    for (int j = 0; j < Pos; j++)
    {
        if (B[i] == C[j])
        {
            Existe = true;
        }
    }
    if (!Existe)
    {
        C[Pos] = B[i];
        Pos++;
    }
}
Console.WriteLine("ELEMENTOS NO VETOR A: ");
Mostra(A);
Console.WriteLine("\nELEMENTOS NO VETOR B: ");
Mostra(B);
Console.WriteLine("\nELEMENTOS NO VETOR C: ");
Mostra2(C, Pos);

#region funções
/// <summary>
/// Mostra os elementos do Vetor
/// </summary>
/// <param name="V">Vetor de inteiros</param>
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

#endregion
