using System.Collections;
using TAD___Ex4;

Filme x;
string Cat;

ArrayList Filmes = new ArrayList();

x = new Filme();
x.Nome = "Furia Implacável";
x.Duracao = 120;
x.Diretor = "Steve Jobs";
x.Categoria = "Ação";
x.Ano = 2000;
Filmes.Add(x);

x = new Filme();
x.Nome = "Bolsonaro Miliciano";
x.Duracao = 666;
x.Diretor = "Carluxo 03";
x.Categoria = "Terror";
x.Ano = 2018;
Filmes.Add(x);

x = new Filme();
x.Nome = "Star Wars 3";
x.Duracao = 132;
x.Diretor = "George Lucas";
x.Categoria = "Fantasia";
x.Ano = 2002;
Filmes.Add(x);

x = new Filme();
x.Nome = "Gênio Indomável";
x.Duracao = 128;
x.Diretor = "Seu Jorge";
x.Categoria = "Drama";
x.Ano = 1998;
Filmes.Add(x);

x = new Filme();
x.Nome = "Os Trapalhões";
x.Duracao = 90;
x.Diretor = "Didi Mocó";
x.Categoria = "Humor";
x.Ano = 1990;
Filmes.Add(x);

Console.WriteLine("Filmes Cadastrados:\n");
foreach (Filme F in Filmes)
{
    Console.WriteLine($"Nome do filme.....: {F.Nome}");
    Console.WriteLine($"Duração do filme..: {F.Duracao} min");
    Console.WriteLine($"Diretor do filme..: {F.Diretor}");
    Console.WriteLine($"Categoria do filme: {F.Categoria}");
    Console.WriteLine($"Ano do filme......: {F.Ano}\n");
}

Console.ReadKey();
Console.Clear();
Console.Write("Digite a CATEGORIA que quer procurar: ");
Cat = Console.ReadLine();
Console.Write("\n");

foreach (Filme F in Filmes)
{
    if (Cat == F.Categoria)
    {
        Console.WriteLine($"Nome do filme.....: {F.Nome}");
        Console.WriteLine($"Duração do filme..: {F.Duracao} min");
        Console.WriteLine($"Diretor do filme..: {F.Diretor}");
        Console.WriteLine($"Categoria do filme: {F.Categoria}");
        Console.WriteLine($"Ano do filme......: {F.Ano}\n");
    }    
}
