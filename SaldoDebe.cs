using System;
using Xunit;

namespace oop
{
    public class SaldoDebe
    {
        [Fact]
        public void InicializarseEnCero_CuandoNoSeAsignaUnValorInicialExplicito()
        {
            var sut = Saldo.DeMasDe(0);
            Assert.Equal(0, sut.Total);
        }

        [Fact]
        public void InicializarseEnElValorDado_CuandoSeDaUnValorExplicito()
        {
            var sut = Saldo.DeMasDe(0, 10);
            Assert.Equal(10, sut.Total);
        }

        [Fact]
        public void LanzarExcepcion_CuandoElValorInicialEsMenorAlSaldoMinimo()
        {
            var exception = Assert.Throws<ArgumentException>(() => Saldo.DeMasDe(1000, 100));
            Assert.Equal(Saldo.TOTAL_NO_PUEDE_QUEDAR_POR_DEBAJO_DEL_MINIMO, exception.Message);
        }
    }
}