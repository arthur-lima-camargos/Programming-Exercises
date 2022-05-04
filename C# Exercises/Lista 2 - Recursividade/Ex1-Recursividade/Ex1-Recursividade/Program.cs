//Faça uma função recursiva capaz de imprimir em tela a soma dos elementos de um vetor de 20 posições 
//composto de números aleatórios

int[] Vet = new int[20];
Random x = new Random();
int soma = 0;
int i = 0;

Console.WriteLine("Faça uma função recursiva capaz de imprimir em tela a soma dos elementos de um vetor de 20 posições composto de números aleatórios");

MostraComRecursividade(Vet, soma, i, x);
Console.ReadKey();

static void MostraComRecursividade(int[] V, int s, int i, Random x)
{
    if (i < 20)
    {
        
        V[i] = x.Next(1, 51);
        s = s + V[i];
        Console.WriteLine("===================================");
        Console.Write($"Valor do Vetor[{i}] = {V[i],5} \n");
        Console.Write($"Soma dos elementos do Vetor = {s}\n");
        Console.WriteLine("===================================\n");
        i++;
        MostraComRecursividade(V, s, i, x);
    }
}

