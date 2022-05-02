int[] Aluno = new int[20];
int[] P1 = new int[20];
int[] P2 = new int[20];
int[] P3 = new int[20];
int[] Total = new int[20];
double MediaP1 = 0, MediaP2 = 0, MediaP3 = 0;
Random x = new Random();

for (int i = 0; i < 20; i++)
{
    P1[i] = x.Next(1, 11);
    P2[i] = x.Next(1, 11);
    P3[i] = x.Next(1, 11);
    Total[i] += P1[i] + P2[i] + P3[i];
    MediaP1 += P1[i];
    MediaP2 += P2[i];
    MediaP3 += P3[i];
}

MediaP1 = MediaP1 / 20;
MediaP2 = MediaP2 / 20;
MediaP3 = MediaP3 / 20;

for (int i = 0; i < 20; i++)
{
    Console.WriteLine($"O Aluno nº{i+1} somou {Total[i]} nas três provas");
}
Console.Write("\n");
Console.WriteLine($"Média da turma na Prova 1 = {MediaP1}");
Console.Write("\n");
Console.WriteLine($"Média da turma na Prova 2 = {MediaP2}");
Console.Write("\n");
Console.WriteLine($"Média da turma na Prova 3 = {MediaP3}");
Console.ReadKey();