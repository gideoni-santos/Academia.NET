namespace ExerciciosRepeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Escreva um algoritmo para ler um número n, e em seguida ler pelo teclado a idade de n pessoas e calcular a média das idades.

            //Console.Write("Digite o número de pessoas (n): ");
            //int n = int.Parse(Console.ReadLine());

            //if (n > 0)
            //{
            //    int somaIdades = 0;

            //    for (int i = 1; i <= n; i++)
            //    {
            //        Console.Write("Digite a idade da pessoa " + i + ": ");
            //        int idade = int.Parse(Console.ReadLine());
            //        somaIdades += idade;
            //    }

            //    double mediaIdades = (double)somaIdades / n;

            //    Console.WriteLine("A média das idades é: " + mediaIdades.ToString("F2"));
            //}
            //else
            //{
            //    Console.WriteLine("O número de pessoas (n) deve ser maior que zero.");
            //}

            //-----------------------------------------------------------------------------------------------

            //2.Faça um algoritmo que leia 10 números pelo teclado, e que no final mostre o maior deles. Não usar vetor.

            //int maior = int.MinValue;

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("Digite o número " + i + ": ");
            //    int numero = int.Parse(Console.ReadLine());

            //    if (numero > maior)
            //    {
            //        maior = numero;
            //    }
            //}

            //Console.WriteLine("O maior número digitado é: " + maior);

            //-----------------------------------------------------------------------------------------------

            //3.Escreva um algoritmo que leia pelo teclado um valor e então calcule a tabuada de 1 a 10 de um número x lido utilizando laços de repetição, e mostre na tela.

            //Console.Write("Digite um número para calcular a tabuada: ");
            //int x = int.Parse(Console.ReadLine());

            //Console.WriteLine("Tabuada de " + x + ":");

            //for (int i = 1; i <= 10; i++)
            //{
            //    int resultado = x * i;
            //    Console.WriteLine(x + " x " + i + " = " + resultado);
            //}

            //-----------------------------------------------------------------------------------------------

            //4.Escreva um algoritmo que leia dois valores pelo teclado, x e y, e em seguida calcule a potência de x elevado na y sem utilizar a função pow.

            //Console.Write("Digite o valor de x: ");
            //double x = double.Parse(Console.ReadLine());

            //Console.Write("Digite o valor de y: ");
            //int y = int.Parse(Console.ReadLine());

            //double resultado = 1;

            //for (int i = 1; i <= Math.Abs(y); i++)
            //{
            //    resultado *= x;
            //}

            //if (y < 0)
            //{
            //    resultado = 1 / resultado;
            //}

            //Console.WriteLine("O resultado de " + x + " elevado a " + y + " é: " + resultado);

            //-----------------------------------------------------------------------------------------------

            //5.Escreva um algoritmo para calcular o fatorial de um número.

            //Console.Write("Digite um número inteiro positivo: ");
            //int numero = int.Parse(Console.ReadLine());

            //if (numero >= 0)
            //{
            //    long fatorial = 1;

            //    for (int i = 1; i <= numero; i++)
            //    {
            //        fatorial *= i;
            //    }

            //    Console.WriteLine("O fatorial de " + numero + " é: " + fatorial);
            //}
            //else
            //{
            //    Console.WriteLine("Digite um número inteiro positivo para calcular o fatorial.");
            //}

            //-----------------------------------------------------------------------------------------------

            //6.Escreva um algoritmo que leia o número de alunos de uma turma e em seguida leia a quantidade de avaliações aplicadas para aquela turma. Por fim, leia as notas das avaliações de cada aluno e mostre sua nota final (média das notas das avaliações).

            //Console.Write("Digite o número de alunos na turma: ");
            //int numeroDeAlunos = int.Parse(Console.ReadLine());

            //Console.Write("Digite a quantidade de avaliações aplicadas: ");
            //int numeroDeAvaliacoes = int.Parse(Console.ReadLine());

            //for (int aluno = 1; aluno <= numeroDeAlunos; aluno++)
            //{
            //    double somaDasNotas = 0;

            //    for (int avaliacao = 1; avaliacao <= numeroDeAvaliacoes; avaliacao++)
            //    {
            //        Console.Write($"Digite a nota da avaliação {avaliacao} para o aluno {aluno}: ");
            //        double nota = double.Parse(Console.ReadLine());
            //        somaDasNotas += nota;
            //    }

            //    double media = somaDasNotas / numeroDeAvaliacoes;
            //    Console.WriteLine($"A média das notas para o aluno {aluno} é: {media}");
            //}

            //-----------------------------------------------------------------------------------------------

            //7.Escreva um programa em C# leia 20 números e que conte a quantidade de números pares e ímpares digitados por um usuário. Apresente o resultado.

            int quantidadePares = 0;
            int quantidadeImpares = 0;

            for (int i = 1; i <= 20; i++)
            {
                Console.Write("Digite o número " + i + ": ");
                int numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    quantidadePares++;
                }
                else
                {
                    quantidadeImpares++;
                }
            }

            Console.WriteLine("Quantidade de números pares: " + quantidadePares);
            Console.WriteLine("Quantidade de números ímpares: " + quantidadeImpares);
        }
    }
}