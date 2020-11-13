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

        [Fact]
        public void AgregarSumaDeDinero()
        {
            var sut = Saldo.DeMasDe(0);
            var sumaDeDinero = SumaDeDinero.De(150);
            var nuevoSaldo = sut.Agregar(sumaDeDinero);

            Assert.True(nuevoSaldo.Es(150));
        }

        [Fact]
        public void SustraerSumaDeDinero()
        {
            var sut = Saldo.DeMasDe(-1000);
            var sumaDeDinero = SumaDeDinero.De(600);
            var nuevoSaldo = sut.Sustraer(sumaDeDinero);

            Assert.True(nuevoSaldo.Es(-600));
        }
    }
}