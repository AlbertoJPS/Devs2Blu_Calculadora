

//Calculadora time 3

using System;

namespace Calculadora_Team3
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            // Loop para manter o menu ativo até o usuário decidir sair
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=================================");
                Console.WriteLine("    BEM-VINDO À CALCULADORA    ");
                Console.WriteLine("=================================");
                Console.WriteLine();
                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("1 - Calculadora Normal");
                Console.WriteLine("2 - Calculadora Científica");
                Console.WriteLine("S - Sair");
                Console.WriteLine();
                Console.Write("Digite sua escolha: ");

                string opcao = Console.ReadLine();

                switch (opcao.ToUpper()) 
                {
                    case "1":
                        // Futuramente, aqui chamaremos a lógica da Calculadora Normal
                        Console.WriteLine("\nVocê selecionou a Calculadora Normal.");
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case "2":
                        // Futuramente, aqui chamaremos a lógica da Calculadora Científica
                        Console.WriteLine("\nVocê selecionou a Calculadora Científica.");
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case "S":
                        Console.WriteLine("\nObrigado por usar a calculadora. Saindo...");
                        return; // Encerra a aplicação

                    default:
                        Console.WriteLine("\nOpção inválida! Por favor, escolha 1, 2 ou S.");
                        Console.WriteLine("Pressione qualquer tecla para tentar novamente...");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}