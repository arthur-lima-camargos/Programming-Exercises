Console.WriteLine("Faça um programa que contenha uma função capaz de inverter uma string fornecida por um usuário.\n");
Console.WriteLine("Digite uma string: ");
string S = Console.ReadLine();
Console.WriteLine("\n");
int Pos = 0;
ImprimeString(S, Pos);
Console.ReadKey();

static void ImprimeString(string S, int Pos)
{
    Console.WriteLine("String Digitada: \n");
    Console.WriteLine($"{S}\n");
    Console.WriteLine("String Invertida: \n");
    for (Pos = S.Length - 1; Pos >= 0; Pos--)
    {
        Console.Write($"{S[Pos]}");
    }
}

