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

        [Fact]
        public void AcumularDineroEnSaldo_CuandoSeRealizanMultiplesDepositos()
        {
            var sut = GetSubjectUnderTest();
            sut.Depositar(1000);
            sut.Depositar(450);
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
        public void LanzarExcepcion_CuandoSeExtraeMasDineroQueElLimiteExistente()
        {
            var sut = GetSubjectUnderTest();
            var exception = Assert.Throws<ArgumentException>(() => sut.Extraer(1000));
            Assert.Equal(CuentaCorriente.NO_SE_PUEDE_EXTRAER_MAS_ALLA_DEL_LIMITE, exception.Message);
        }
    }
}