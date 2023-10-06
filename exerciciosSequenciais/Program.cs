using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System;
using Microsoft.VisualBasic;
using System.Drawing;

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

            //DateTime dataNow = DateTime.Now;
            //Console.WriteLine("A data de hoje é: " + dataNow);

            //int dia = dataNow.Day;
            //int mes = dataNow.Month;
            //int ano = dataNow.Year;
            //int ano2digitos = dataNow.Year % 100;

            //string formato1 = ano.ToString("D4") + "/" + mes.ToString("D2") + "/" + dia.ToString("D2");
            //string formato2 = ano2digitos.ToString("D2") + "/" + mes.ToString("D2") + "/" + dia.ToString("D2");

            //Console.WriteLine("A data atual no formato AAAA/MM/DD é: " + formato1);

            //Console.WriteLine("A data atual no formato AA/MM/DD é: " + formato2);

            //--------------------------------------------------------------

            //5) Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel (medido em Km / l), sendo que são conhecidos a distância total percorrida e o volume de combustível
            //consumido para percorrê-la(medido em l).

            //Console.Write("Digite a distância total percorrida em km: ");
            //double distancia = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Digite o volume de combustível consumido em litros: ");
            //double combustivelConsumido = Convert.ToDouble(Console.ReadLine());

            //double consumoMedio = distancia / combustivelConsumido;

            //Console.WriteLine($"O consumo médio do automóvel é de {consumoMedio:F2} Km/l.");

            //Console.ReadLine();

            //--------------------------------------------------------------

            // 6) Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A e para o parafuso B, isto é, o código, a quantidade de peças e o valor unitário de cada parafuso e a porcentagem
            //de IPI(única) a ser acrescentada.

            //// Parafuso A
            //Console.WriteLine("Informe os dados para o Parafuso A:");
            //Console.Write("Código: ");
            //string codigoA = Console.ReadLine();

            //Console.Write("Quantidade de peças: ");
            //int quantidadeA = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Valor unitário: ");
            //double valorUnitarioA = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Porcentagem de IPI: ");
            //double ipiA = Convert.ToDouble(Console.ReadLine());

            //// Parafuso B
            //Console.WriteLine("\nInforme os dados para o Parafuso B:");
            //Console.Write("Código: ");
            //string codigoB = Console.ReadLine();

            //Console.Write("Quantidade de peças: ");
            //int quantidadeB = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Valor unitário: ");
            //double valorUnitarioB = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Porcentagem de IPI: ");
            //double ipiB = Convert.ToDouble(Console.ReadLine());

            //double totalA = quantidadeA * valorUnitarioA * (1 + ipiA / 100);
            //double totalB = quantidadeB * valorUnitarioB * (1 + ipiB / 100);

            //Console.WriteLine("\nTotal para o Parafuso A:");
            //Console.WriteLine($"Código: {codigoA}");
            //Console.WriteLine($"Quantidade de peças: {quantidadeA}");
            //Console.WriteLine($"Valor unitário: R${valorUnitarioA:F2}");
            //Console.WriteLine($"Porcentagem de IPI: {ipiA}%");
            //Console.WriteLine($"Total com IPI: R${totalA:F2}");

            //Console.WriteLine("\nTotal para o Parafuso B:");
            //Console.WriteLine($"Código: {codigoB}");
            //Console.WriteLine($"Quantidade de peças: {quantidadeB}");
            //Console.WriteLine($"Valor unitário: R${valorUnitarioB:F2}");
            //Console.WriteLine($"Porcentagem de IPI: {ipiB}%");
            //Console.WriteLine($"Total com IPI: R${totalB:F2}");

            //Console.ReadLine();

            //--------------------------------------------------------------

            //7) Escreva um programa em C# e no Visual Studio que leia o número de um vendedor, o seu salário fixo, o total de vendas por ele efetuadas e o percentual que ganha sobre o total de vendas. 
            //Calcule o salário total do vendedor. Escreva o número do vendedor e o salário total do vendedor.

            //Console.Write("Digite o número do vendedor: ");
            //int numeroVendedor = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Digite o salário fixo do vendedor: R$");
            //double salarioFixo = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Digite o total de vendas efetuadas pelo vendedor: R$");
            //double totalVendas = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Digite o percentual de comissão sobre as vendas (%): ");
            //double percentualComissao = Convert.ToDouble(Console.ReadLine());

            //double comissao = (percentualComissao / 100) * totalVendas;
            //double salarioTotal = salarioFixo + comissao;

            //Console.WriteLine($"Número do vendedor: {numeroVendedor}");
            //Console.WriteLine($"Salário total do vendedor: R${salarioTotal:F2}");

            //Console.ReadLine();

            //--------------------------------------------------------------

            // 8) Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit. A fórmula da conversão é F = (9 * C + 160) / 5.

            //Console.Write("Digite a temperatura em graus Celsius: ");
            //double celsius = Convert.ToDouble(Console.ReadLine());

            //double fahrenheit = (9 * celsius + 160) / 5;

            //Console.WriteLine($"A temperatura em graus Fahrenheit é: {fahrenheit:F2}°F");

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

            //resto = valorMercadoria % 3;
            //prestacao = (valorMercadoria - resto) / 3;
            //entrada = prestacao + resto;

            //Console.WriteLine("Valor da entrada: " + entrada);
            //Console.WriteLine("Valor das prestaçoes: " + prestacao);

            //--------------------------------------------------------------

            //10) Um programa para gerenciar os saques de um caixa eletrônico deve possuir algum mecanismo para decidir o número de notas de cada valor que deve ser disponibilizado para o cliente que
            //realizou o saque. Um possível critério seria o da “distribuição ótima” no sentido de que as notas de menor valor fossem distribuídas em número mínimo possível.
            //Por exemplo, se a quantia solicitada fosse R$ 87,00 o programa deveria indicar uma nota de R$ 50,00, uma nota de R$ 20,00, uma nota de R$ 10,00, uma nota de R$ 5,00 e duas notas de R$ 1,00.
            //Escreva um programa que receba o valor da quantia solicitada e retorne a distribuição das notas de acordo com o critério da “distribuição ótima”.

            //// Solicita ao usuário que insira o valor da quantia solicitada
            //Console.Write("Digite o valor da quantia solicitada: R$");
            //int quantiaSolicitada = Convert.ToInt32(Console.ReadLine());

            //int[] notasDisponiveis = { 50, 20, 10, 5, 2, 1 };

            //Console.WriteLine("Distribuição das notas:");

            //for (int i = 0; i < notasDisponiveis.Length; i++)
            //{
            //    int nota = notasDisponiveis[i];
            //    int quantidadeNotas = quantiaSolicitada / nota;
            //    quantiaSolicitada %= nota;

            //    if (quantidadeNotas > 0)
            //    {
            //        Console.WriteLine($"Notas de R${nota},00: {quantidadeNotas}");
            //    }
            //}

            //--------------------------------------------------------------

            // 11) Escreva um algoritmo para ler o número de eleitores de um município, o número de votos brancos, nulos e válidos. Calcule e escreva o percentual que cada um  representa em relação ao total de eleitores.

            //Console.Write("Digite o número de eleitores: ");
            //int numeroEleitores = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Digite o número de votos brancos: ");
            //int votosBrancos = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Digite o número de votos nulos: ");
            //int votosNulos = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Digite o número de votos válidos: ");
            //int votosValidos = Convert.ToInt32(Console.ReadLine());

            //double percentualBrancos = (double)votosBrancos / numeroEleitores * 100;
            //double percentualNulos = (double)votosNulos / numeroEleitores * 100;
            //double percentualValidos = (double)votosValidos / numeroEleitores * 100;

            //Console.WriteLine("\nResultados:");
            //Console.WriteLine($"Percentual de votos brancos: {percentualBrancos:F2}%");
            //Console.WriteLine($"Percentual de votos nulos: {percentualNulos:F2}%");
            //Console.WriteLine($"Percentual de votos válidos: {percentualValidos:F2}%");

            //--------------------------------------------------------------

            //12) Um motorista de taxi deseja calcular o rendimento de seu carro na praça.Sabendo - se que o preço do combustível é de R$6,90, escreva um algoritmo para ler a
            //marcação do odômetro(marcador de quilometragem) no início do dia, a marcação no final do dia, o número de litros de combustível gasto e o valor total(R$) recebido
            //dos passageiros.Calcule e escreva a média do consumo em Km / l e o lucro líquido do dia.
            //Fórmulas: Total quilometragem = marcação odômetro final do dia - marcação odômetro inicio do dia
            //Média do consumo = Total quilometragem / quantidade de combustível gasto
            //Lucro do dia = Valor total recebido - (quantidade de combustível gasto * 6,90)

            //Console.Write("Digite a marcação do odômetro no início do dia (em quilômetros): ");
            //double odometroInicio = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Digite a marcação do odômetro no final do dia (em quilômetros): ");
            //double odometroFinal = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Digite o número de litros de combustível gasto: ");
            //double litrosCombustivel = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Digite o valor total recebido dos passageiros (em R$): ");
            //double valorTotalRecebido = Convert.ToDouble(Console.ReadLine());

            //double totalQuilometragem = odometroFinal - odometroInicio;

            //double mediaConsumo = totalQuilometragem / litrosCombustivel;

            //double lucroDia = valorTotalRecebido - (litrosCombustivel * 6.90);

            //Console.WriteLine("\nResultados:");
            //Console.WriteLine($"Total quilometragem percorrida: {totalQuilometragem} km");
            //Console.WriteLine($"Média de consumo: {mediaConsumo:F2} Km/l");
            //Console.WriteLine($"Lucro líquido do dia: R${lucroDia:F2}");

            //--------------------------------------------------------------

            //13) Uma loja vende bicicletas com um acréscimo de 50 % sobre o preço de custo. Ela paga a cada vendedor 2 salários mínimos mensais, mais uma comissão de 15 % sobre o
            //preço de custo de cada bicicleta vendida. Desenvolva um algoritmo que leia o valor do salário mínimo, o preço de custo de cada bicicleta e o número de bicicletas
            //vendidas pelo vendedor, calcule e mostre: o salário do empregado

            Console.Write("Digite o valor do salário mínimo: R$");
            double salarioMinimo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o preço de custo de cada bicicleta: R$");
            double precoCustoBicicleta = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o número de bicicletas vendidas pelo vendedor: ");
            int bicicletasVendidas = Convert.ToInt32(Console.ReadLine());

            double salarioVendedor = 2 * salarioMinimo + (bicicletasVendidas * 0.15 * precoCustoBicicleta);

            Console.WriteLine($"O salário do empregado é: R${salarioVendedor:F2}");

        }
    }
}