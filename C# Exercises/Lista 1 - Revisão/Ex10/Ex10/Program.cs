double ArvoreA = 0.8, ArvoreB = 1.3;
int Ano = 0;

while (ArvoreB > ArvoreA)
{
    ArvoreA += 0.12;
    ArvoreB += 0.08;
    Ano++;
}

Console.WriteLine($"A Árvore A ficará maior que a Árvore B em {Ano} Anos.");
Console.ReadKey();  
