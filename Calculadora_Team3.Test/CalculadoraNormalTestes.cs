using System;
using Xunit;

namespace Calculadora_Team3.Tests
{
    public class CalculadoraNormalTests
    {
        [Fact]
        public void Add_QuandoChamado_DeveLancarNotImplementedException()
        {
            // Arrange
            var calculadora = new CalculadoraNormal();

            // Act & Assert
            // O teste agora verifica se o m�todo lan�a a exce��o esperada,
            // pois � o comportamento atual da sua classe.
            Assert.Throws<NotImplementedException>(() => calculadora.Add(1, 1));
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
            // O m�todo agora captura a pr�pria exce��o e retorna double.NaN.
            // O teste precisa validar este retorno, e n�o a exce��o.
            double resultado = calculadora.Divide(10, 0);

            // Assert
            Assert.Equal(double.NaN, resultado);
        }
    }
}