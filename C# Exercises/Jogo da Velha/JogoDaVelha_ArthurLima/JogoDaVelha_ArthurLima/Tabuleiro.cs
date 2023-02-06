using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha_ArthurLima
{
    internal class Tabuleiro
    {
        public bool venceu { get; set; }
        public char[,] tabuleiro{ get; set; }
        public Jogador playerAtual { get; set; }
        public bool xVez { get; set; }
        public int jogadas { get; set; }

        public Tabuleiro() 
        {
            tabuleiro = new char[3, 3];
            venceu = false;
            jogadas = 0;
            playerAtual = new Jogador();
            playerAtual.Player = 'X';
            xVez = true;
        }

        // Método que gera a Matriz
        public void CriaTabuleiro()
        {
            tabuleiro[0, 0] = '7';
            tabuleiro[0, 1] = '8';
            tabuleiro[0, 2] = '9';
            tabuleiro[1, 0] = '4';
            tabuleiro[1, 1] = '5';
            tabuleiro[1, 2] = '6';
            tabuleiro[2, 0] = '1';
            tabuleiro[2, 1] = '2';
            tabuleiro[2, 2] = '3';
        }

        // Método para imprimir o Jogo da Velha
        public void ImprimeTabuleiro() 
        {
            if (jogadas == 0)
            {
                CriaTabuleiro();
            }

            Console.WriteLine("\n     |     |   ");
            Console.WriteLine($"  {tabuleiro[0,0]}  |  {tabuleiro[0, 1]}  |  {tabuleiro[0, 2]}");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |");
            Console.WriteLine($"  {tabuleiro[1, 0]}  |  {tabuleiro[1, 1]}  |  {tabuleiro[1, 2]}");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |");
            Console.WriteLine($"  {tabuleiro[2, 0]}  |  {tabuleiro[2, 1]}  |  {tabuleiro[2, 2]}");
            Console.WriteLine("     |     |   \n");
        }

        // Método que verifica se X ou O ganhou o jogo
        public bool Ganhou()
        {
            // Verificação de linhas
            if ((tabuleiro[0, 0] == tabuleiro[0, 1] && tabuleiro[0, 1] == tabuleiro[0, 2]) ||
                (tabuleiro[1, 0] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[1, 2]) ||
                (tabuleiro[2, 0] == tabuleiro[2, 1] && tabuleiro[2, 1] == tabuleiro[2, 2]))
            {
                return true;
            }

            // Verificação de colunas
            if ((tabuleiro[0, 0] == tabuleiro[1, 0] && tabuleiro[1, 0] == tabuleiro[2, 0]) ||
                (tabuleiro[0, 1] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 1]) ||
                (tabuleiro[0, 2] == tabuleiro[1, 2] && tabuleiro[1, 2] == tabuleiro[2, 2]))
            {
                return true;
            }

            // Verificação de diagonais
            if ((tabuleiro[0, 0] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 2]) ||
                (tabuleiro[2, 0] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[0, 2]))
            {
                return true;
            }
            // Retorna false caso não tenha um ganhador...
            return false;
        }
    }
}

