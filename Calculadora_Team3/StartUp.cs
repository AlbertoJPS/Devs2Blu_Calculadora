

//Calculadora time 3

using System;
using Calculadora_Team3.Utils;

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
                        Console.Clear();
                        Console.WriteLine("======================================");
                        Console.WriteLine("    BEM-VINDO À CALCULADORA NORMAL    ");
                        Console.WriteLine("======================================");
                        Console.WriteLine("");
                        Console.WriteLine("1 - Soma");
                        Console.WriteLine("2 - Subtração");
                        Console.WriteLine("3 - Divisão");
                        Console.WriteLine("4 - Multiplicação");
                        Console.WriteLine("");
                        Console.Write("Digite a operação que deseja executar: ");
                        string escolhaOperacao = Console.ReadLine();
                        var calculadoraNormal =  new CalculadoraNormal();                        

                        switch (escolhaOperacao)
                        {
                            case "1":
                                Console.Write("Digite o primeiro número da operação: ");
                                var valor1 =  UtilsClass.ValidarEntrada(Console.ReadLine());                       
                                Console.Write("Digite o segundo número da operação: ");
                                var valor2 = UtilsClass.ValidarEntrada(Console.ReadLine());
                                Console.WriteLine($"A soma dos números {valor1} e {valor2} é {calculadoraNormal.Add(valor1, valor2)}");
                                Console.ReadKey();
                                break;
                            case "2":
                                Console.Write("Digite o primeiro número da operação: ");
                                valor1 = UtilsClass.ValidarEntrada(Console.ReadLine());
                                Console.Write("Digite o segundo número da operação: ");
                                valor2 = UtilsClass.ValidarEntrada(Console.ReadLine());
                                Console.WriteLine($"A subtração dos números {valor1} e {valor2} é {calculadoraNormal.Subtract(valor1, valor2)}");
                                Console.ReadKey();
                                break;
                            case "3":
                                Console.Write("Digite o primeiro número da operação: ");
                                valor1 = UtilsClass.ValidarEntrada(Console.ReadLine());
                                Console.Write("Digite o segundo número da operação: ");
                                valor2 = UtilsClass.ValidarEntrada(Console.ReadLine());
                                Console.WriteLine($"A divisão dos números {valor1} e {valor2} é {calculadoraNormal.Divide(valor1, valor2)}");
                                Console.ReadKey();
                                break;
                            case "4":
                                Console.Write("Digite o primeiro número da operação: ");
                                valor1 = UtilsClass.ValidarEntrada(Console.ReadLine());
                                Console.Write("Digite o segundo número da operação: ");
                                valor2 = UtilsClass.ValidarEntrada(Console.ReadLine());
                                Console.WriteLine($"A multiplicação dos números {valor1} e {valor2} é {calculadoraNormal.Multiply(valor1, valor2)}");
                                Console.ReadKey();
                                break;
                        }
                        break;

                    case "2":
                        // Futuramente, aqui chamaremos a lógica da Calculadora Científica
                        Console.WriteLine("\nVocê selecionou a Calculadora Científica.");
                        Console.Clear();
                        Console.WriteLine("======================================");
                        Console.WriteLine("  BEM-VINDO À CALCULADORA CIENTIFICA  ");
                        Console.WriteLine("======================================");
                        Console.WriteLine("");
                        var menuCientifica = new MenuCalculadoraCientífica();
                        menuCientifica.ExibirMenu();
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