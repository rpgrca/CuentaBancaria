using System;
using Xunit;

namespace CuentaBancaria.UnitTests
{
    public class CajeroDebe
    {
        [Fact]
        public void DepositarDineroEnCajaDeAhorro()
        {
            var cajaDeAhorro = new CajaDeAhorro();
            var sut = new Cajero();
            sut.DepositarEn(cajaDeAhorro, SumaDeDinero.De(1000));

            Assert.Equal(1000, sut.ConsultarSaldoDe(cajaDeAhorro));
        }

        [Fact]
        public void ExtraerDineroDeCajaDeAhorro()
        {
            var cajaDeAhorro = new CajaDeAhorro();
            var sut = new Cajero();
            sut.DepositarEn(cajaDeAhorro, SumaDeDinero.De(1000));
            sut.ExtraderDe(cajaDeAhorro, SumaDeDinero.De(250));

            Assert.Equal(750, sut.ConsultarSaldoDe(cajaDeAhorro));
        }

        [Fact]
        public void DepositarDineroEnCuentaCorriente()
        {
            var cuentaCorriente = new CuentaCorriente();
            var sut = new Cajero();
            sut.DepositarEn(cuentaCorriente, SumaDeDinero.De(1000));

            Assert.Equal(1000, sut.ConsultarSaldoDe(cuentaCorriente));
        }

        [Fact]
        public void ExtraerDineroDeCuentaCorriente()
        {
            var cuentaCorriente = new CuentaCorriente();
            var sut = new Cajero();
            sut.DepositarEn(cuentaCorriente, SumaDeDinero.De(1000));
            sut.ExtraderDe(cuentaCorriente, SumaDeDinero.De(250));

            Assert.Equal(750, sut.ConsultarSaldoDe(cuentaCorriente));
        }

        [Fact]
        public void LanzarExcepcion_CuandoSeExtraeDeMasDeCajaDeAhorro()
        {
            var cajaDeAhorro = new CajaDeAhorro();
            var sut = new Cajero();
            var exception = Assert.Throws<ArgumentException>(() => sut.ExtraderDe(cajaDeAhorro, SumaDeDinero.De(1)));
            Assert.Equal(CajaDeAhorro.NO_SE_PUEDE_EXTRAER_MAS_QUE_EL_SALDO, exception.Message);
        }

        [Fact]
        public void DejarSaldoNegativo_CuandoSeExtraeDeMasDeCuentaCorriente()
        {
            var cuentaCorriente = new CuentaCorriente();
            var sut = new Cajero();
            sut.ExtraderDe(cuentaCorriente, SumaDeDinero.De(1));
            Assert.Equal(-1, sut.ConsultarSaldoDe(cuentaCorriente));
        }
    }
}