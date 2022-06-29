using NutriVitta;
using Xunit;

namespace TestXUnit
{
    public class UnitTest1
    {
        [Fact]
        public void TestaIMC()
        {
            // Arrange
            double peso = 108;
            double altura = 1.50;
            double imc = 48.0;

            //Act

            var resultado = CauculadoraIMC.Imc(peso, altura);

            //Assert
            Assert.Equal(imc, resultado);
        }

        [Fact]
        public void TestaClassificacaoIMC()
        {
            //Arrange
            double imc = 48;
            string classificacao = "Obesidade grau III";

            //Act

            var resultado = CauculadoraIMC.ClassificacaoIMC(imc);

            //Assert
            Assert.Equal(classificacao, resultado);

        }

        [Theory]
        [InlineData(36, 1.50, 16)]
        [InlineData(29, 1.0, 29)]
        [InlineData(97.2, 1.8, 30)]
        [InlineData(115.6, 1.7, 40)]
        public void TestaImcEmLista(double peso, double altura, double imc)
        {
             //Act

            var resultado = CauculadoraIMC.Imc(peso, altura);
            

            //Assert
            Assert.Equal(imc, resultado);
        }

        [Theory]
        [InlineData(16, "Abaixo do peso")]
        [InlineData(29, "Sobrepeso")]
        [InlineData(30, "Obesidade grau I")]
        [InlineData(40, "Obesidade grau III")]
        public void TestaClassificacaoImcEmLista(double imc, string classificacao)
        {
            //Act

            var resultado = CauculadoraIMC.ClassificacaoIMC(imc);


            //Assert
            Assert.Equal(classificacao, resultado);
        }

    }
}