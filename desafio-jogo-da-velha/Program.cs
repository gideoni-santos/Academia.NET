namespace desafio_jogo_da_velha
{
    internal class Program
    {

        static char[] tabuleiro = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static char jogador = 'X';

        static void Main(string[] args)
        {

            bool gameOver = false; //vai verificar se o jogo terminou ou não
            Console.WriteLine("Seja bem vindo ao Jogo da Velha!\n\n");

            while (!gameOver)
            {
                desenhatabuleiro();
                Console.WriteLine($"Jogador {jogador}, escolha uma posição (1-9):");
                bool jogadaValida = false;

                while (!jogadaValida)
                {
                    if (int.TryParse(Console.ReadLine(), out int position)) //verifica se pode ser convertido para numero inteiro
                    {
                        if (position >= 1 && position <= 9 && tabuleiro[position - 1] != 'X' && tabuleiro[position - 1] != 'O')
                        {
                            tabuleiro[position - 1] = jogador;
                            jogadaValida = true;
                        }
                    }

                    if (!jogadaValida)
                    {
                        Console.WriteLine("Jogada inválida. Escolha uma posição válida.");
                    }
                }

                if (checaSeGanhou() || checaSeEmpatou()) // verifica se o jogo terminou em empate ou vitoria
                {
                    desenhatabuleiro();
                    if (checaSeGanhou())
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
                    }
                    else
                    {
                        gameOver = true;
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

        static bool checaSeGanhou() //Verifica se há 3 X ou 3 O, em uma linha vertical ou horizontal
        {
            for (int i = 0; i < 3; i++)
            {
                if (tabuleiro[i * 3] == jogador && tabuleiro[i * 3 + 1] == jogador && tabuleiro[i * 3 + 2] == jogador)
                {
                    return true;
                }

                if (tabuleiro[i] == jogador && tabuleiro[i + 3] == jogador && tabuleiro[i + 6] == jogador) 
                {
                    return true;
                }
            }

            if (tabuleiro[0] == jogador && tabuleiro[4] == jogador && tabuleiro[8] == jogador)
            {
                return true;
            }

            if (tabuleiro[2] == jogador && tabuleiro[4] == jogador && tabuleiro[6] == jogador)
            {
                return true;
            }

            return false;
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