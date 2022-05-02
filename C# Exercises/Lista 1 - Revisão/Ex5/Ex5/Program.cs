Console.WriteLine("PROGRAMA PARA LISTAR OS NÚMEROS PERFEITOS ENTRE 1 E 1000");
Console.WriteLine("\n\n");
Console.WriteLine("São eles:");

int SomaDivisores = 0, N = 1;

while (N <= 1000)
{
    for (int i = 1; i < N; i++)
    {
        if(N % i == 0)
        {
            SomaDivisores += i;
        }        
    }
    
    if (SomaDivisores == N)
    {
        Console.WriteLine($"{N}");
    }

    N++;
    SomaDivisores = 0;
}

Console.ReadKey();


