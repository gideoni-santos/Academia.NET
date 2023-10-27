using System.Collections.Generic;

namespace exercicio_POO_Alexandre
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Atleta> listaAtletas = new List<Atleta>();

            do
            {
                Console.WriteLine("Menu Padel");
                Console.WriteLine("1 - Cadastrar Atleta");
                Console.WriteLine("2 - Listar Atletas");
                Console.WriteLine("3 - Remover Atleta");
                Console.WriteLine("7 - Sair");
                Console.Write("Opção: ");
                opcao = Console.ReadLine();


                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Cadastro");
                        Comunicacao.cadastrarAtleta(listaAtletas);
                        //Persistencia.gravarAtleta(listaAtletas)

                        break;

                    case "2":
                        Console.WriteLine("Listagem de atletas");
                        Comunicacao.listarAtletas(listaAtletas);

                        break;

                    case "3":
                        Console.WriteLine("Remoção de atleta");
                        Comunicacao.removerAtletas(listaAtletas);
                        break;

                    case "7":
                        break;




                }















            } while (true);











        }
    }
}