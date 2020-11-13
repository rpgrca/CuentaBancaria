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

        [Theory]
        [InlineData(1000, 250, 750)]
        [InlineData(1000, 1000, 0)]
        public void DescontarDineroDelSaldo_CuandoSeRealizaUnaExtraccion(decimal saldoInicial, decimal unaCantidadAExtraer, decimal saldoEsperado)
        {
            var sut = GetSubjectUnderTest();
            sut.Depositar(saldoInicial);
            sut.Extraer(unaCantidadAExtraer);
            Assert.Equal(saldoEsperado, sut.Saldo);
        }

        [Fact]
        public void LanzarExcepcion_CuandoSeExtraeMasDineroQueElSaldoExistente()
        {
            var sut = GetSubjectUnderTest();
            var exception = Assert.Throws<ArgumentException>(() => sut.Extraer(1000));
            Assert.Equal(CajaDeAhorro.NO_SE_PUEDE_EXTRAER_MAS_QUE_EL_SALDO, exception.Message);
        }

        [Fact]
        public void LanzarExcepcion_CuandoSeDepositaUnaCantidadNegativa()
        {
            var sut = GetSubjectUnderTest();
            var exception = Assert.Throws<ArgumentException>(() => sut.Depositar(-1));
            Assert.Equal(CajaDeAhorro.NO_SE_PUEDE_DEPOSITAR_UNA_DEUDA, exception.Message);
        }

        [Fact]
        public void LanzarExcepcion_CuandoSeExtraeUnaCantidadNegativa()
        {
            var sut = GetSubjectUnderTest();
            var exception = Assert.Throws<ArgumentException>(() => sut.Extraer(-1));
            Assert.Equal(CajaDeAhorro.NO_SE_PUEDE_EXTRAER_UNA_DEUDA, exception.Message);
        }
    }
}