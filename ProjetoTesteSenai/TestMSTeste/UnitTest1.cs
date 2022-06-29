using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetoTesteSenai;

namespace TestMSTeste
{
    [TestClass]
    public class UnitTest1 // Teste unit�rio: Testa um m�todo de cada vez
    {
        [TestMethod]
        public void TestaSomaDoisNumeros()
        {
            // Arrange - Prepara��o
            double pNum = 1;
            double sNum = 1;
            double rNum = 2;

            // Act - A��o
            var resultado = Operacoes.Somar(pNum, sNum);

            //Assert - Verifica��o
            Assert.AreEqual(rNum, resultado);
        }

        [DataTestMethod] // Faz um la�o de repeti��o testando novos valores:
        [DataRow(1, 1, 2)]
        [DataRow(6, 16, 22)]
        [DataRow(-5, -15, -20)]
        [DataRow(-20, 25, 5)]
        [DataRow(25, -20, 5)]
        [DataRow(1, 2, 1)] //P/testar se pega o erro (resultado deveria ser 3)
        public void SomarDoisNumerosLista(double pNum, double sNum, double rNum) 
        {
            // Act 
            var resultado = Operacoes.Somar(pNum, sNum);

            //Assert
            Assert.AreEqual(rNum, resultado);

        }
    }
}