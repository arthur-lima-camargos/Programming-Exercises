int[] Altura = new int[15];
int [] Idade = new int[15];
char[] Sexo = new char[15];
int Maior = 0, Menor = 200, Somatorio = 0, Senhores = 0, Contador = 0;
double Media;
Random x = new Random();

for (int i = 0; i < 15; i++)
{
    Altura[i] = x.Next(150, 201);
    Idade[i] = x.Next(18, 51);
    Sexo[i] = (char)x.Next('1', '3');
    if (Sexo[i] == '1')
    {
        Sexo[i] = 'F';
    }
    else
    {
        Sexo[i] = 'M';
    }
}

for (int i = 0; i < 15; i++)
{
    if (Altura[i] > Maior)
    {
        Maior = Altura[i];
    }
    else if (Altura[i] < Menor)
    {
        Menor = Altura[i];
    } 
    else if (Sexo[i] == 'F')
    {
        Contador++;
        Somatorio += Altura[i];
    }
    if (Sexo[i] == 'M')
    {
        Senhores++;
    }
}
Media = Somatorio / Contador;
Console.WriteLine($"A MAIOR altura GERAL é: {Maior}cm");
Console.WriteLine("\n\n");
Console.WriteLine($"A MENOR altura GERAL é: {Menor}cm");
Console.WriteLine("\n\n");
Console.WriteLine($"A MÉDIA da altura entre as MULHRES é: {Media}cm");
Console.WriteLine("\n\n");
Console.WriteLine($"O número de HOMENS com idade entre 40 e 50 anos é: {Senhores}");
Console.ReadKey();