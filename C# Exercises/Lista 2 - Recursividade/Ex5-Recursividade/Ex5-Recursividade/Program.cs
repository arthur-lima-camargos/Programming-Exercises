Console.WriteLine("Crie uma função recursiva que calcule a seguinte série: 1+2-3+4-5+6-7... O usuário irá declarar o número.\n");

int Num;
int Result;
int i = 1;
int ColheResposta = 0;


Console.Write("Digite um NÚMERO: ");
Num = int.Parse(Console.ReadLine());

Result = Somatorio(Num, i, ColheResposta);
Console.WriteLine($"O RESULTADO DO SOMATÓRIO É: {Result}");
Console.ReadKey();

static int Somatorio(int Num, int j, int Resultado)
{
    while (j <= Num)
    {
        if (j == 1)
        {
            Resultado = Resultado + 1;
            j++;
        }
        else if (j % 2 != 0)
        {
            Resultado = Resultado - j;
            j++;
            return Somatorio(Num, j, Resultado);
        }
        else
        {
            Resultado = Resultado + j;
            j++;
            return Somatorio(Num, j, Resultado);
        }
    }
    return Resultado;
}