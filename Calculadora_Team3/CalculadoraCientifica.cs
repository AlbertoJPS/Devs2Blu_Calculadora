using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora_Team3.Interfaces;

namespace Calculadora_Team3
{
    public class CalculadoraCientifica : CalculadoraNormal, ICalcularCientifica
    {
        public double Seno(double angle)
        {
            return Math.Sin(angle);
        }
        public double Coseno(double angle)
        {
            return Math.Cos(angle);
        }
        public double Tangente(double angle)
        {
            return Math.Tan(angle);
        }
    }
}