using System;
using Xunit;

namespace Calculadora_Team3.Tests
{
    public class CalculadoraNormalTests
    {
        [Fact]
        public void Add_DoisNumeros_DeveRetornarSomaCorreta()
        {
            // Arrange
            var calculadora = new CalculadoraNormal();
            double a = 5;
            double b = 7;
            double esperado = 12;

            // Act
            double resultado = calculadora.Add(a, b);

            // Assert
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void Subtract_DoisNumeros_DeveRetornarDiferencaCorreta()
        {
            // Arrange
            var calculadora = new CalculadoraNormal();

            // Act
            double resultado = calculadora.Subtract(10, 4);

            // Assert
            Assert.Equal(6, resultado);
        }

        [Fact]
        public void Multiply_DoisNumeros_DeveRetornarProdutoCorreto()
        {
            // Arrange
            var calculadora = new CalculadoraNormal();

            // Act
            double resultado = calculadora.Multiply(5, 3);

            // Assert
            Assert.Equal(15, resultado);
        }

        [Fact]
        public void Divide_NumeroValido_DeveRetornarQuocienteCorreto()
        {
            // Arrange
            var calculadora = new CalculadoraNormal();

            // Act
            double resultado = calculadora.Divide(20, 5);

            // Assert
            Assert.Equal(4, resultado);
        }

        [Fact]
        public void Divide_DivisaoPorZero_DeveRetornarNaN()
        {
            // Arrange
            var calculadora = new CalculadoraNormal();

            // Act
            // O método agora captura a própria exceção e retorna double.NaN.
            // O teste precisa validar este retorno, e não a exceção.
            double resultado = calculadora.Divide(10, 0);

            // Assert
            Assert.Equal(double.NaN, resultado);
        }
    }
}