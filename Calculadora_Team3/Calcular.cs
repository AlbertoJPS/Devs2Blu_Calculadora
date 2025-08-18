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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public double Subtract(double a, double b)
        {
            throw new NotImplementedException();
        }
    }
}
