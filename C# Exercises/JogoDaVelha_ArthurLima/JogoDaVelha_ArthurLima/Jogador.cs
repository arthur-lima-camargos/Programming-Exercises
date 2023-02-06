using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha_ArthurLima
{
    internal class Jogador
    {
        public char Player { get; set; }

        // Método para criar o objeto
        public Jogador()
        {
            Player = ' ';
        }

        // Método para fazer jogada
        public Tabuleiro FazJogada(char escolha, Tabuleiro tabuleiro)
        {
            // Procura no tabuleiro o número a ser preenchido no tabuleiro...
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    // Se o conteúdo do espaço for o número escolhido...
                    if (tabuleiro.tabuleiro[i, j] == escolha)
                    {
                        tabuleiro.jogadas++; // Incrementa jogadas do tabuleiro
                        tabuleiro.tabuleiro[i, j] = tabuleiro.playerAtual.Player; // Marca com "X" ou "O" o espaço
                        
                        // Se jogadas for maior que 5 poderá haver ganhadores...
                        if(tabuleiro.jogadas >=5) 
                        {
                            // Confere se há ganhadores...
                            if (tabuleiro.Ganhou() == true)
                            {
                                break;
                            }                      
                        }
                        // Se for a vez do "X"... Troca de jogador...
                        if (tabuleiro.xVez)
                        {
                            tabuleiro.playerAtual.Player = 'O';
                            tabuleiro.xVez = false;
                        }
                        // Caso não, a vez será do "O"
                        else
                        {
                            tabuleiro.playerAtual.Player = 'X';
                            tabuleiro.xVez = true;
                        }
                    }                    
                }
            }
            // Retorna o tabuleiro...
            return tabuleiro;
        }
    }
}
