Console.WriteLine("Crie uma função que calcule recursivamente a potência de um número\n");

int Base;
int Expoente;
int Potência;

Console.Write("Digite o valor da BASE: ");
Base = int.Parse(Console.ReadLine());

Console.Write("Digite o valor do EXPOENTE: ");
Expoente = int.Parse(Console.ReadLine());

Potência = CalcPot(Base, Expoente);

Console.WriteLine($"\n{Base}^{Expoente} = {Potência}");
Console.ReadKey();

static int CalcPot(int B, int E)
{
    int Pot;

    if (E == 0)
        Pot = 1;
    else
        Pot = B * CalcPot(B, E - 1);

    return Pot;
}