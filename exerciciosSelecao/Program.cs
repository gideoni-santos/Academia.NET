using System.Drawing;
using System;
using System.Net;
using System.Reflection.Emit;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Intrinsics.X86;
using System.IO;
using System.Runtime.ConstrainedExecution;

namespace exerciciosSelecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 - Faça um algoritmo para calcular e mostrar a área de um triângulo a partir dos valores da base e da altura lidos pelo teclado: Área do triangulo = (base * altura) / 2;
            //Teste se a base ou a altura digitada não foi igual a zero.

            //// Solicita ao usuário que insira a base do triângulo
            //Console.Write("Digite a base do triângulo: ");
            //double baseTriangulo = Convert.ToDouble(Console.ReadLine());

            //// Solicita ao usuário que insira a altura do triângulo
            //Console.Write("Digite a altura do triângulo: ");
            //double alturaTriangulo = Convert.ToDouble(Console.ReadLine());

            //// Verifica se a base ou a altura é igual a zero
            //if (baseTriangulo <= 0 || alturaTriangulo <= 0)
            //{
            //    Console.WriteLine("A base e a altura devem ser maiores que zero.");
            //}
            //else
            //{
            //    // Calcula a área do triângulo
            //    double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;

            //    // Exibe a área do triângulo
            //    Console.WriteLine($"A área do triângulo é: {areaTriangulo:F2}");
            //}

            // -------------------------------------------------------------------

            // 2 - Faça um algoritmo para ler um número e verificar se ele é par ou ímpar. 

            //// Solicita ao usuário que insira um número
            //Console.Write("Digite um número: ");
            //int numero = Convert.ToInt32(Console.ReadLine());

            //// Verifica se o número é par ou ímpar
            //if (numero % 2 == 0)
            //{
            //    Console.WriteLine("O número é par.");
            //}
            //else
            //{
            //    Console.WriteLine("O número é ímpar.");
            //}

            // -------------------------------------------------------------------

            // 3 - Escrever um algoritmo para ler quatro valores inteiros, calcular a sua média, e escrever na tela os que são superiores à média.

            //int[] valores = new int[4];
            //double soma = 0;

            //// Solicita ao usuário que insira os quatro valores inteiros
            //for (int i = 0; i < 4; i++)
            //{
            //    Console.Write($"Digite o {i + 1}º valor: ");
            //    valores[i] = Convert.ToInt32(Console.ReadLine());
            //    soma += valores[i];
            //}

            //// Calcula a média
            //double media = soma / 4;
            //Console.WriteLine("O valor médio dos valores é: " + media);

            //// Exibe os valores superiores à média
            //Console.WriteLine("\nValores superiores à média:");
            //for (int i = 0; i < 4; i++)
            //{
            //    if (valores[i] > media)
            //    {
            //        Console.WriteLine(valores[i]);
            //    }
            //}

            // -------------------------------------------------------------------

            //4 - Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores e o valor por hora recebido por cada um deles. Mostrar na tela qual dos professores tem o maior salário total.

            //// Professor 1
            //Console.WriteLine("Professor 1:");
            //Console.Write("Quantidade de horas aula: ");
            //double horasAula1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Valor por hora: R$");
            //double valorHora1 = Convert.ToDouble(Console.ReadLine());

            //// Professor 2
            //Console.WriteLine("\nProfessor 2:");
            //Console.Write("Quantidade de horas aula: ");
            //double horasAula2 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Valor por hora: R$");
            //double valorHora2 = Convert.ToDouble(Console.ReadLine());

            //// Calcula os salários totais dos professores
            //double salarioTotal1 = horasAula1 * valorHora1;
            //double salarioTotal2 = horasAula2 * valorHora2;

            //// Determina qual professor tem o maior salário total
            //if (salarioTotal1 > salarioTotal2)
            //{
            //    Console.WriteLine("\nO Professor 1 tem o maior salário total.");
            //}
            //else if (salarioTotal2 > salarioTotal1)
            //{
            //    Console.WriteLine("\nO Professor 2 tem o maior salário total.");
            //}
            //else
            //{
            //    Console.WriteLine("\nAmbos os professores têm o mesmo salário total.");
            //}

            // -------------------------------------------------------------------

            // 5 - Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra “Aprovado” se a média das duas notas for maior ou igual a 7, 0.

            //// Solicita ao usuário que insira a primeira nota
            //Console.Write("Digite a primeira nota: ");
            //double nota1 = Convert.ToDouble(Console.ReadLine());

            //// Solicita ao usuário que insira a segunda nota
            //Console.Write("Digite a segunda nota: ");
            //double nota2 = Convert.ToDouble(Console.ReadLine());

            //// Calcula a média das notas
            //double media = (nota1 + nota2) / 2;

            //// Verifica se a média é maior ou igual a 7.0
            //if (media >= 7.0)
            //{
            //    Console.WriteLine("Aprovado");
            //}
            //else
            //{
            //    Console.WriteLine("Reprovado");
            //}

            // -------------------------------------------------------------------

            //6 - Faça um programa em C# e no Visual Studio para receber o nome (totalmente em maiúsculo), a altura (metros) e o peso (kg) de uma pessoa.
            //O programa deve calcular o Indice de Massa Corpórea(IMC), exibi - lo ao usuário e informar sua situação conforme a tabela. O cálculo do imc = peso / (altura * altura)

            //// Solicita ao usuário que insira o nome (totalmente em maiúsculo)
            //Console.Write("Digite o nome (em maiúsculo): ");
            //string nome = Console.ReadLine();

            //// Solicita ao usuário que insira a altura (em metros)
            //Console.Write("Digite a altura (em metros): ");
            //double altura = Convert.ToDouble(Console.ReadLine());

            //// Solicita ao usuário que insira o peso (em kg)
            //Console.Write("Digite o peso (em kg): ");
            //double peso = Convert.ToDouble(Console.ReadLine());

            //// Calcula o IMC (Índice de Massa Corporal)
            //double imc = peso / (altura * altura);

            //// Exibe o IMC
            //Console.WriteLine($"O IMC de {nome} é: {imc:F2}");

            //// Verifica a situação com base nas faixas fornecidas
            //string situacao = "";

            //if (imc < 18)
            //{
            //    situacao = "Baixo Peso";
            //}
            //else if (imc >= 18 && imc < 25)
            //{
            //    situacao = "Peso Normal";
            //}
            //else if (imc >= 25 && imc < 30)
            //{
            //    situacao = "Sobrepeso";
            //}
            //else if (imc >= 30 && imc < 35)
            //{
            //    situacao = "Obesidade";
            //}
            //else
            //{
            //    situacao = "Obesidade Grau Sério";
            //}

            //// Exibe a situação
            //Console.WriteLine($"Situação: {situacao}");

            // -------------------------------------------------------------------

            //7 - Faça um programa em C# e no VS para receber uma frase qualquer e uma palavra de pesquisa. O programa deve avaliar se a palavra aparece na frase, informando o usuário via mensagem, como por
            //exemplo, A palavra encontra - se na frase  ou A palavra não se encontra na frase.

            //// Solicita ao usuário que insira uma frase
            //Console.Write("Digite uma frase: ");
            //string frase = Console.ReadLine();

            //// Solicita ao usuário que insira a palavra de pesquisa
            //Console.Write("Digite uma palavra de pesquisa: ");
            //string palavra = Console.ReadLine();

            //// Verifica se a palavra aparece na frase
            //if (frase.Contains(palavra))
            //{
            //    Console.WriteLine("A palavra se encontra na frase.");
            //}
            //else
            //{
            //    Console.WriteLine("A palavra não se encontra na frase.");
            //}

            // -------------------------------------------------------------------

            //8 - Faça um programa no VS que receba o código, nome, salário base e o total de vendas de um funcionário. Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu salário final 5 % do total de vendas.
            //Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu salário final 7 % do total de vendas. E por fim, se o total de vendas seja maior que R$ 5000,00, adicionar ao seu salário final 10 % dototal de vendas.

            //// Solicita ao usuário que insira o código do funcionário
            //Console.Write("Digite o código do funcionário: ");
            //int codigo = Convert.ToInt32(Console.ReadLine());

            //// Solicita ao usuário que insira o nome do funcionário
            //Console.Write("Digite o nome do funcionário: ");
            //string nome = Console.ReadLine();

            //// Solicita ao usuário que insira o salário base do funcionário
            //Console.Write("Digite o salário base do funcionário: R$");
            //double salarioBase = Convert.ToDouble(Console.ReadLine());

            //// Solicita ao usuário que insira o total de vendas do funcionário
            //Console.Write("Digite o total de vendas do funcionário: R$");
            //double totalVendas = Convert.ToDouble(Console.ReadLine());

            //// Calcula o bônus com base nas condições
            //double bonus = 0.0;

            //if (totalVendas > 500.00)
            //{
            //    bonus += totalVendas * 0.05;
            //}

            //if (totalVendas > 1000.00)
            //{
            //    bonus += totalVendas * 0.02; // 7% no total (5% já adicionado)
            //}

            //if (totalVendas > 5000.00)
            //{
            //    bonus += totalVendas * 0.03; // 10% no total (3% adicionado)
            //}

            //// Calcula o salário final
            //double salarioFinal = salarioBase + bonus;

            //// Exibe o resultado
            //Console.WriteLine("\nInformações do funcionário:");
            //Console.WriteLine($"Código: {codigo}");
            //Console.WriteLine($"Nome: {nome}");
            //Console.WriteLine($"Salário Base: R${salarioBase:F2}");
            //Console.WriteLine($"Total de Vendas: R${totalVendas:F2}");
            //Console.WriteLine($"Bônus: R${bonus:F2}");
            //Console.WriteLine($"Salário Final: R${salarioFinal:F2}");

            // -------------------------------------------------------------------

            //9 - Faça um programa no VS que receba do usuário 3 valores de glicemia em jejum, representando a medição diária de um paciente diabético. Para cada valor recebido analisar e informar ao paciente o seguinte:
            //Se o valor diário for menor que 65, avisá - lo que corre risco de hipoglicemia. Se o valor diário for maior que 250, avisá - lo que corre risco de hiperglicemia.
            //Além disso, o programa deve fazer a média dos 3 valores de glicemia coletados.E se a média for menor que 80, avisá - lo que é preciso diminuir 2 unidades de insulina.Se a média for maior que
            //150, avisá - lo que será necessário adicionar 2 unidades de insulina.

            //// Array para armazenar os valores de glicemia em jejum
            //double[] valoresGlicemia = new double[3];

            //// Solicita ao usuário que insira os três valores de glicemia em jejum
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write($"Digite o valor de glicemia {i + 1}: ");
            //    valoresGlicemia[i] = Convert.ToDouble(Console.ReadLine());
            //}

            //// Calcula a média dos valores de glicemia
            //double mediaGlicemia = (valoresGlicemia[0] + valoresGlicemia[1] + valoresGlicemia[2]) / 3;

            //// Verifica as condições e fornece orientações ao paciente
            //if (mediaGlicemia < 80)
            //{
            //    Console.WriteLine("A média de glicemia está abaixo de 80. É necessário diminuir 2 unidades de insulina.");
            //}
            //else if (mediaGlicemia > 150)
            //{
            //    Console.WriteLine("A média de glicemia está acima de 150. É necessário adicionar 2 unidades de insulina.");
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    if (valoresGlicemia[i] < 65)
            //    {
            //        Console.WriteLine($"Valor diário {i + 1} está abaixo de 65. Corre risco de hipoglicemia.");
            //    }
            //    else if (valoresGlicemia[i] > 250)
            //    {
            //        Console.WriteLine($"Valor diário {i + 1} está acima de 250. Corre risco de hiperglicemia.");
            //    }
            //}

            // -------------------------------------------------------------------

            // 10 - Faça um programa no VS que receba dados de dois atletas(nome, idade e altura). O programa deve mostrar os dados do atleta mais novo e mais alto.

            //string nomeAtleta1, nomeAtleta2;
            //int idadeAtleta1, idadeAtleta2;
            //double alturaAtleta1, alturaAtleta2;

            //// Solicita ao usuário os dados do primeiro atleta
            //Console.WriteLine("Dados do primeiro atleta:");
            //Console.Write("Nome: ");
            //nomeAtleta1 = Console.ReadLine();

            //Console.Write("Idade: ");
            //idadeAtleta1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Altura (metros): ");
            //alturaAtleta1 = Convert.ToDouble(Console.ReadLine());

            //// Solicita ao usuário os dados do segundo atleta
            //Console.WriteLine("\nDados do segundo atleta:");
            //Console.Write("Nome: ");
            //nomeAtleta2 = Console.ReadLine();

            //Console.Write("Idade: ");
            //idadeAtleta2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Altura (metros): ");
            //alturaAtleta2 = Convert.ToDouble(Console.ReadLine());

            //// Verifica quem é o atleta mais novo e mais alto
            //string maisNovo, maisAlto;

            //if (idadeAtleta1 < idadeAtleta2)
            //{
            //    maisNovo = nomeAtleta1;
            //}
            //else
            //{
            //    maisNovo = nomeAtleta2;
            //}

            //if (alturaAtleta1 > alturaAtleta2)
            //{
            //    maisAlto = nomeAtleta1;
            //}
            //else
            //{
            //    maisAlto = nomeAtleta2;
            //}

            //// Exibe os dados do atleta mais novo e mais alto
            //Console.WriteLine("\nAtleta mais novo: " + maisNovo);
            //Console.WriteLine("Atleta mais alto: " + maisAlto);

            // -------------------------------------------------------------------

            //11 - Faça um programa no VS que receba uma hora, dividida em 2 variáveis(uma para hora e outra para minutos). O programa deve exibir se a hora digitada está ou não válida. 
            //Lembre que usaremos o padrão de hora com 24h, de 0 a 23.

            //// Solicita ao usuário que insira a hora
            //Console.Write("Digite a hora (0 a 23): ");
            //int hora = Convert.ToInt32(Console.ReadLine());

            //// Solicita ao usuário que insira os minutos
            //Console.Write("Digite os minutos (0 a 59): ");
            //int minutos = Convert.ToInt32(Console.ReadLine());

            //// Verifica se a hora e os minutos estão dentro dos intervalos válidos
            //bool horaValida = hora >= 0 && hora <= 23;
            //bool minutosValidos = minutos >= 0 && minutos <= 59;

            //// Verifica se a hora completa é válida
            //if (horaValida && minutosValidos)
            //{
            //    Console.WriteLine("Hora válida.");
            //}
            //else
            //{
            //    Console.WriteLine("Hora inválida.");
            //}

            // -------------------------------------------------------------------

            //12 - Elabore um programa em VS que leia as variáveis "codigo" e "numeroHoras", respectivamente código e número de horas trabalhadas de um operário. Na sequência, calcule o salário sabendo - se que ele ganha
            //R$ 10,00 por hora. Quando o número de horas exceder a 50 calcule o excesso de pagamento armazenando - o na variável "extra", caso contrário zerar tal variável.A hora excedente de trabalho vale R$ 20,00.
            //No final do processamento, exibir o salário total e o salário excedente do operário.

            //// Solicita ao usuário que insira o código do operário
            //Console.Write("Digite o código do operário: ");
            //int codigo = Convert.ToInt32(Console.ReadLine());

            //// Solicita ao usuário que insira o número de horas trabalhadas
            //Console.Write("Digite o número de horas trabalhadas: ");
            //int numeroHoras = Convert.ToInt32(Console.ReadLine());

            //// Define o valor da hora regular e da hora extra
            //double valorHoraRegular = 10.00;
            //double valorHoraExtra = 20.00;

            //// Inicializa a variável que armazenará o valor do salário
            //double salario = 0.0;

            //// Inicializa a variável que armazenará o valor do salário excedente
            //double salarioExcedente = 0.0;

            //// Verifica se o número de horas trabalhadas excede 50
            //if (numeroHoras > 50)
            //{
            //    // Calcula o salário para as primeiras 50 horas
            //    salario = 50 * valorHoraRegular;

            //    // Calcula o salário excedente para as horas extras
            //    salarioExcedente = (numeroHoras - 50) * valorHoraExtra;
            //}
            //else
            //{
            //    // Calcula o salário para todas as horas
            //    salario = numeroHoras * valorHoraRegular;
            //}

            //// Exibe o salário total e o salário excedente
            //Console.WriteLine("\nSalário total: R$" + salario.ToString("F2"));
            //Console.WriteLine("Salário excedente: R$" + salarioExcedente.ToString("F2"));

            // -------------------------------------------------------------------

            //13 - Tendo como dado de entrada a altura(h) de uma pessoa, construa um programa no VS que calcule seu peso ideal, utilizando as seguintes fórmulas:
            //Para homens: (72.7 * h) - 58
            //Para mulheres: (62.1 * h) - 44.7

            //// Solicita ao usuário que insira a altura (em metros)
            //Console.Write("Digite a altura (em metros): ");
            //double altura = Convert.ToDouble(Console.ReadLine());

            //// Solicita ao usuário que informe o gênero (M para homem, F para mulher)
            //Console.Write("Informe o gênero (M para homem, F para mulher): ");
            //char genero = Console.ReadKey().KeyChar;

            //// Calcula o peso ideal com base no gênero
            //double pesoIdeal = 0.0;

            //if (genero == 'M' || genero == 'm')
            //{
            //    pesoIdeal = (72.7 * altura) - 58;
            //}
            //else if (genero == 'F' || genero == 'f')
            //{
            //    pesoIdeal = (62.1 * altura) - 44.7;
            //}
            //else
            //{
            //    Console.WriteLine("\nGênero inválido. Use M para homem ou F para mulher.");
            //    return;
            //}

            //// Exibe o peso ideal
            //Console.WriteLine("\nO peso ideal é: " + pesoIdeal.ToString("F2") + " kg");

            // -------------------------------------------------------------------

            //14 - Faça um programa que peça o tamanho de um arquivo para download(em MB) e a velocidade de um link de Internet(em Mbps). Em seguida, calcule e informe o tempo aproximado de download
            //do arquivo usando este link(em minutos).

            //// Solicita ao usuário que insira o tamanho do arquivo em MB
            //Console.Write("Digite o tamanho do arquivo em MB: ");
            //double tamanhoArquivoMB = Convert.ToDouble(Console.ReadLine());

            //// Solicita ao usuário que insira a velocidade do link de Internet em Mbps
            //Console.Write("Digite a velocidade do link de Internet em Mbps: ");
            //double velocidadeInternetMbps = Convert.ToDouble(Console.ReadLine());

            //// Calcula o tempo aproximado de download em minutos
            //double tempoDownloadMinutos = (tamanhoArquivoMB * 8) / (velocidadeInternetMbps * 60);

            //// Exibe o tempo aproximado de download
            //Console.WriteLine("\nO tempo aproximado de download é: " + tempoDownloadMinutos.ToString("F2") + " minutos");

            //// Aguarda o usuário pressionar Enter para encerrar o programa
            //Console.ReadLine();

            // -------------------------------------------------------------------

            //15 - Faça um programa para uma loja de tintas.O programa deverá pedir o tamanho em metros quadrados da área a ser pintada. Considere que a cobertura da tinta é de 1 litro para cada 3 metros quadrados
            //e que a tinta é vendida em latas de 18 litros, que custam R$ 80,00. Informe ao usuário a quantidades de latas de tinta a serem compradas e o preço total.

            //// Solicita ao usuário que insira o tamanho da área a ser pintada em metros quadrados
            //Console.Write("Digite o tamanho da área a ser pintada em metros quadrados: ");
            //double areaPintadaMetrosQuadrados = Convert.ToDouble(Console.ReadLine());

            //// Define a cobertura de tinta em litros por metro quadrado
            //double coberturaTintaLitrosPorMetroQuadrado = 1.0 / 3.0;

            //// Define a capacidade da lata de tinta em litros
            //double capacidadeLataTintaLitros = 18.0;

            //// Define o preço de cada lata de tinta
            //double precoLataTinta = 80.00;

            //// Calcula a quantidade de litros de tinta necessários
            //double litrosTintaNecessarios = areaPintadaMetrosQuadrados * coberturaTintaLitrosPorMetroQuadrado;

            //// Calcula a quantidade de latas de tinta necessárias
            //int latasTintaNecessarias = (int)Math.Ceiling(litrosTintaNecessarios / capacidadeLataTintaLitros);

            //// Calcula o preço total das latas de tinta
            //double precoTotal = latasTintaNecessarias * precoLataTinta;

            //// Exibe a quantidade de latas de tinta e o preço total
            //Console.WriteLine("\nQuantidade de latas de tinta necessárias: " + latasTintaNecessarias);
            //Console.WriteLine("Preço total: R$" + precoTotal.ToString("F2"));

            // -------------------------------------------------------------------

            //16 - Escreva um algoritmo que leia o placar de um jogo da primeira fase da copa do Brasil.Caso o time de fora tenha ganho o jogo por mais de 2 gols de diferença, mostre
            //na tela uma mensagem indicando que o time de fora já se classificou para a próxima fase. Caso contrário, mostre uma mensagem indicando que os dois times irão se enfrentar novamente em um novo jogo.
            //ex: time da casa 4 x 3 time de fora, mostra "Os dois times se enfrentarão em um novo jogo"
            //ex2: time da casa 1 x 3 time de fora, mostra "O time de fora já se classificou"
            //plus: caso ocorra um segundo jogo, leia o placar desse novo jogo e então diga quem passou de fase.

            int placarCasa, placarFora;

            // Solicita ao usuário que insira o placar do primeiro jogo
            Console.Write("Digite o placar do primeiro jogo (1x2): ");
            string placar = Console.ReadLine();

            string[] placarParts = placar.Split('x');

            if (placarParts.Length != 2)
            {
                Console.WriteLine("Formato de placar inválido. Use o formato '1x2'.");
                return;
            }

            if (!int.TryParse(placarParts[0], out placarCasa) || !int.TryParse(placarParts[1], out placarFora))
            {
                Console.WriteLine("Placar inválido. Use números inteiros.");
                return;
            }

            // Verifica se o time de fora ganhou por mais de 2 gols de diferença
            if (placarFora > placarCasa + 2)
            {
                Console.WriteLine("O time de fora já se classificou para a próxima fase.");
            }
            else
            {
                Console.WriteLine("Os dois times se enfrentarão em um novo jogo.");
                Console.Write("Insira o placar do segundo jogo (1x2): ");
                placar = Console.ReadLine();

                placarParts = placar.Split('x');

                if (placarParts.Length != 2)
                {
                    Console.WriteLine("Formato de placar inválido. Use o formato '1x2'.");
                    return;
                }

                if (!int.TryParse(placarParts[0], out placarCasa) || !int.TryParse(placarParts[1], out placarFora))
                {
                    Console.WriteLine("Placar inválido. Use números inteiros.");
                    return;
                }

                if (placarCasa > placarFora)
                {
                    Console.WriteLine("O time da casa passou de fase.");
                }
                else if (placarFora > placarCasa)
                {
                    Console.WriteLine("O time de fora passou de fase.");
                }
                else
                {
                    Console.WriteLine("Os times empataram. Não houve classificação.");
                }
            }
























        }
    }
}