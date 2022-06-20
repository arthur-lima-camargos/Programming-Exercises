// Faça  um  programa  que  leia  do  teclado  uma  string  qualquer.  Crie  uma  Lista  Simplesmente 
// Encadeada e não Ordenada que insira cada letra dessa string no inicio dessa lista ou no final, 
// dependendo da opção do usuário.  
using System;

class Elemento
{
    public char valor = '\0';
    public Elemento prox;

    public Elemento()
    {
        valor = char.MinValue;
        prox = null;
    }
}

class Lista
{
    public Elemento inicio;
    public Elemento fim;

    public void Inseririnicio(char x)
    {
        Elemento Novo = new Elemento();

        Novo.valor = x;

        if (inicio == null)
        {
            inicio = Novo;
            fim = Novo;
        }
        else
        {
            Novo.prox = inicio;

            inicio = Novo;
        }
    }

    public void InserirFinal(char x)
    {
        Elemento Novo = new Elemento();

        Novo.valor = x;

        if (inicio == null)
        {
            inicio = Novo;
            fim = Novo;
        }
        else
        {
            fim.prox = Novo;

            fim = Novo;
        }
    }

    public void MostraLista()
    {
        Elemento Aux = new Elemento();

        Console.WriteLine("\n");

        if (inicio == null)
        {
            Console.WriteLine("Lista vazia...\n\n");

            Console.ReadKey();
        }
        else
        {
            Aux = inicio;

            while (Aux != null)
            {
                Console.Write($"{Aux.valor,6}");

                Aux = Aux.prox;
            }

            Console.ReadKey();
        }
    }
}

class Ex2
{
    static void Main()
    {
        Lista Lista = new Lista();
        string s;
        int opcao;
        Console.Write("Insira uma string: ");
        s = Console.ReadLine();
        char[] vet = s.ToCharArray();
        Console.Write("Opção 1 - Inserir no inicio da lista\n");
        Console.Write("Opção 2 - Inserir no FINAL da lista\n");
        Console.Write("Digite a opção: ");
        opcao = int.Parse(Console.ReadLine());
        if (opcao == 1)
        {
            for (int i = 0; i < vet.Length; i++)
            {
                Lista.Inseririnicio(vet[i]);
            }
        }
        else
        {
            for (int i = 0; i < vet.Length; i++)
            {
                Lista.InserirFinal(vet[i]);
            }
        }

        Lista.MostraLista();
    }
}