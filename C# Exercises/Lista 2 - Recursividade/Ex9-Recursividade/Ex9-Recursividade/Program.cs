Console.Write("Crie uma função recursiva que conte o número de divisores de um número.\n");
Console.Write("=======================================================================\n");
int N;
int QtdDiv;

Console.Write("Digite um Número: ");
N = int.Parse(Console.ReadLine());

QtdDiv = ContaDiv(N, 1, 0);

Console.WriteLine($"Esse número tem {QtdDiv} DIVISORES!");

Console.ReadKey();

static int ContaDiv(int n, int i, int Cont)
{
    while (i <= n)
    {
        if(n % i == 0)
        {
            return ContaDiv(n, ++i, ++Cont);
        }
        else
        {
            return ContaDiv(n, ++i, Cont);
        }
    }
    return Cont;   
}