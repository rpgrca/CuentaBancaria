using System;
using Xunit;

namespace oop
{
    public class CajeroDebe
    {
        [Fact]
        public void DepositarDineroEnCajaDeAhorro()
        {
            var cajaDeAhorro = new CajaDeAhorro();
            var sut = new Cajero();
            sut.DepositarEn(cajaDeAhorro, 1000);

            Assert.Equal(1000, sut.ConsultarSaldoDe(cajaDeAhorro));
        }

        [Fact]
        public void ExtraerDineroDeCajaDeAhorro()
        {
            var cajaDeAhorro = new CajaDeAhorro();
            var sut = new Cajero();
            sut.DepositarEn(cajaDeAhorro, 1000);
            sut.ExtraderDe(cajaDeAhorro, 250);

            Assert.Equal(750, sut.ConsultarSaldoDe(cajaDeAhorro));
        }
    }
}