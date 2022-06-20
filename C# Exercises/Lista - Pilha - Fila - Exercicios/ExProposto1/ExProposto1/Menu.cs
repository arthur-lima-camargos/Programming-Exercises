using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExProposto1
{
    internal class Menu
    {
        Lista MinhaLista = new Lista();
        private string CódPesq;

        private Operações MinhaOperação;

        public Menu(Operações O)
        {
            this.MinhaOperação = O;
        }

        public void MostraMenu()
        {
            int Opção;

            do
            {
                Console.Clear();

                Console.WriteLine("Sistema de Cadastro de Alunos");
                Console.WriteLine("=============================\n");

                Console.WriteLine("1 - Inserir Prof.");
                Console.WriteLine("2 - Listar Professores");
                Console.WriteLine("3 - Excluir Prof.");
                Console.WriteLine("4 - Esvaziar Lista");
                Console.WriteLine("5 - Procurar Prof.");
                Console.WriteLine("6 - Sair");

                Console.Write("\nOpção: ");
                Opção = int.Parse(Console.ReadLine());

                switch (Opção)
                {
                    case 1:
                        do
                        {
                            Console.Clear();

                            Console.WriteLine("Cadastro de Professor");
                            Console.WriteLine("=================\n");

                            MinhaOperação.Inserir(MinhaLista);

                            Console.WriteLine("\nInserir outro registro? (ESC cancela...)");

                        } while (Console.ReadKey().Key != ConsoleKey.Escape);

                        break;
                    case 2:
                        Console.Clear();

                        Console.WriteLine("Listagem Geral do Cadastro de Professores");
                        Console.WriteLine("====================================\n");

                        MinhaOperação.Listar(MinhaLista);

                        break;
                    case 3:
                        Console.Clear();

                        Console.WriteLine("Exclusão de Professor do Cadastro");
                        Console.WriteLine("=============================\n");

                        Console.Write("Código do Professor: ");
                        CódPesq = Console.ReadLine();

                        MinhaOperação.Excluir(CódPesq, MinhaLista);

                        break;
                    case 4:
                        Console.WriteLine("Esvaziar Lista");
                        Console.WriteLine("==============\n");
                        MinhaOperação.EsvaziarLista(MinhaLista);
                        break;
                    case 5:
                        Console.Clear();

                        Console.WriteLine("Pesquisa no Cadastro de Professores");
                        Console.WriteLine("===================================\n");

                        Console.Write("Código do Professor: ");
                        CódPesq = Console.ReadLine();

                        MinhaOperação.Pesquisar(CódPesq, MinhaLista);

                        break;
                    case 6:
                        Console.Write("\nSaindo do Sistema...");
                        Thread.Sleep(2000);
                        break;
                    default:
                        Console.Write("\nOpção Inválida!!");
                        Thread.Sleep(2000);

                        break;                    
                }

            } while (Opção != 6);
        }
    }
}

