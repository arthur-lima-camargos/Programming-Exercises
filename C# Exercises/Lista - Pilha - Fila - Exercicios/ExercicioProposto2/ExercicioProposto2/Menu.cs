using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProposto2
{
    public class Menu
    {
        Queue<int> Fila = new Queue<int>();
        int ContSenha = 0;
        Operações MinhaOperação = new Operações();
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

                Console.WriteLine("Sistema de Atendimento por FILA");
                Console.WriteLine("=============================\n");

                Console.WriteLine("1 - Retirar Senha");
                Console.WriteLine("2 - Atender Próxima Senha");
                Console.WriteLine("3 - Listagem da Fila");
                Console.WriteLine("4 - Sair");

                Console.Write("\nOpção: ");
                Opção = int.Parse(Console.ReadLine());

                switch (Opção)
                {
                    case 1:
                        do
                        {
                            Console.Clear();

                            Console.WriteLine("Retira Senha");
                            Console.WriteLine("============\n");

                            MinhaOperação.RetiraSenha(ContSenha++, Fila);

                            Console.WriteLine("\nRetirar outra senha? (ESC cancela...)");

                        } while (Console.ReadKey().Key != ConsoleKey.Escape);                      
                        break;
                    case 2:
                        Console.Clear();

                        Console.WriteLine("Atender Próxima Senha:");
                        Console.WriteLine("====================\n");
                        MinhaOperação.AtendeSenha(Fila);
                        break;
                    case 3:
                        Console.Write("\n");
                        foreach (int senha in Fila)
                        {
                            Console.Write(senha);
                            Console.Write("    ");
                        }
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Write("\nSaindo do Sistema...");
                        Thread.Sleep(2000);
                        break;
                    default:
                        Console.Write("\nOpção Inválida!!");
                        Thread.Sleep(2000);

                        break;
                }

            } while (Opção != 4);
        }
    }
}

