// Faça um programa que cadastre em uma Lista Simplesmente Encadeada e Ordenada 10 números 
// sorteados aleatoriamente. Mostre o conteúdo da lista ao final. 

class Elemento
{
    public int Valor;
    public Elemento Próx;

    public Elemento()
    {
        Valor = 0;
        Próx = null;
    }

    public Elemento(int x)
    {
        Valor = x;
        Próx = null;
    }
}

class Lista
{
    public Elemento Início;
    public Elemento Fim;

    public Lista()
    {
        Início = null;
        Fim = null;
    }
    public int Tam()
    {
        Elemento E = Início;
        int Cont = 0;
        while (E != Fim)
        {
            E = E.Próx;
            Cont++;
        }
        return Cont;
    }

    public void InserirOrdenado(Elemento elemento)
    {
        Elemento atual;

        if (Início == null || Início.Valor >= elemento.Valor)
        {
            elemento.Próx = Início;
            Início = elemento;
        }
        else
        {
            atual = Início;

            while (atual.Próx != null && atual.Próx.Valor < elemento.Valor)
                atual = atual.Próx;

            elemento.Próx = atual.Próx;
            atual.Próx = elemento;
        }
    }

    public void MostraLista()
    {
        Elemento Aux = new Elemento();

        Console.WriteLine("\n");

        if (Início == null)
        {
            Console.WriteLine("Lista vazia...\n\n");

            Console.ReadKey();
        }
        else
        {
            Aux = Início;

            while (Aux != null)
            {
                Console.Write($"{Aux.Valor,6}");

                Aux = Aux.Próx;
            }

            Console.ReadKey();
        }
    }
}

class Program
{
    static void Main()
    {
        Lista Lista = new Lista();
        Random x = new Random();
        for (int i = 0; i < 10; i++)
        {
            Lista.InserirOrdenado(new Elemento(x.Next(1, 51)));
        }

        Lista.MostraLista();
    }
}