using Calculadora_;
using System;
using Xunit;

namespace Calculo_Teste
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(2,5,5)]
        public void Teste_Calculo_Area(int d1, int d2, int resultadoteste)
        {
            //Losango com diagonal menor de 9 cm e diagonal maior de 16 cm é igual a 72cm

            //ARRANGE
            int resultado;

            Calculo CalculoTeste = new Calculo();

            //ACT
            resultado = CalculoTeste.Area(d1, d2);

            //ASSERT
            Assert.Equal(resultado, resultadoteste);
        }
    }
}

