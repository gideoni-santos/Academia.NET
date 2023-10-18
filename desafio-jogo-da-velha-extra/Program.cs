namespace desafio_jogo_da_velha_extra
{
    internal class Program
    {
        static char[] tabuleiro = { '1', '2', '3', '4', '5', '6', '7', '8', '9' }; //Array de 1 a 9 que representa as posições do jogo
        static char jogador = 'X'; //O jogador jogará com o "X"
        static char computador = 'O'; //O computador jogará com "O"

        static void Main(string[] args)
        {
            bool gameOver = false; //vai verificar se o jogo terminou ou não
            Console.WriteLine("Seja bem-vindo ao Jogo da Velha!\n\n");

            Console.WriteLine("O computador começou jogando.");
            computadorMove();

            while (!gameOver)
            {
                desenhatabuleiro();
                if (jogador == 'X')
                {
                    Console.WriteLine($"Jogador {jogador}, escolha uma posição (1-9):");
                    int position;

                    while (true)
                    {
                        if (int.TryParse(Console.ReadLine(), out position))
                        {
                            if (position >= 1 && position <= 9 && tabuleiro[position - 1] != 'X' && tabuleiro[position - 1] != 'O')
                            {
                                tabuleiro[position - 1] = jogador;
                                break;
                            }
                        }

                        Console.WriteLine("Jogada inválida. Escolha uma posição válida.");
                    }
                }
                else
                {
                    Console.WriteLine("Computador está pensando...");
                    computadorMove();
                }

                gameOver = checaSeGanhou(jogador) || checaSeEmpatou();

                if (gameOver)
                {
                    desenhatabuleiro();
                    if (checaSeGanhou(jogador))
                    {
                        Console.WriteLine($"Jogador {jogador} venceu!");
                    }
                    else
                    {
                        Console.WriteLine("Empate!");
                    }

                    Console.WriteLine("Deseja jogar novamente? (S/N)");
                    char playAgain = Console.ReadKey().KeyChar;
                    if (playAgain == 'S' || playAgain == 's')
                    {
                        Console.WriteLine("\n");
                        iniciatabuleiro();
                        gameOver = false;
                        
                        Console.WriteLine("O computador começou jogando.");
                        computadorMove();
                    }
                }
                else
                {
                    jogador = (jogador == 'X') ? 'O' : 'X';
                }
            }
        }

        static void iniciatabuleiro()
        {
            for (int i = 0; i < 9; i++)
            {
                tabuleiro[i] = (i + 1).ToString()[0];
            }
        }

        static void desenhatabuleiro()
        {
            for (int i = 0; i < 9; i++)
            {
                if (i % 3 == 0 && i != 0)
                {
                    Console.WriteLine("\n---|---|---");
                }
                if (i % 3 == 1)
                {
                    Console.Write($" | {tabuleiro[i]} |");
                }
                else
                {
                    Console.Write($" {tabuleiro[i]}");
                }
            }
            Console.WriteLine("\n");
        }

        static void computadorMove() //Faz com que o computador escolha uma posição alea´ptoria no tabuleiro
        {
            Random random = new Random();
            int randomPosition;
            do
            {
                randomPosition = random.Next(0, 9);
            } while (tabuleiro[randomPosition] == 'X' || tabuleiro[randomPosition] == 'O');

            tabuleiro[randomPosition] = computador;
        }

        static bool checaSeGanhou(char symbol) //Verifica se há 3 X ou 3 O, em uma linha vertical ou horizontal
        {
            for (int i = 0; i < 3; i++)
            {
                if (tabuleiro[i * 3] == symbol && tabuleiro[i * 3 + 1] == symbol && tabuleiro[i * 3 + 2] == symbol)
                {
                    return true;
                }

                if (tabuleiro[i] == symbol && tabuleiro[i + 3] == symbol && tabuleiro[i + 6] == symbol)
                {
                    return true;
                }
            }

            if (tabuleiro[0] == symbol && tabuleiro[4] == symbol && tabuleiro[8] == symbol)
            {
                return true;
            }

            if (tabuleiro[2] == symbol && tabuleiro[4] == symbol && tabuleiro[6] == symbol)
            {
                return true;
            }

            return false; //se nenhuma condição for vdd retorna false
        }

        static bool checaSeEmpatou()
        {
            for (int i = 0; i < 9; i++)
            {
                if (tabuleiro[i] != 'X' && tabuleiro[i] != 'O') //Verifica se tem alguma posição não preenchida com X ou O
                {
                    return false; // Se tiver posição vazia o jogo nao é um empate.
                }
            }

            return true; //Se todas as posições estiverem preenchidas, o jogo é um empate.
        }
    }
}
