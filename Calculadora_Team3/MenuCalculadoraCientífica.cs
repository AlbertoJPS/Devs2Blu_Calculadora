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
            Console.WriteLine("4 - Sair");

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
                    Console.WriteLine("Saindo da calculadora científica.");
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            ExibirMenu(); // Chama o menu novamente após a operação
        }
    }
}