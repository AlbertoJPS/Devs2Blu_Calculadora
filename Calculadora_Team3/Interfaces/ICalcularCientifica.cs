using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora_Team3.Interfaces
{
    public interface ICalcularCientifica : ICalculator
    {
        double Seno(double angle);
        double Coseno(double angle);
        double Tangente(double angle);
    }
}