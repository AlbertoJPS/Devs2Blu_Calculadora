using Xunit;
using Calculadora_Team3;
using Calculadora_Team3.Interfaces;
using System;

namespace Calculadora_Team3.Tests
{
    public class CalculadoraCientificaTests
    {
        [Fact]
        public void Potencia_BaseElevadaAExpoente_DeveRetornarResultadoCorreto()
        {
            // Arrange (Organizar)
            ICalculadoraCientifica calculadora = new CalculadoraCientifica();
            double baseNum = 2;
            double expoente = 10;
            double esperado = 1024;

            // Act (Agir)
            double resultado = calculadora.Potencia(baseNum, expoente);

            // Assert (Verificar)
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void Seno_ParaAnguloDe30Graus_DeveRetornarMeio()
        {
            // Arrange
            ICalculadoraCientifica calculadora = new CalculadoraCientifica();
            double anguloGraus = 30;
            double esperado = 0.5;

            // Act
            double resultado = calculadora.Seno(anguloGraus);

            // Assert
            Assert.Equal(esperado, resultado, 5);
        }

        [Fact]
        public void Cosseno_ParaAnguloDe60Graus_DeveRetornarMeio()
        {
            // Arrange
            ICalculadoraCientifica calculadora = new CalculadoraCientifica();
            double anguloGraus = 60;
            double esperado = 0.5;

            // Act
            double resultado = calculadora.Coseno(anguloGraus);

            // Assert
            Assert.Equal(esperado, resultado, 5);
        }

        [Fact]
        public void Tangente_ParaAnguloDe45Graus_DeveRetornarUm()
        {
            // Arrange
            ICalculadoraCientifica calculadora = new CalculadoraCientifica();
            double anguloGraus = 45;
            double esperado = 1;

            // Act
            double resultado = calculadora.Tangente(anguloGraus);

            // Assert
            Assert.Equal(esperado, resultado, 5);
        }

        [Fact]
        public void Log_LogaritmoBase10De100_DeveRetornarDois()
        {
            // Arrange
            ICalculadoraCientifica calculadora = new CalculadoraCientifica();
            double numero = 100;
            double esperado = 2;

            // Act
            double resultado = calculadora.Logaritmo(numero);

            // Assert
            Assert.Equal(esperado, resultado);
        }
    }
}