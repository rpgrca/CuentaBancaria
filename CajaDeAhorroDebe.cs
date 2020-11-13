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

        [Fact]
        public void AcumularDineroEnSaldo_CuandoSeRealizanMultiplesDepositos()
        {
            var sut = GetSubjectUnderTest();
            sut.Depositar(450);
            sut.Depositar(1000);
            Assert.Equal(1450, sut.Saldo);
        }
    }
}