using System.Collections;
using TAD___Ex3;

Aluno x;

Aluno[] ListaAluno = new Aluno[50];

x = new Aluno();
x.Nome = "André";
x.Mail = "andre@hotmail.com";
x.DN = new DateTime(1997, 1, 13);
x.Telefone = "31 9 9863-7569";
ListaAluno[0] = x;

x = new Aluno();
x.Nome = "Isadora";
x.Mail = "isadora@gmail.com";
x.DN = new DateTime(1994, 3, 17);
x.Telefone = "31 9 8745-6532";
ListaAluno[1] = x;

x = new Aluno();
x.Nome = "José Carlos";
x.Mail = "zecarlos@ig.com.br";
x.DN = new DateTime(1980, 2, 28);
x.Telefone = "31 9 8562-1453";
ListaAluno[2] = x;

x = new Aluno();
x.Nome = "Maria José";
x.Mail = "zezelima@bol.com.br";
x.DN = new DateTime(1964, 1, 17);
x.Telefone = "31 9 9948-7448";
ListaAluno[3] = x;

x = new Aluno("Tadeu", "tadeutadado@yahoo.com.br", new DateTime(2008, 8, 8), "31 9 5623-8956");
ListaAluno[4] = x;

ImprimeArray(ListaAluno);
Console.ReadKey();


static void ImprimeArray(Aluno[] listaAluno) 
{
    foreach (Aluno A in listaAluno)
    {
        if (A != null)
        {
            Console.WriteLine($"Nome do Aluno.....: {A.Nome}");
            Console.WriteLine($"E-mail............: {A.Mail}");
            Console.WriteLine($"Data de Nascimento: {A.DN.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Telefone .........: {A.Mail}\n");
        }
    }
}