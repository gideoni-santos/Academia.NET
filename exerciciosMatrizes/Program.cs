using System.Net;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace exerciciosMatrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1) Crie uma Matriz 5x3.Na primeira coluna, solicite que o usuário preencha.A 2ª coluna, some 10 aos elementos da 1ª coluna. Na 3º coluna, armazene o dobro dos elementos da 1ª coluna.
            //double[,] matriz = new double[5, 3];

            //// Solicitar que o usuário preencha a primeira coluna
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write($"Digite o valor da {i + 1}ª linha da primeira coluna: ");
            //    matriz[i, 0] = Convert.ToDouble(Console.ReadLine());
            //}

            //// Preencher a segunda coluna somando 10 aos elementos da primeira coluna
            //for (int i = 0; i < 5; i++)
            //{
            //    matriz[i, 1] = matriz[i, 0] + 10;
            //}

            //// Preencher a terceira coluna com o dobro dos elementos da primeira coluna
            //for (int i = 0; i < 5; i++)
            //{
            //    matriz[i, 2] = 2 * matriz[i, 0];
            //}

            //// Imprimir a matriz resultante
            //Console.WriteLine("Matriz resultante:");
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(matriz[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}


            //-------------------------------------------------------------------------------

            //2) Solicite ao usuário, preencher uma Matriz 3x3

            //Informe ao usuário:
            //*A soma dos elementos de cada linha
            //-Ex: Linha 1: 30
            //Linha 2: 17

            //* A soma dos elementos de cada coluna
            //-Ex: Coluna 1: 23
            //Coluna 2: 36

            //int[,] matriz = new int[3, 3];

            //// Solicitar ao usuário preencher a matriz
            //Console.WriteLine("Preencha a matriz 3x3:");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"Digite o valor da posição [{i + 1},{j + 1}]: ");
            //        matriz[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //// Calcular e imprimir a soma dos elementos de cada linha
            //Console.WriteLine("Soma dos elementos de cada linha:");
            //for (int i = 0; i < 3; i++)
            //{
            //    int somaLinha = 0;
            //    for (int j = 0; j < 3; j++)
            //    {
            //        somaLinha += matriz[i, j];
            //    }
            //    Console.WriteLine($"Linha {i + 1}: {somaLinha}");
            //}

            //// Calcular e imprimir a soma dos elementos de cada coluna
            //Console.WriteLine("Soma dos elementos de cada coluna:");
            //for (int j = 0; j < 3; j++)
            //{
            //    int somaColuna = 0;
            //    for (int i = 0; i < 3; i++)
            //    {
            //        somaColuna += matriz[i, j];
            //    }
            //    Console.WriteLine($"Coluna {j + 1}: {somaColuna}");
            //}


            //------------------------------------------------------------------------------

            //3) Popule uma matriz 4x4 e mostre os elementos da Diagonal Principal!

            //int[,] matriz = new int[4, 4];

            //// Preencher a matriz
            //Console.WriteLine("Preencha a matriz 4x4:");
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write($"Digite o valor da posição [{i + 1},{j + 1}]: ");
            //        matriz[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //// Mostrar os elementos da diagonal principal
            //Console.WriteLine("Elementos da diagonal principal:");
            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine(matriz[i, i]);
            //}

            //------------------------------------------------------------------------------

            //4) Popule uma matriz 5x5 e informe:
            //-Quantos números são pares
            //- Quantos números são impares
            //- Quantos números são positivos
            //- Quantos números são negativos
            //- Quantos zeros existem!

            //int[,] matriz = new int[5, 5];

            //// Preencher a matriz
            //Console.WriteLine("Preencha a matriz 5x5:");
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write($"Digite o valor da posição [{i + 1},{j + 1}]: ");
            //        matriz[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //int pares = 0;
            //int impares = 0;
            //int positivos = 0;
            //int negativos = 0;
            //int zeros = 0;

            //// Contagem de números pares, ímpares, positivos, negativos e zeros
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if (matriz[i, j] % 2 == 0)
            //        {
            //            pares++;
            //        }
            //        else
            //        {
            //            impares++;
            //        }

            //        if (matriz[i, j] > 0)
            //        {
            //            positivos++;
            //        }
            //        else if (matriz[i, j] < 0)
            //        {
            //            negativos++;
            //        }
            //        else
            //        {
            //            zeros++;
            //        }
            //    }
            //}

            //Console.WriteLine($"Números pares: {pares}");
            //Console.WriteLine($"Números ímpares: {impares}");
            //Console.WriteLine($"Números positivos: {positivos}");
            //Console.WriteLine($"Números negativos: {negativos}");
            //Console.WriteLine($"Zeros: {zeros}");

            //------------------------------------------------------------------------------

            //5) Leia duas matrizes 2x3 de números double. Imprima a soma destas duas matrizes.

            //double[,] matriz1 = new double[2, 3];
            //double[,] matriz2 = new double[2, 3];
            //double[,] somaMatrizes = new double[2, 3];

            //// Preencher a primeira matriz
            //Console.WriteLine("Preencha a primeira matriz 2x3:");
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"Digite o valor da posição [{i + 1},{j + 1}] na primeira matriz: ");
            //        matriz1[i, j] = Convert.ToDouble(Console.ReadLine());
            //    }
            //}

            //// Preencher a segunda matriz
            //Console.WriteLine("Preencha a segunda matriz 2x3:");
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"Digite o valor da posição [{i + 1},{j + 1}] na segunda matriz: ");
            //        matriz2[i, j] = Convert.ToDouble(Console.ReadLine());
            //    }
            //}

            //// Calcular a soma das duas matrizes
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        somaMatrizes[i, j] = matriz1[i, j] + matriz2[i, j];
            //    }
            //}

            //// Imprimir a matriz resultante (soma)
            //Console.WriteLine("Soma das duas matrizes:");
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(somaMatrizes[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //------------------------------------------------------------------------------

            //6) Gere e imprima uma matriz M 4x4 com valores aleatórios entre 0 - 9.Após isso determine o maior número da matriz. 
            //Random random = new Random();
            //int randomNumber = random.Next(0, 100);

            //Random random = new Random();
            //int[,] matriz = new int[4, 4];

            //// Preencher a matriz com valores aleatórios entre 0 e 9
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        matriz[i, j] = random.Next(0, 100); // Gera um número aleatório entre 0 e 9
            //    }
            //}

            //// Imprimir a matriz
            //Console.WriteLine("Matriz 4x4 com valores aleatórios:");
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write(matriz[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //// Determinar o maior número na matriz
            //int maior = matriz[0, 0];
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        if (matriz[i, j] > maior)
            //        {
            //            maior = matriz[i, j];
            //        }
            //    }
            //}

            //Console.WriteLine($"O maior número na matriz é: {maior}");


            //------------------------------------------------------------------------------

            //7) Leia duas matrizes A e B com 3x3 elementos. Construir uma matriz C, onde cada elemento de C é a subtração do elemento correspondente de A com B.

            //int[,] matrizA = new int[3, 3];
            //int[,] matrizB = new int[3, 3];
            //int[,] matrizC = new int[3, 3];

            //// Preencher a matriz A
            //Console.WriteLine("Preencha a matriz A (3x3):");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"Digite o valor da posição [{i + 1},{j + 1}]: ");
            //        matrizA[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //// Preencher a matriz B
            //Console.WriteLine("Preencha a matriz B (3x3):");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"Digite o valor da posição [{i + 1},{j + 1}]: ");
            //        matrizB[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //// Calcular a matriz C (A - B)
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        matrizC[i, j] = matrizA[i, j] - matrizB[i, j];
            //    }
            //}

            //// Imprimir a matriz C
            //Console.WriteLine("Matriz C (A - B):");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(matrizC[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}


            //-----------------------------------------------------------------------------------------

            //8) Ler uma matriz com 4x4 de inteiros e mostrar os números na ordem direta e inversa a que foram lidos.

            //int[,] matriz = new int[4, 4];

            //// Preencher a matriz
            //Console.WriteLine("Preencha a matriz 4x4:");
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write($"Digite o valor da posição [{i + 1},{j + 1}]: ");
            //        matriz[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //// Mostrar a matriz na ordem direta
            //Console.WriteLine("Matriz na ordem direta:");
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write(matriz[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //// Mostrar a matriz na ordem inversa
            //Console.WriteLine("Matriz na ordem inversa:");
            //for (int i = 3; i >= 0; i--)
            //{
            //    for (int j = 3; j >= 0; j--)
            //    {
            //        Console.Write(matriz[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //-----------------------------------------------------------------------------------------

            //9) Leia uma matriz 3x3.Em seguida, solicite um número qualquer ao usuário e pesquise na matriz se o número existe.
            //Caso, seja verdade imprima a mensagem:  “O número existe no vetor” , caso contrário “Número inexistente”.

            //int[,] matriz = new int[3, 3];

            //// Preencher a matriz
            //Console.WriteLine("Preencha a matriz 3x3:");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"Digite o valor da posição [{i + 1},{j + 1}]: ");
            //        matriz[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //// Solicitar um número ao usuário
            //Console.Write("Digite um número para pesquisar na matriz: ");
            //int numeroProcurado = Convert.ToInt32(Console.ReadLine());

            //// Verificar se o número existe na matriz
            //bool numeroExiste = false;
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        if (matriz[i, j] == numeroProcurado)
            //        {
            //            numeroExiste = true;
            //            break;
            //        }
            //    }
            //    if (numeroExiste)
            //    {
            //        break;
            //    }
            //}

            //// Imprimir o resultado
            //if (numeroExiste)
            //{
            //    Console.WriteLine("O número existe na matriz.");
            //}
            //else
            //{
            //    Console.WriteLine("Número inexistente na matriz.");
            //}


            //-------------------------------------------------------------------------------------------------------------------------

            //10) Leia duas matrizes A e B de 4x4 elementos, calcule a média dos mesmos, em seguida, diga quantos dos elementos lidos estão abaixo, acima e na média.

            //int[,] matrizA = new int[4, 4];
            //int[,] matrizB = new int[4, 4];

            //// Preencher a matriz A
            //Console.WriteLine("Preencha a matriz A (4x4):");
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write($"Digite o valor da posição [{i + 1},{j + 1}]: ");
            //        matrizA[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //// Preencher a matriz B
            //Console.WriteLine("Preencha a matriz B (4x4):");
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write($"Digite o valor da posição [{i + 1},{j + 1}]: ");
            //        matrizB[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //// Calcular a média dos elementos das matrizes
            //double somaA = 0;
            //double somaB = 0;

            //foreach (int elemento in matrizA)
            //{
            //    somaA += elemento;
            //}
            //foreach (int elemento in matrizB)
            //{
            //    somaB += elemento;
            //}

            //double mediaA = somaA / (matrizA.GetLength(0) * matrizA.GetLength(1));
            //double mediaB = somaB / (matrizB.GetLength(0) * matrizB.GetLength(1));

            //// Contagem dos elementos abaixo, acima e na média
            //int abaixoMediaA = 0, acimaMediaA = 0, naMediaA = 0;
            //int abaixoMediaB = 0, acimaMediaB = 0, naMediaB = 0;

            //foreach (int elemento in matrizA)
            //{
            //    if (elemento < mediaA)
            //    {
            //        abaixoMediaA++;
            //    }
            //    else if (elemento > mediaA)
            //    {
            //        acimaMediaA++;
            //    }
            //    else
            //    {
            //        naMediaA++;
            //    }
            //}

            //foreach (int elemento in matrizB)
            //{
            //    if (elemento < mediaB)
            //    {
            //        abaixoMediaB++;
            //    }
            //    else if (elemento > mediaB)
            //    {
            //        acimaMediaB++;
            //    }
            //    else
            //    {
            //        naMediaB++;
            //    }
            //}

            //// Imprimir os resultados
            //Console.WriteLine($"Matriz A - Média: {mediaA}");
            //Console.WriteLine($"Elementos abaixo da média: {abaixoMediaA}");
            //Console.WriteLine($"Elementos acima da média: {acimaMediaA}");
            //Console.WriteLine($"Elementos na média: {naMediaA}");
            //Console.WriteLine();

            //Console.WriteLine($"Matriz B - Média: {mediaB}");
            //Console.WriteLine($"Elementos abaixo da média: {abaixoMediaB}");
            //Console.WriteLine($"Elementos acima da média: {acimaMediaB}");
            //Console.WriteLine($"Elementos na média: {naMediaB}");


            //----------------------------------------------------------------------------------------------------------

            //11) Leia uma matriz A de tipo double de dimenção 3x3, crie uma nova matriz resultante da divisão dos elementos da matriz A pela soma dos seus indices.

            //double[,] matrizA = new double[3, 3];
            //double[,] matrizResultante = new double[3, 3];

            //// Preencher a matriz A
            //Console.WriteLine("Preencha a matriz A (3x3):");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"Digite o valor da posição [{i + 1},{j + 1}]: ");
            //        matrizA[i, j] = Convert.ToDouble(Console.ReadLine());
            //    }
            //}

            //// Calcular a matriz resultante
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        matrizResultante[i, j] = matrizA[i, j] / (i + j);
            //    }
            //}

            //// Imprimir a matriz resultante
            //Console.WriteLine("Matriz Resultante:");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(matrizResultante[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}


            //----------------------------------------------------------------------------------------------------------

            //12) Escreva um programa que leia os valores de uma matriz 4x3, e em seguida mostre na tela apenas os valores cuja soma dos índices(i + j) seja um número par.

            //int[,] matriz = new int[4, 3];

            //// Preencher a matriz
            //Console.WriteLine("Preencha a matriz 4x3:");
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"Digite o valor da posição [{i + 1},{j + 1}]: ");
            //        matriz[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //// Mostrar valores com soma de índices (i + j) par
            //Console.WriteLine("Valores com soma de índices par:");
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        if ((i + j) % 2 == 0)
            //        {
            //            Console.WriteLine($"Matriz[{i},{j}] = {matriz[i, j]}");
            //        }
            //    }
            //}


            //-------------------------------------------------------------------------------------------------------------

            //13) Escreva um programa que leia uma matriz de ordem 5(ou seja, 5x5) e verifique se a soma dos elementos da diagonal principal é igual a soma dos elementos da diagonal secundária.

            //int[,] matriz = new int[5, 5];

            //// Preencher a matriz
            //Console.WriteLine("Preencha a matriz 5x5:");
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write($"Digite o valor da posição [{i + 1},{j + 1}]: ");
            //        matriz[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //// Verificar se a soma da diagonal principal é igual à da diagonal secundária
            //int somaDiagonalPrincipal = 0;
            //int somaDiagonalSecundaria = 0;

            //for (int i = 0; i < 5; i++)
            //{
            //    somaDiagonalPrincipal += matriz[i, i];
            //    somaDiagonalSecundaria += matriz[i, 4 - i];
            //}

            //// Imprimir o resultado
            //Console.WriteLine($"Soma da diagonal principal: {somaDiagonalPrincipal}");
            //Console.WriteLine($"Soma da diagonal secundária: {somaDiagonalSecundaria}");

            //if (somaDiagonalPrincipal == somaDiagonalSecundaria)
            //{
            //    Console.WriteLine("A soma da diagonal principal é igual à soma da diagonal secundária.");
            //}
            //else
            //{
            //    Console.WriteLine("A soma da diagonal principal não é igual à soma da diagonal secundária.");
            //}

            //---------------------------------------------------------------------------------------------------------------------


            //14) Escreva um programa que leia uma matriz de ordem 5 e verifique se os elementos da diagonal principal(da esquerda para a direita) são os mesmos da diagonal secundária(direita pra esquerda).

            //int[,] matriz = new int[5, 5];

            //// Preencher a matriz
            //Console.WriteLine("Preencha a matriz 5x5:");
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write($"Digite o valor da posição [{i + 1},{j + 1}]: ");
            //        matriz[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //// Verificar se os elementos da diagonal principal são iguais aos da diagonal secundária
            //bool diagonaisIguais = true;

            //for (int i = 0; i < 5; i++)
            //{
            //    if (matriz[i, i] != matriz[i, 4 - i])
            //    {
            //        diagonaisIguais = false;
            //        break; // Se encontrar elementos diferentes, não é preciso continuar verificando
            //    }
            //}

            //// Imprimir o resultado
            //Console.WriteLine("Matriz:");
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write(matriz[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //if (diagonaisIguais)
            //{
            //    Console.WriteLine("Os elementos da diagonal principal são iguais aos da diagonal secundária.");
            //}
            //else
            //{
            //    Console.WriteLine("Os elementos da diagonal principal não são iguais aos da diagonal secundária.");
            //}

            //---------------------------------------------------------------------------------------------------------------


            //15) Escreva um programa em C# para ler os valores e somar duas matrizes 4 x 4. Mostrar a matriz resultante

            //int[,] matrizA = new int[4, 4];
            //int[,] matrizB = new int[4, 4];
            //int[,] matrizResultante = new int[4, 4];

            //// Preencher a matriz A
            //Console.WriteLine("Preencha a matriz A (4x4):");
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write($"Digite o valor da posição [{i + 1},{j + 1}]: ");
            //        matrizA[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //// Preencher a matriz B
            //Console.WriteLine("Preencha a matriz B (4x4):");
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write($"Digite o valor da posição [{i + 1},{j + 1}]: ");
            //        matrizB[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //// Somar as matrizes
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        matrizResultante[i, j] = matrizA[i, j] + matrizB[i, j];
            //    }
            //}

            //// Imprimir a matriz resultante
            //Console.WriteLine("Matriz Resultante:");
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write(matrizResultante[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}


            //---------------------------------------------------------------------------------------------------------------------------

            //16) Escreva um algoritmo para transpor uma matriz 3x4 para outra 4x3.Transpor uma matriz significa transformar suas linhas em colunas e vice - versa.

            //int[,] matrizOriginal = new int[3, 4];
            //int[,] matrizTransposta = new int[4, 3];

            //// Preencher a matriz original
            //Console.WriteLine("Preencha a matriz original (3x4):");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write($"Digite o valor da posição [{i + 1},{j + 1}]: ");
            //        matrizOriginal[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //// Transpor a matriz original
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        matrizTransposta[j, i] = matrizOriginal[i, j];
            //    }
            //}

            //// Imprimir a matriz transposta
            //Console.WriteLine("Matriz Transposta (4x3):");
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(matrizTransposta[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}


            //-----------------------------------------------------------------------------------------------------------

            //17) Fazer um algoritmo que leia uma matriz de 10 linhas por 10 colunas e escreva o elemento minimax, ou seja,o menor elemento da linha onde se encontra o maior elemento da matriz.Escreva também a linha e a coluna onde foi encontrado.

            //int[,] matriz = new int[10, 10];
            //Random random = new Random();

            //// Preencher a matriz com valores aleatórios entre 1 e 100
            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        matriz[i, j] = random.Next(1, 101); // Gera valores aleatórios entre 1 e 100
            //    }
            //}

            //// Encontrar o maior elemento da matriz e sua posição
            //int maiorElemento = matriz[0, 0];
            //int linhaMaiorElemento = 0;
            //int colunaMaiorElemento = 0;

            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        if (matriz[i, j] > maiorElemento)
            //        {
            //            maiorElemento = matriz[i, j];
            //            linhaMaiorElemento = i;
            //            colunaMaiorElemento = j;
            //        }
            //    }
            //}

            //// Encontrar o menor elemento na matriz e sua posição
            //int menorElemento = matriz[0, 0];
            //int linhaMenorElemento = 0;
            //int colunaMenorElemento = 0;

            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        if (matriz[i, j] < menorElemento)
            //        {
            //            menorElemento = matriz[i, j];
            //            linhaMenorElemento = i;
            //            colunaMenorElemento = j;
            //        }
            //    }
            //}

            //// Imprimir a matriz
            //Console.WriteLine("Matriz gerada aleatoriamente:");
            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        Console.Write(matriz[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //// Imprimir o resultado
            //Console.WriteLine($"Maior elemento da matriz: {maiorElemento}");
            //Console.WriteLine($"Encontrado na linha {linhaMaiorElemento + 1}, coluna {colunaMaiorElemento + 1}");
            //Console.WriteLine($"Menor elemento na matriz: {menorElemento}");
            //Console.WriteLine($"Encontrado na linha {linhaMenorElemento + 1}, coluna {colunaMenorElemento + 1}");






























        }
    }
}