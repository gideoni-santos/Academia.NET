using System.Net;

namespace exerciciosVetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////1.Escreva um algoritmo que leia os valores para um vetor de 10 elementos e então mostre na tela a quantidade de números pares e ímpares.

            //int[] vetor = new int[10];
            //int pares = 0;
            //int impares = 0;

            //// Leitura dos valores para o vetor
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write($"Digite o {i + 1}º número: ");
            //    vetor[i] = int.Parse(Console.ReadLine());
            //}

            //// Contagem de números pares e ímpares
            //foreach (int numero in vetor)
            //{
            //    if (numero % 2 == 0)
            //    {
            //        pares++;
            //    }
            //    else
            //    {
            //        impares++;
            //    }
            //}

            //// Exibição dos resultados
            //Console.WriteLine($"Quantidade de números pares: {pares}");
            //Console.WriteLine($"Quantidade de números ímpares: {impares}");

            //Console.ReadLine();

            //------------------------------------------------------------------------------------------------------

            //2.Escreva um algoritmo que leia valores para dois vetores de 20 elementos e então realize a soma dos elementos da mesma posição, armazenando o resultado em um outro vetor.

            //int tamanho = 20;
            //int[] vetor1 = new int[tamanho];
            //int[] vetor2 = new int[tamanho];
            //int[] vetorSoma = new int[tamanho];

            //// Leitura dos valores para o primeiro vetor
            //Console.WriteLine("Digite os valores para o primeiro vetor:");
            //for (int i = 0; i < tamanho; i++)
            //{
            //    Console.Write($"Digite o {i + 1}º valor: ");
            //    vetor1[i] = int.Parse(Console.ReadLine());
            //}

            //// Leitura dos valores para o segundo vetor
            //Console.WriteLine("\nDigite os valores para o segundo vetor:");
            //for (int i = 0; i < tamanho; i++)
            //{
            //    Console.Write($"Digite o {i + 1}º valor: ");
            //    vetor2[i] = int.Parse(Console.ReadLine());
            //}

            //// Realiza a soma e armazena no vetor de soma
            //for (int i = 0; i < tamanho; i++)
            //{
            //    vetorSoma[i] = vetor1[i] + vetor2[i];
            //}

            //// Exibição do vetor de soma
            //Console.WriteLine("\nResultado da soma dos vetores:");
            //for (int i = 0; i < tamanho; i++)
            //{
            //    Console.WriteLine($"Soma na posição {i}: {vetorSoma[i]}");
            //}

            //Console.ReadLine();

            //------------------------------------------------------------------------------------------------------


            //3.Escreva um algoritmo que leia os valores para um vetor de 20 elementos e então mostre na tela o índice da posição dos valores correspondentes a números primos.

            //int tamanho = 20;
            //int[] vetor = new int[tamanho];

            //// Leitura dos valores para o vetor
            //for (int i = 0; i < tamanho; i++)
            //{
            //    Console.Write($"Digite o valor para a posição {i + 1}: ");
            //    vetor[i] = int.Parse(Console.ReadLine());
            //}

            //// Encontra e exibe os índices das posições com números primos
            //Console.WriteLine("\nÍndices das posições com números primos:");
            //for (int i = 0; i < tamanho; i++)
            //{
            //    bool ehPrimo = true;
            //    if (vetor[i] <= 1)
            //    {
            //        ehPrimo = false;
            //    }
            //    else
            //    {
            //        for (int j = 2; j * j <= vetor[i]; j++)
            //        {
            //            if (vetor[i] % j == 0)
            //            {
            //                ehPrimo = false;
            //                break;
            //            }
            //        }
            //    }

            //    if (ehPrimo)
            //    {
            //        Console.WriteLine($"Posição {i}: {vetor[i]}");
            //    }
            //}


            //------------------------------------------------------------------------------------------------------


            //4.Escreva um algoritmo que leia dois vetores de 10 posições e faça a multiplicação dos elementos de mesmo índice, colocando o resultado em um terceiro vetor. Mostre o vetor resultante.

            //int tamanho = 10;
            //int[] vetor1 = new int[tamanho];
            //int[] vetor2 = new int[tamanho];
            //int[] vetorResultado = new int[tamanho];

            //// Leitura dos valores para o primeiro vetor
            //Console.WriteLine("Digite os valores para o primeiro vetor:");
            //for (int i = 0; i < tamanho; i++)
            //{
            //    Console.Write($"Digite o {i + 1}º valor: ");
            //    vetor1[i] = int.Parse(Console.ReadLine());
            //}

            //// Leitura dos valores para o segundo vetor
            //Console.WriteLine("\nDigite os valores para o segundo vetor:");
            //for (int i = 0; i < tamanho; i++)
            //{
            //    Console.Write($"Digite o {i + 1}º valor: ");
            //    vetor2[i] = int.Parse(Console.ReadLine());
            //}

            //// Realiza a multiplicação e armazena no vetor de resultado
            //for (int i = 0; i < tamanho; i++)
            //{
            //    vetorResultado[i] = vetor1[i] * vetor2[i];
            //}

            //// Exibição do vetor resultado
            //Console.WriteLine("\nVetor Resultante:");
            //for (int i = 0; i < tamanho; i++)
            //{
            //    Console.WriteLine($"Posição {i}: {vetorResultado[i]}");
            //}

            //------------------------------------------------------------------------------------------------------

            //5.Escreva um algoritmo que leia um vetor de 80 elementos inteiros. Encontre e mostre o menor elemento e a sua posição.

            //int tamanho = 80;
            //int[] vetor = new int[tamanho];

            //// Leitura dos valores para o vetor
            //for (int i = 0; i < tamanho; i++)
            //{
            //    Console.Write($"Digite o {i + 1}º valor: ");
            //    vetor[i] = int.Parse(Console.ReadLine());
            //}

            //int menorElemento = vetor[0];
            //int posicaoMenor = 0;

            //// Encontra o menor elemento e sua posição
            //for (int i = 1; i < tamanho; i++)
            //{
            //    if (vetor[i] < menorElemento)
            //    {
            //        menorElemento = vetor[i];
            //        posicaoMenor = i;
            //    }
            //}

            //// Exibe o menor elemento e sua posição
            //Console.WriteLine($"\nMenor elemento: {menorElemento}");
            //Console.WriteLine($"Posição do menor elemento: {posicaoMenor}");

            //------------------------------------------------------------------------------------------------------

            //6.Fazer um algoritmo que leia dez números e escreva-os na ordem contrária à ordem de leitura.Exemplo:
            //a.lê: 		| 7 | 40 | 3 | 9 | 21 | 0 | 63 | 31 | 7 | 22 |
            //b.escreve: 	| 22 | 7 | 31 | 63 | 0 | 21 | 9 | 3 | 40 | 7 |

            int tamanho = 10;
            int[] numeros = new int[tamanho];

            // Leitura dos números
            Console.WriteLine("Digite dez números:");
            for (int i = 0; i < tamanho; i++)
            {
                Console.Write($"Número {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            // Escreve os números na ordem contrária à ordem de leitura
            Console.WriteLine("\nNúmeros na ordem contrária à ordem de leitura:");
            for (int i = tamanho - 1; i >= 0; i--)
            {
                Console.Write($"{numeros[i]} ");
            }


















        }
    }
}