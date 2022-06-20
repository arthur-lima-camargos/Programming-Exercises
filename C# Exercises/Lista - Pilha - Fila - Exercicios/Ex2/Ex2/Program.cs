// Faça um programa que leia uma string fornecida pelo usuário via teclado e insira cada letra dessa 
// string no final de uma Lista Simplesmente Encadeada e não Ordenada. O programa deverá pedir 
// que o usuário digite uma letra e cada ocorrência dessa letra na string deverá ser retirada. Mostre o 
// conteúdo da lista nas duas etapas.  

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

    public void Retira(char x)
    {
        Elemento aux = inicio;

        Elemento Ant = null;

        while (aux != null)
        {
            if (aux.valor != x)
            {
                Ant = aux;
                aux = aux.prox;
            }
            else
            {
                if (aux == inicio)
                {
                    inicio = aux.prox;

                    aux = inicio;
                }
                else if (aux == fim)
                {
                    Ant.prox = null;

                    fim = Ant;

                    aux = null;
                }
                else
                {
                    Ant.prox = aux.prox;

                    aux = aux.prox;
                }
            }
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
        Elemento aux = new Elemento();

        Console.WriteLine("\n");

        if (inicio == null)
        {
            Console.WriteLine("Lista vazia...\n\n");

            Console.ReadKey();
        }
        else
        {
            aux = inicio;

            while (aux != null)
            {
                Console.Write($"{aux.valor,6}");

                aux = aux.prox;
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
        char opcao;
        Console.Write("Insira uma string: ");
        s = Console.ReadLine();
        char[] vet = s.ToCharArray();

        for (int i = 0; i < vet.Length; i++)
        {
            Lista.InserirFinal(vet[i]);
        }

        Lista.MostraLista();

        Console.Write("Digite um caracter para ser retirado da lista: ");
        opcao = char.Parse(Console.ReadLine());
        Lista.Retira(opcao);
        Lista.MostraLista();
    }
}