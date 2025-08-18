using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Team3.Interfaces
{
    internal interface ICalculadoraCientifica : ICalculator
    {
        double Seno (double a, double b);
        double Coseno (double a, double b);
        double Tangente (double a, double b);
        double Logaritmo (double a, double b);
        double Potência (double a, double b);
    }
}
