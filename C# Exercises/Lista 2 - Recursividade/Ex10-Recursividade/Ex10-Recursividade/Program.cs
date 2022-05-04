string Frase, Palindromo;

Console.Write("Faça um programa que contenha uma função recursiva que mostre se uma frase se classifica como um palíndromo, ou seja, se lida da esquerda para a direita é igual à lida da direita para a esquerda.\n ");
Console.WriteLine("===================================================================================================");

Console.Write("Digite uma Frase: ");
Frase = Console.ReadLine();
Console.Write($"Frase Original: '{Frase}'\n");
Palindromo = new string(Frase.Reverse().ToArray());
Console.Write($"Frase Invertida: '{Palindromo}'\n");
if (ComparaStrings(Frase, Palindromo, 0))
    Console.WriteLine("As duas STRINGs são IGUAIS!");
else
    Console.WriteLine("As duas STRINGs são DIFERENTES!");

Console.ReadKey();

static bool ComparaStrings(string A, string B, int Pos)
{ 
    while(Pos != A.Length - 1)
    {
        bool Testa;

        Testa = A[Pos] == B[Pos];

        if (Pos == A.Length)
            return true;
        else
            return Testa && ComparaStrings(A, B, Pos + 1);
    }
    return true;
}