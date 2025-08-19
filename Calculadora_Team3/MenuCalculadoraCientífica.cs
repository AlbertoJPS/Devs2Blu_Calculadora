using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora_Team3
{
    public class MenuCalculadoraCientífica : CalculadoraCientifica
    {
        public void ExibirMenu()
        {
            Console.WriteLine("Escolha uma das seguintes opções:");
            Console.WriteLine("1 - Seno");
            Console.WriteLine("2 - Cosseno");
            Console.WriteLine("3 - Tangente");
            Console.WriteLine("4 - Somar");
            Console.WriteLine("5 - Subtrair");
            Console.WriteLine("6 - Multiplicar");
            Console.WriteLine("7 - Dividir");
            Console.WriteLine("8 - Sair");
            Console.WriteLine("8 - Sair\n");

            Console.Write("Escolha uma das opções:");

            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite o ângulo em radianos: ");
                    double anguloSeno = Convert.ToDouble(Console.ReadLine());
                    double resultadoSeno = Seno(anguloSeno);
                    Console.WriteLine($"Seno({anguloSeno}) = {resultadoSeno}");
                    break;
                case 2:
                    Console.Write("Digite o ângulo em radianos: ");
                    double anguloCosseno = Convert.ToDouble(Console.ReadLine());
                    double resultadoCosseno = Coseno(anguloCosseno);
                    Console.WriteLine($"Cosseno({anguloCosseno}) = {resultadoCosseno}");
                    break;
                case 3:
                    Console.Write("Digite o ângulo em radianos: ");
                    double anguloTangente = Convert.ToDouble(Console.ReadLine());
                    double resultadoTangente = Tangente(anguloTangente);
                    Console.WriteLine($"Tangente({anguloTangente}) = {resultadoTangente}");
                    break;
                case 4:
                    Console.Write("Digite o primeiro número: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite o segundo número: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    double resultadoSoma = Add(num1, num2);
                    Console.WriteLine($"Resultado da soma: {resultadoSoma}");
                    break;
                case 5:
                    Console.Write("Digite o primeiro número: ");
                    double num3 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite o segundo número: ");
                    double num4 = Convert.ToDouble(Console.ReadLine());
                    double resultadoSubtracao = Subtract(num3, num4);
                    Console.WriteLine($"Resultado da subtração: {resultadoSubtracao}");
                    break;
                case 6:
                    Console.Write("Digite o primeiro número: ");
                    double num5 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite o segundo número: ");
                    double num6 = Convert.ToDouble(Console.ReadLine());
                    double resultadoMultiplicacao = Multiply(num5, num6);
                    Console.WriteLine($"Resultado da multiplicação: {resultadoMultiplicacao}");
                    break;
                case 7:
                    Console.Write("Digite o primeiro número: ");
                    double num7 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite o segundo número: ");
                    double num8 = Convert.ToDouble(Console.ReadLine());
                    double resultadoDivisao = Divide(num7, num8);
                    if (double.IsNaN(resultadoDivisao))
                    {
                        Console.WriteLine("Erro: Divisão por zero não é permitida.");
                    }
                    else
                    {
                        Console.WriteLine($"Resultado da divisão: {resultadoDivisao}");
                    }
                    break;
                case 8:
                    Console.WriteLine("Saindo da calculadora científica...");
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            ExibirMenu(); // Chama o menu novamente após a operação
        }
    }
}