using System.Collections;
using TAD___Ex1;

Aluno x;
ArrayList Cadastro = new ArrayList();

x = new Aluno();
x.Nome = "André";
x.Mail = "andre@hotmail.com";
x.DN = "13/01/1997";
x.Telefone = "31 9 9863-7569";
Cadastro.Add(x);

x = new Aluno();
x.Nome = "Isadora";
x.Mail = "isadora@gmail.com";
x.DN = "17/03/1994";
x.Telefone = "31 9 8745-6532";
Cadastro.Add(x);

x = new Aluno();
x.Nome = "José Carlos";
x.Mail = "zecarlos@ig.com.br";
x.DN = "30/02/1980";
x.Telefone = "31 9 8562-1453";
Cadastro.Add(x);

x = new Aluno();
x.Nome = "Maria José";
x.Mail = "zezelima@bol.com.br";
x.DN = "17/01/1964";
x.Telefone = "31 9 9948-7448";
Cadastro.Add(x);

x = new Aluno();
x.Nome = "Tadeu";
x.Mail = "tadeutadado@yahoo.com.br";
x.DN = "08/08/2008";
x.Telefone = "31 9 5623-8956";
Cadastro.Add(x);

//foreach (Aluno A in Cadastro)
//{
//    Console.WriteLine(A.ToString());
//    Console.WriteLine($"Nome do Aluno.....: {A.Nome}");
//    Console.WriteLine($"E-mail............: {A.Mail}");
//    Console.WriteLine($"Data de Nascimento: {A.DN}");
//    Console.WriteLine($"Telefone .........: {A.Mail}");

//}

foreach (Aluno A in Cadastro)
{

    Console.WriteLine($"Nome do Aluno.....: {A.Nome}");
    Console.WriteLine($"E-mail............: {A.Mail}");
    Console.WriteLine($"Data de Nascimento: {A.DN}");
    Console.WriteLine($"Telefone .........: {A.Mail}\n");

}
Console.ReadKey();