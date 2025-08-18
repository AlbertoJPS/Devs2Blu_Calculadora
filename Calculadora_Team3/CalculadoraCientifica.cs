using Calculadora_Team3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Team3
{
    internal class CalculadoraCientifica : ICalculadoraCientifica
    {
        public double Add(double a, double b)
        {
            throw new NotImplementedException();
        }

        public double Coseno(double a, double b)
        {
            throw new NotImplementedException();
        }

        public double Divide(double a, double b)
        {
            throw new NotImplementedException();
        }

        public double Logaritmo(double a)
        {
            return Math.Log10((double)a);
        }

        public double Multiply(double a, double b)
        {
            throw new NotImplementedException();
        }

        public double Potência(double a, double b)
        {
            return Math.Pow(a, b); //a elevado a potência de b
        }

        public double Seno(double a, double b)
        {
            throw new NotImplementedException();
        }

        public double Subtract(double a, double b)
        {
            throw new NotImplementedException();
        }

        public double Tangente(double a, double b)
        {
            throw new NotImplementedException();
        }
    }
}
