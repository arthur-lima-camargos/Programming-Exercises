using JogoDaVelha_ArthurLima;
using System.Numerics;
using System.Text;

int opc = 9;
while (opc != 3)
{
    // Menu do Jogo
    Console.WriteLine("###############################################");
    Console.WriteLine("################ JOGO DA VELHA ################");
    Console.WriteLine("###############################################\n");
    Console.WriteLine("      Programado por Arthur Lima Camargos\n");
    Console.WriteLine("==================    MENU    =================");
    Console.WriteLine("Digite '1' - Jogador 1 x Jogador 2");
    Console.WriteLine("Digite '2' - Máquina x Máquina");
    Console.WriteLine("Digite '3' - Sair do Jogo");
    Console.Write("ESCOLHA UMA OPÇÃO: ");

    // Escolhe opção (somente inteiros 1, 2 e 3)
    while (int.TryParse(Console.ReadLine(), out opc) == false || opc < 1 || opc > 3)
    {
        Console.WriteLine("Valor inválido!"); 
        Console.Write("Informe uma opção válida (1 ou 2 ou 3): ");
    }
    // Opção 1
    if (opc == 1)
    {
        // Instancia "PlayerXPlayer" da classe "Tabuleiro"

        Tabuleiro PlayerXPlayer = new Tabuleiro();

        while (!PlayerXPlayer.venceu) 
        {
            int escolha;
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Vez do jogador: {PlayerXPlayer.playerAtual.Player}");

                // Mostra a matriz/tabuleiro do jogo...
                PlayerXPlayer.ImprimeTabuleiro();

                Console.Write("Digite a posição que deseja marcar: ");

                // Escolhe opção (somente inteiros entre o intervalo 1 a 9, ou opções válidas)
                while (int.TryParse(Console.ReadLine(), out escolha) == false || escolha < 1 || escolha > 9)
                {
                    Console.WriteLine("Valor inválido!");
                    Console.Write("Informe uma opção válida (1 a 9): ");
                }
               
                char escolheEspaço = Convert.ToChar(escolha.ToString());  // escolheEspaço corresponde ao número escolhido
                bool espacoValido = false; 

                // Se o conteúdo procurado na matriz for igual ao número escolhido o espaço será válido...
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (PlayerXPlayer.tabuleiro[i, j] == escolheEspaço)
                        {
                            espacoValido = true;
                            break;
                        }
                    }
                }

                // Se válido, propriedade do tipo "Jogador" chama função que faz a jogada.
                if (espacoValido == true)
                {
                    // Como parâmetros da função temos o número/espaço escolhido e instância do tipo "Tabuleiro"
                    PlayerXPlayer.playerAtual.FazJogada(escolheEspaço, PlayerXPlayer);
                }

                // Se o espaço não é válido é porque já está ocupado...
                else
                {
                    Console.WriteLine("ESPAÇO OCUPADO!!!");
                    Console.WriteLine("Aperte qualquer tecla para tentar novamente...");
                    Console.ReadKey();
                }
                break;
            }

            // Se todos os espaços foram utilizados e ninguém venceu... Resultado = velha(empate)
            if (PlayerXPlayer.jogadas == 9 && !PlayerXPlayer.venceu)
            {
                Console.Clear();
                Console.WriteLine("RESULTADO DO JOGO:");
                PlayerXPlayer.ImprimeTabuleiro();
                Console.WriteLine("VELHA! Nenhum jogador venceu...");
                PlayerXPlayer.venceu = true;
                Console.WriteLine("\n");
            }
            // Se alguém ganhou... Vitória para Jogador X ou O...
            if (PlayerXPlayer.Ganhou())
            {
                Console.Clear();
                Console.WriteLine("RESULTADO DO JOGO:");
                PlayerXPlayer.ImprimeTabuleiro();
                Console.WriteLine($"VITÓRIA do jogador '{PlayerXPlayer.playerAtual.Player}', parabéns!");
                Console.WriteLine("\n");
                PlayerXPlayer.venceu = true;
            }
        }
    }
    // Se opção 2
    if (opc == 2)
    {
        // Instancia "MáquinaXMáquina" da classe "Tabuleiro"
        Tabuleiro MaquinaXMaquina = new Tabuleiro();

        // Repete o processo de forma semelhante ao modo "PlayerXPlayer", porém, com menos linhas...
        while (!MaquinaXMaquina.venceu)
        {
            int escolha;
            while (true)
            {
                Console.WriteLine($"Vez do jogador: {MaquinaXMaquina.playerAtual.Player}");
                MaquinaXMaquina.ImprimeTabuleiro();

                // Com objeto da classe "Random" o sistema irá gerar números aleatórios
                Random geradorDeTentativa = new Random();

                // Guarda um número entre 1 e 9...
                escolha = geradorDeTentativa.Next(1, 10);

                // Esse número indica o espaço no tabuleiro/matriz...
                char escolheEspaço = Convert.ToChar(escolha.ToString());
                bool espacoValido = false;

                // Confere se o valor é válido...
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (MaquinaXMaquina.tabuleiro[i, j] == escolheEspaço)
                        {
                            espacoValido = true;
                            break;
                        }
                    }
                }

                // Se válido chama a função de fazer jogadas...
                if (espacoValido == true)
                {
                    MaquinaXMaquina.playerAtual.FazJogada(escolheEspaço, MaquinaXMaquina);
                }
                break;
            }

            // Imprime Resultado = EMPATE/VELHA
            if (MaquinaXMaquina.jogadas == 9 && !MaquinaXMaquina.venceu)
            {
                Console.Clear();
                Console.WriteLine("RESULTADO DO JOGO:\n");
                MaquinaXMaquina.ImprimeTabuleiro();
                Console.WriteLine("VELHA! Nenhum jogador venceu...");
                MaquinaXMaquina.venceu = true;
                Console.WriteLine("\n");
            }

            // Imprime Resultado = Alguém ganhou...
            if (MaquinaXMaquina.Ganhou())
            {
                Console.Clear();
                Console.WriteLine("RESULTADO DO JOGO:\n");
                MaquinaXMaquina.ImprimeTabuleiro();
                Console.WriteLine($"VITÓRIA do jogador '{MaquinaXMaquina.playerAtual.Player}', parabéns!");
                Console.WriteLine("\n");
                MaquinaXMaquina.venceu = true;
            }
        }
    }

    // Se opção 3, sai do jogo...
    if (opc == 3)
    {
        Console.WriteLine("Saindo do programa...");
    }
}

