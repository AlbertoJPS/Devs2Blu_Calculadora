using Xunit;
using Calculadora_Team3;
using Calculadora_Team3.Interfaces;

namespace Calculadora_Team3.Tests
{
    public class CalculadoraNormalTests
    {
        // Padrão de nomenclatura: MetodoTestado_Condicao_ResultadoEsperado

        [Fact]
        public void Add_DoisNumerosPositivos_DeveRetornarSomaCorreta()
        {
            // Arrange (Organizar)
            var calculadora = new CalculadoraNormal();
            double a = 5;
            double b = 7;
            double esperado = 12;

            // Act (Agir)
            double resultado = calculadora.Add(a, b);

            // Assert (Verificar)
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void Subtract_DoisNumeros_DeveRetornarDiferencaCorreta()
        {
            // Arrange
            var calculadora = new CalculadoraNormal();
            double a = 10;
            double b = 4;
            double esperado = 6;

            // Act
            double resultado = calculadora.Subtract(a, b);

            // Assert
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void Multiply_DoisNumeros_DeveRetornarProdutoCorreto()
        {
            // Arrange
            var calculadora = new CalculadoraNormal();
            double a = 3;
            double b = 8;
            double esperado = 24;

            // Act
            double resultado = calculadora.Multiply(a, b);

            // Assert
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void Divide_NumeroPorOutro_DeveRetornarQuocienteCorreto()
        {
            // Arrange
            var calculadora = new CalculadoraNormal();
            double a = 20;
            double b = 5;
            double esperado = 4;

            // Act
            double resultado = calculadora.Divide(a, b);

            // Assert
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void Divide_DivisaoPorZero_DeveLancarExcecao()
        {
            // Arrange
            var calculadora = new CalculadoraNormal();

            // Act & Assert
            // Verifica se a ação de dividir 10 por 0 lança EXATAMENTE uma exceção do tipo DivideByZeroException
            Assert.Throws<System.DivideByZeroException>(() => calculadora.Divide(10, 0));
        }

        [Theory]
        [InlineData(5, 7, 12)]         // Caso 1: Positivos
        [InlineData(-10, 5, -5)]       // Caso 2: Com negativo
        [InlineData(10, -10, 0)]       // Caso 3: Soma com oposto
        [InlineData(2.5, 2.5, 5.0)]    // Caso 4: Com decimais
        [InlineData(0, 0, 0)]          // Caso 5: Com zeros
        public void Add_VariosCenarios_DeveRetornarSomaCorreta(double a, double b, double esperado)
        {
            // Arrange
            var calculadora = new CalculadoraNormal();

            // Act
            double resultado = calculadora.Add(a, b);

            // Assert
            Assert.Equal(esperado, resultado);
        }
    }
}