using System.Collections;
using TAD___Ex2;

Aluno x;
ArrayList Cadastro = new ArrayList();

x = new Aluno();
x.Nome = "André";
x.Mail = "andre@hotmail.com";
x.DN = new DateTime(2002, 9, 24);
x.Telefone = "31 9 9863-7569";
Cadastro.Add(x);

x = new Aluno();
x.Nome = "Isadora";
x.Mail = "isadora@gmail.com";
x.DN = new DateTime(1985,10,16);
x.Telefone = "31 9 8745-6532";
Cadastro.Add(x);

x = new Aluno();
x.Nome = "José Carlos";
x.Mail = "zecarlos@ig.com.br";
x.DN = new DateTime(1999, 12, 24);
x.Telefone = "31 9 8562-1453";
Cadastro.Add(x);

x = new Aluno();
x.Nome = "Maria José";
x.Mail = "zezelima@bol.com.br";
x.DN = new DateTime(1993, 6, 19);
x.Telefone = "31 9 9948-7448";
Cadastro.Add(x);

x = new Aluno();
x.Nome = "Tadeu";
x.Mail = "tadeutadado@yahoo.com.br";
x.DN = new DateTime(1987, 5, 24); ;
x.Telefone = "31 9 5623-8956";
Cadastro.Add(x);

foreach (Aluno A in Cadastro)
{

    Console.WriteLine($"Nome do Aluno.....: {A.Nome}");
    Console.WriteLine($"E-mail............: {A.Mail}");
    Console.WriteLine($"Data de Nascimento: {A.DN.ToString("dd/MM/yyyy")}");
    Console.WriteLine($"Telefone .........: {A.Mail}");
    Console.WriteLine("--------------------------------------\n");

}
Console.ReadKey();