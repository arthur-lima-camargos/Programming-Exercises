string[] Nomes = new string[50];
double[] P1 = new double[50];
double[] P2 = new double[50];
double[] P3 = new double[50];
double[] NotaFinal = new double[50];
double Media1 = 0, Media2 = 0, Media3 = 0;

for (int i = 0; i < 50; i++)
{
    Console.Write($"Digite o NOME do {i + 1}º aluno: ");
    Nomes[i] = Console.ReadLine();

    Console.Write($"Digite a NOTA do {i + 1}º aluno na 1ª PROVA: ");
    P1[i] = double.Parse(Console.ReadLine());
    while (P1[i] > 33.3 || P1[i] < 0)
    {
        Console.Write($"Digite uma nota entre 0 e 33,3 pontos: ");
        P1[i] = double.Parse(Console.ReadLine());
    }
    NotaFinal[i] = P1[i];

    Console.Write($"Digite a NOTA do {i + 1}º aluno na 2ª PROVA: ");
    P2[i] = double.Parse(Console.ReadLine());
    while (P2[i] > 33.3 || P2[i] < 0)
    {
        Console.Write($"Digite uma nota entre 0 e 33,3 pontos: ");
        P2[i] = double.Parse(Console.ReadLine());
    }
    NotaFinal[i] += P2[i];

    Console.Write($"Digite a NOTA do {i + 1}º aluno na 3ª PROVA: ");
    P3[i] = double.Parse(Console.ReadLine());
    while (P3[i] > 33.3 || P3[i] < 0)
    {
        Console.Write($"Digite uma nota entre 0 e 33,3 pontos: ");
        P3[i] = double.Parse(Console.ReadLine());
    }
    NotaFinal[i] += P3[i];

    Console.Clear();

    Media1 += P1[i];
    Media2 += P2[i];
    Media3 += P3[i];
}

Media1 = Media1 / 50;
Media2 = Media2 / 50;
Media3 = Media3 / 50;

Console.Write("NOTA FINAL POR ALUNO: ");
for (int i = 0; i < 50; i++)
{
    Console.WriteLine($"O/A aluno/a {Nomes[i]} somou um TOTAL de {NotaFinal[i]} pontos.");
}
Console.WriteLine("\n");
Console.WriteLine($"A MÉDIA da turma na PROVA 1 foi: {Media1} pontos.");
Console.WriteLine("\n");
Console.WriteLine($"A MÉDIA da turma na PROVA 2 foi: {Media2} pontos.");
Console.WriteLine("\n");
Console.WriteLine($"A MÉDIA da turma na PROVA 3 foi: {Media3} pontos.");
Console.WriteLine("\n");
Console.WriteLine("ALUNOS REPROVADOS:");
for (int i = 0; i < 50; i++)
{
    if (NotaFinal[i] < 60)
    {
        Console.WriteLine($"{Nomes[i]}. \n");
    }
}
Console.ReadKey();
