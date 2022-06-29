using ProjetoTesteSenai;
using Xunit;

namespace TestXUnit
{
    public class UnitTest1
    {
        [Fact]
        public void SomarDoisNumeros()
        {
            //Arrange
            double pNum = 1;
            double sNum = 2;
            double rNum = 3;

            //Act
            var resultado = Operacoes.Somar(pNum, sNum);

            //Assert

            Assert.Equal(rNum, resultado);
        }

        [Theory] // Faz um laço de repetição testando novos valores:
        [InlineData(1, 1, 2)]
        [InlineData(6, 16, 22)]
        [InlineData(-5, -15, -20)]
        [InlineData(-20, 25, 5)]
        [InlineData(25, -20, 5)]
        [InlineData(1, 2, 1)] //P/testar se pega o erro (resultado deveria ser 3)

        public void SomarDoisNumerosLista(double pNum, double sNum, double rNum) 
        {
            //Act
            var resultado = Operacoes.Somar(pNum, sNum);

            //Assert
            Assert.Equal(rNum, resultado);

        }

    }
}