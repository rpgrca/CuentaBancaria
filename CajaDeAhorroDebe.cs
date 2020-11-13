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
            Assert.Equal(0, sut.ConsultarSaldo());
        }

        private static CajaDeAhorro GetSubjectUnderTest() => new CajaDeAhorro();

        [Theory]
        [InlineData(450)]
        [InlineData(1000)]
        public void AcumularDineroEnSaldo_CuandoSeDepositanUnaSumaDePesos(int unaSumaDePesos)
        {
            var sut = GetSubjectUnderTest();
            sut.Depositar(SumaDeDinero.De(unaSumaDePesos));
            Assert.Equal(unaSumaDePesos, sut.ConsultarSaldo());
        }

        [Fact]
        public void AcumularDineroEnSaldo_CuandoSeRealizanMultiplesDepositos()
        {
            var sut = GetSubjectUnderTest();
            sut.Depositar(SumaDeDinero.De(450));
            sut.Depositar(SumaDeDinero.De(1000));
            Assert.Equal(1450, sut.ConsultarSaldo());
        }

        [Theory]
        [InlineData(1000, 250, 750)]
        [InlineData(1000, 1000, 0)]
        public void DescontarDineroDelSaldo_CuandoSeRealizaUnaExtraccion(decimal saldoInicial, decimal unaCantidadAExtraer, decimal saldoEsperado)
        {
            var sut = GetSubjectUnderTest();
            sut.Depositar(SumaDeDinero.De(saldoInicial));
            sut.Extraer(SumaDeDinero.De(unaCantidadAExtraer));
            Assert.Equal(saldoEsperado, sut.ConsultarSaldo());
        }

        [Fact]
        public void LanzarExcepcion_CuandoSeExtraeMasDineroQueElSaldoExistente()
        {
            var sut = GetSubjectUnderTest();
            var exception = Assert.Throws<ArgumentException>(() => sut.Extraer(SumaDeDinero.De(1000)));
            Assert.Equal(CajaDeAhorro.NO_SE_PUEDE_EXTRAER_MAS_QUE_EL_SALDO, exception.Message);
        }
   }
}