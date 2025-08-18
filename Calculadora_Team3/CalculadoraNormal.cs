using Calculadora_Team3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Team3
{
    internal class Calcular : ICalculator
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
                    Console.WriteLine("Operação inválida: Divisão por zero não é possível.");
                }
                return a / b;
            }
            catch (DivideByZeroException error)
            {
                Console.WriteLine(error.Message);
                return double.NaN; 
            }
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }
    }
}
