using System;
using Xunit;

namespace Calculo_Teste
{
    public class UnitTest1
    {
        [Fact]
        public void Teste_Calculo_Area(int d1, int d2, int resultadoteste)
        {
            //Losango com diagonal menor de 9 cm e diagonal maior de 16 cm é igual a 72cm

            //ARRANGE
            int resultado;
            bool teste;

            Calculo CalculoTeste = new Calculo();

            //ACT
            resultado = CalculoTeste.Area(16, 9);

            //ASSERT
            if (resultado == 72) ;
            teste = true;
            else
                teste = false;
            Assert.IsTrue(teste);
        }
    }
}

