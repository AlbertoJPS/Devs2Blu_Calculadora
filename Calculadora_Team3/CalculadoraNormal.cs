using Calculadora_Team3.Interfaces;
using System;


namespace Calculadora_Team3
{
    public class CalculadoraNormal : ICalculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Divide(double a, double b)
        {
            try
            {
                if (b == 0)
                {
                    throw new DivideByZeroException("Operação inválida: Divisão por zero não é possível.");
                }
                return a / b;
            }
            catch (DivideByZeroException error)
            {
                Console.WriteLine(error.Message);
                return double.NaN; // Retorna NaN para indicar erro na divisão
            }
        }

        public double Multiply(double a, double b)
        {
            return (a * b);
        }

        public double Subtract(double a, double b)
        {
            return (a - b);
        }
    }
}
