using System;
using Xunit;

namespace oop
{
    public class CajaDeAhorroDebe
    {
        [Fact]
        public void TenerSaldoDeCeroPesos_CuandoSeCrea()
        {
            var sut = GetSubjectUnderTest();
            Assert.Equal(0, sut.Saldo);
        }

        private static CajaDeAhorro GetSubjectUnderTest() => new CajaDeAhorro();

        [Theory]
        [InlineData(450)]
        [InlineData(1000)]
        public void AcumularDineroEnSaldo_CuandoSeDepositanUnaSumaDePesos(int unaSumaDePesos)
        {
            var sut = GetSubjectUnderTest();
            sut.Depositar(unaSumaDePesos);
            Assert.Equal(unaSumaDePesos, sut.Saldo);
        }
   }
}