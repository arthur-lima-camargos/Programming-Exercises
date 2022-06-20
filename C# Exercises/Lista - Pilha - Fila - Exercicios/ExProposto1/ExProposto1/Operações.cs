using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExProposto1
{
    internal class Operações
    {
        public void Inserir(Lista X)
        {
            Professor Novo = new Professor();

            Console.Write("Nome do Professor: ");
            Novo.Nome = Console.ReadLine();

            Console.Write("Telefone.........: ");
            Novo.Telefone = Console.ReadLine();

            Console.Write("Mail.............: ");
            Novo.Mail = Console.ReadLine();

            if (X.Início == null)
            {
                X.Início = Novo;
                X.Fim = Novo;
            }
            else
            {
                Novo.Próx = X.Início;

                X.Início = Novo;
            }
        }

        public void Listar(Lista X)
        {
            Professor Aux = new Professor();

            if (X.Início == null)
            {
                Console.WriteLine("Lista vazia...\n\n");

                Console.ReadKey();
            }
            else
            {
                Aux = X.Início;

                while (Aux != null)
                {
                    Console.Write($"Nome: {Aux.Nome}\n");
                    Console.Write($"Matrícula: {Aux.Código}\n");
                    Console.Write($"Telefone: {Aux.Telefone}\n");
                    Console.Write($"E-Mail: {Aux.Mail}\n");
                    Console.WriteLine("\n");

                    Aux = Aux.Próx;
                }

                Console.ReadKey();
            }
        }

        public void Excluir(string CódPesq, Lista X)
        {
            Professor Aux = X.Início;
            Professor Ant = null;

            while (Aux != null)
            {
                if (Aux.Código != CódPesq)
                {
                    Ant = Aux;
                    Aux = Aux.Próx;
                }
                else
                {
                    if (Aux == X.Início)
                    {
                        X.Início = Aux.Próx;

                        Aux = X.Início;
                    }
                    else if (Aux == X.Fim)
                    {
                        Ant.Próx = null;

                        X.Fim = Ant;

                        Aux = null;
                    }
                    else
                    {
                        Ant.Próx = Aux.Próx;

                        Aux = Aux.Próx;
                    }
                }
            }
        }

        public void EsvaziarLista(Lista X)
        {
            X.Início = null;
            X.Fim = null;
        }

        public void Pesquisar(string CódPesq, Lista X)
        {
            Professor Aux = X.Início;
            int Cont = 0;
            
            while (Aux != null)
            {
                if (Aux.Código != CódPesq)
                {
                    Aux = Aux.Próx;
                }
                else
                {
                    Cont++;
                    Console.WriteLine("Professor ENCONTRADO!!!");
                    Console.WriteLine("");
                    Console.Write($"Nome: {Aux.Nome}\n");
                    Console.Write($"Matrícula: {Aux.Código}\n");
                    Console.Write($"Telefone: {Aux.Telefone}\n");
                    Console.Write($"E-Mail: {Aux.Mail}\n");
                    Console.WriteLine("\n");
                    Aux = Aux.Próx;
                }
            }
            if (Cont == 0)
            {
                Console.WriteLine("Professor NÃO ENCONTRADO!");
            }

            Console.ReadKey();
        }
    }
}
