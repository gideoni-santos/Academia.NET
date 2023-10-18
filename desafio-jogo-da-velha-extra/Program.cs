namespace desafio_jogo_da_velha_extra
{
    internal class Program
    {
        static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static char player = 'X';
        static char computer = 'O';

        static void Main(string[] args)
        {
            bool gameOver = false;
            Console.WriteLine("Seja bem-vindo ao Jogo da Velha!\n\n");

            // Garantir que o computador faça a primeira jogada válida
            Console.WriteLine("O computador começou jogando.");
            ComputerMove();

            while (!gameOver)
            {
                DrawBoard();
                if (player == 'X')
                {
                    Console.WriteLine($"Jogador {player}, escolha uma posição (1-9):");
                    int position;

                    while (true)
                    {
                        if (int.TryParse(Console.ReadLine(), out position))
                        {
                            if (position >= 1 && position <= 9 && board[position - 1] != 'X' && board[position - 1] != 'O')
                            {
                                board[position - 1] = player;
                                break;
                            }
                        }

                        Console.WriteLine("Jogada inválida. Escolha uma posição válida.");
                    }
                }
                else
                {
                    Console.WriteLine("Computador está pensando...");
                    ComputerMove();
                }

                gameOver = CheckForWin(player) || CheckForDraw();

                if (gameOver)
                {
                    DrawBoard();
                    if (CheckForWin(player))
                    {
                        Console.WriteLine($"Jogador {player} venceu!");
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
                        InitializeBoard();
                        gameOver = false;
                        // Garantir que o computador faça a primeira jogada válida na próxima partida
                        Console.WriteLine("O computador começou jogando.");
                        ComputerMove();
                    }
                }
                else
                {
                    player = (player == 'X') ? 'O' : 'X';
                }
            }
        }

        static void InitializeBoard()
        {
            for (int i = 0; i < 9; i++)
            {
                board[i] = (i + 1).ToString()[0];
            }
        }

        static void DrawBoard()
        {
            for (int i = 0; i < 9; i++)
            {
                if (i % 3 == 0 && i != 0)
                {
                    Console.WriteLine("\n---|---|---");
                }
                if (i % 3 == 1)
                {
                    Console.Write($" | {board[i]} |");
                }
                else
                {
                    Console.Write($" {board[i]}");
                }
            }
            Console.WriteLine("\n");
        }

        static void ComputerMove()
        {
            Random random = new Random();
            int randomPosition;
            do
            {
                randomPosition = random.Next(0, 9);
            } while (board[randomPosition] == 'X' || board[randomPosition] == 'O');

            board[randomPosition] = computer;
        }

        static bool CheckForWin(char symbol)
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[i * 3] == symbol && board[i * 3 + 1] == symbol && board[i * 3 + 2] == symbol)
                {
                    return true;
                }

                if (board[i] == symbol && board[i + 3] == symbol && board[i + 6] == symbol)
                {
                    return true;
                }
            }

            if (board[0] == symbol && board[4] == symbol && board[8] == symbol)
            {
                return true;
            }

            if (board[2] == symbol && board[4] == symbol && board[6] == symbol)
            {
                return true;
            }

            return false;
        }

        static bool CheckForDraw()
        {
            for (int i = 0; i < 9; i++)
            {
                if (board[i] != 'X' && board[i] != 'O')
                {
                    return false;
                }
            }

            return true;
        }
    }
}
