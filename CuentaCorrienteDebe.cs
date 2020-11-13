using System;
using Xunit;

namespace oop
{
    public class CuentaCorrienteDebe
    {
        [Fact]
        public void TenerSaldoDeCeroPesos_CuandoSeCrea()
        {
            var sut = GetSubjectUnderTest();
            Assert.Equal(0, sut.Saldo);
        }

        private static CuentaCorriente GetSubjectUnderTest() => new CuentaCorriente();

        [Theory]
        [InlineData(1000)]
        [InlineData(450)]
        public void AcumularDineroEnSaldo_CuandoSeDepositaUnaSumaDePesos(int unaCantidadDeDinero)
        {
            var sut = GetSubjectUnderTest();
            sut.Depositar(unaCantidadDeDinero);
            Assert.Equal(unaCantidadDeDinero, sut.Saldo);
        }
    }
}