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
    }
}