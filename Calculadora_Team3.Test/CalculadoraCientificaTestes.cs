using System;
using Xunit;

namespace Calculadora_Team3.Tests
{
    public class CalculadoraCientificaTests
    {
        // NOTA IMPORTANTE:
        // A classe Math do C# usa RADIANOS, não graus.
        // Como sua implementação passa o valor direto para Math.Sin, etc.,
        // os testes precisam fornecer os ângulos em radianos para validar os resultados.

        [Fact]
        public void Seno_ParaAnguloEmRadianos_DeveRetornarResultadoCorreto()
        {
            // Arrange
            var calculadora = new CalculadoraCientifica();
            // 30 graus = PI / 6 radianos. O seno de 30 graus é 0.5.
            double anguloRadianos = Math.PI / 6;
            double esperado = 0.5;

            // Act
            double resultado = calculadora.Seno(anguloRadianos);

            // Assert
            Assert.Equal(esperado, resultado, 5); // Comparando com 5 casas de precisão
        }

        [Fact]
        public void Coseno_ParaAnguloEmRadianos_DeveRetornarResultadoCorreto()
        {
            // Arrange
            var calculadora = new CalculadoraCientifica();
            // 60 graus = PI / 3 radianos. O cosseno de 60 graus é 0.5.
            double anguloRadianos = Math.PI / 3;
            double esperado = 0.5;

            // Act
            double resultado = calculadora.Coseno(anguloRadianos);

            // Assert
            Assert.Equal(esperado, resultado, 5);
        }

        [Fact]
        public void Tangente_ParaAnguloEmRadianos_DeveRetornarResultadoCorreto()
        {
            // Arrange
            var calculadora = new CalculadoraCientifica();
            // 45 graus = PI / 4 radianos. A tangente de 45 graus é 1.
            double anguloRadianos = Math.PI / 4;
            double esperado = 1;

            // Act
            double resultado = calculadora.Tangente(anguloRadianos);

            // Assert
            Assert.Equal(esperado, resultado, 5);
        }
    }
}