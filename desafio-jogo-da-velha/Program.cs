namespace desafio_jogo_da_velha
{
    internal class Program
    {

        static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static char currentPlayer = 'X';

        static void Main(string[] args)
        {

            bool gameover = false;
            Console.WriteLine("Seja bem vindo ao Jogo da Velha!\n\n");

            while (!gameover)
            {
                DrawBoard();
                Console.WriteLine($"Jogador {currentPlayer}, escolha uma posição (1-9):");
                bool validMove = false;

                while (!validMove)
                {
                    if (int.TryParse(Console.ReadLine(), out int position))
                    {
                        if (position >= 1 && position <= 9 && board[position - 1] != 'X' && board[position - 1] != 'O')
                        {
                            board[position - 1] = currentPlayer;
                            validMove = true;
                        }
                    }

                    if (!validMove)
                    {
                        Console.WriteLine("Jogada inválida. Escolha uma posição válida.");
                    }
                }

                if (CheckForWin() || CheckForDraw())
                {
                    DrawBoard();
                    if (CheckForWin())
                    {
                        Console.WriteLine($"Jogador {currentPlayer} venceu!");
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
                    }
                    else
                    {
                        gameover = true;
                    }
                }
                else
                {
                    currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
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

        static bool CheckForWin()
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[i * 3] == currentPlayer && board[i * 3 + 1] == currentPlayer && board[i * 3 + 2] == currentPlayer)
                {
                    return true;
                }

                if (board[i] == currentPlayer && board[i + 3] == currentPlayer && board[i + 6] == currentPlayer) 
                {
                    return true;
                }
            }

            if (board[0] == currentPlayer && board[4] == currentPlayer && board[8] == currentPlayer)
            {
                return true;
            }

            if (board[2] == currentPlayer && board[4] == currentPlayer && board[6] == currentPlayer)
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