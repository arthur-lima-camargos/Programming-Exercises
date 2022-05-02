string N;
char[] Num1 = new char[4];
char[] Num2 = new char[4];
bool Palindromo = true;

Console.Write("Digite um número natural de 4 dígitos: ");
N = Console.ReadLine();
N.ToCharArray();

for (int i = 0; i < N.Length; i++)
{
    Num1[i] = N[i];
    Num2[i] = N[i];
}

Array.Reverse(Num2);

FuncPalindromo(Num1, Num2, Palindromo, N);
Console.ReadKey();

static bool FuncPalindromo(char [] Num1, char[] Num2, bool Palindromo, string N)
{
    for (int i = 0; i < Num1.Length; i++)
    {
        if (Num1[i] != Num2[i])
        {
            Palindromo = false;
            break;
        }
    }
    if (Palindromo == false)
    {
        Console.WriteLine($"O Número {N} NÃO é um palíndromo");
    }
    else
    {
        Console.WriteLine($"O Número {N} É um palíndromo");
    }
    return Palindromo;
}
