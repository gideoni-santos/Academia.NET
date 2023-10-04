using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System;
using Microsoft.VisualBasic;

namespace exerciciosSequenciais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre dois números quaisquer.

            //Console.WriteLine("Digite um número: ");
            //int num1 = int.Parse(Console.ReadLine()!);

            //Console.WriteLine("Digite um outro número: ");
            //int num2 = int.Parse(Console.ReadLine()!);

            //float media = (num1 + num2) / 2;
            //Console.WriteLine("A média dos valores é inseridos é: " + media);

            //--------------------------------------------------------------

            // 2) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre quatro números quaisquer.

            //Console.WriteLine("Digite um número: ");
            //int num3 = int.Parse(Console.ReadLine()!);

            //Console.WriteLine("Digite um outro número: ");
            //int num4 = int.Parse(Console.ReadLine()!);

            //Console.WriteLine("Digite um número: ");
            //int num5 = int.Parse(Console.ReadLine()!);

            //Console.WriteLine("Digite um outro número: ");
            //int num6 = int.Parse(Console.ReadLine()!);

            //double media2 = (num3 + num4 + num5 + num6) / 4.0; //Inserir o 4.0 para que o resultado saia com as casas decimais
            //Console.WriteLine("A média dos valores é inseridos é: " + media2);

            //--------------------------------------------------------------

            // 3) Escreva a seqüência de atribuições, em forma de programa em C# e no Visual Studio, para trocar entre si os valores de duas variáveis A e B.

            //string nome1 = "Gideoni";
            //Console.WriteLine("O conteúdo de nome1 é: " + nome1);

            //string nome2 = "Fernanda";
            //Console.WriteLine("O conteúdo de nome2 é: " + nome2);

            //string backup = nome1;
            //Console.WriteLine("O conteúdo de backup é: " + backup);

            //nome1 = nome2;
            //Console.WriteLine("O conteúdo de nome1 sobrescreveu e agora é: " + nome1);

            //nome2 = backup;
            //Console.WriteLine("O conteúdo de nome2 sobrescreveu e agora é: " + nome2);

            //// - Manipulação de string
            //Console.Write("Digite uma frase qualquer: ");
            //string frase = Console.ReadLine();

            ////Console.WriteLine("Você digitou....: " + frase.ToUpper()); //ToUpper é usado para transormar em maiusculo
            ////Console.WriteLine("Esta frase tem " + frase.Length + " caracteres"); //Lenght é usado para contar quantas caracteres tem em uma frase

            //Console.Write("Digite algo para pesquisar: ");
            //string palavra = Console.ReadLine();

            //if (frase.Contains(palavra))
            //{
            //    Console.WriteLine(palavra + " aparece na frase");
            //    //bloco de instruções caso a palavra esteja na frase
            //}
            //else
            //{
            //    Console.WriteLine(palavra + " não aparece na frase");
            //    //bloco de instruções caso a palavra não esteja na frase
            //}

            //--------------------------------------------------------------

            // 4) Faça um programa em C# e no Visual Studio que receba a data na forma DDMMAAAA e imprima na forma AAAAMMDD e AAMMDD.Note que o dia, o mês e o ano devem ser lidos em variáveis diferentes.

            DateTime dataNow = DateTime.Now;
            Console.WriteLine("A data de hoje é: " + dataNow);

            int dia = dataNow.Day;
            int mes = dataNow.Month;
            int ano = dataNow.Year;
            int ano2digitos = dataNow.Year % 100;

            string formato1 = ano.ToString("D4") + "/" + mes.ToString("D2") + "/" + dia.ToString("D2");
            string formato2 = ano2digitos.ToString("D2") + "/" + mes.ToString("D2") + "/" + dia.ToString("D2");

            Console.WriteLine("A data atual no formato AAAA/MM/DD é: " + formato1);

            Console.WriteLine("A data atual no formato AA/MM/DD é: " + formato2);

















            //--------------------------------------------------------------

            // 9) Uma loja vende seus produtos no sistema de entrada mais duas prestações, sendo a entrada maiorou igual às prestações, que devem ser iguais, inteiras e as maiores possíveis.
            //Por exemplo, se o valor da mercadoria for R$ 270, 00, a entrada e as duas prestações são iguais a R$ 90, 00;
            //se o valor da mercadoria for R$ 302, 75 a entrada é de R$ 102, 75 e as duas prestações são iguais a R$ 100, 00.
            //Escreva um programa em C# e no Visual Studio que receba o valor da mercadoria e forneça o valor 
            //da entrada e das duas prestações, de acordo com as regras acima.
            //Observe que uma justificativa para a adoção desta regra é que ela facilita a confecção e o
            //conseqüente pagamento dos boletos das duas prestações.

            //double valorMercadoria;
            //double entrada;
            //double prestacao;
            //double resto;

            //Console.Write("Digite o valor da mercadoria: R$ ");
            //valorMercadoria = double.Parse(Console.ReadLine()!);

            //// Calcula a entrada e as duas prestações
            //resto = valorMercadoria % 3;
            //prestacao = (valorMercadoria - resto) / 3;
            //entrada = prestacao + resto;

            //Console.WriteLine("Valor da entrada: " + entrada);
            //Console.WriteLine("Valor das prestaçoes: " + prestacao);

            //--------------------------------------------------------------






        }
    }
}