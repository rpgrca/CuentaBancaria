using System;
using Xunit;

namespace CuentaBancaria.UnitTests
{
    public class SaldoDebe
    {
        [Fact]
        public void InicializarseEnElValorDado_CuandoSeDaUnValorExplicito()
        {
            var sut = Saldo.DeMasDe(0, 10, () => {});
            Assert.Equal(10, sut.Total);
        }

        [Fact]
        public void LanzarExcepcion_CuandoElValorInicialEsMenorAlSaldoMinimo()
        {
            var exception = Assert.Throws<ArgumentException>(() => Saldo.DeMasDe(1000, 100, () => throw new ArgumentException("Pasa por aca")));
            Assert.Equal("Pasa por aca", exception.Message);
        }

        [Fact]
        public void AgregarSumaDeDinero()
        {
            var sut = Saldo.DeMasDe(0, 0, () => {});
            var sumaDeDinero = SumaDeDinero.De(150);
            var nuevoSaldo = sut.Agregar(sumaDeDinero);

            Assert.Equal(150, nuevoSaldo.Total);
        }

        [Fact]
        public void SustraerSumaDeDinero()
        {
            var sut = Saldo.DeMasDe(-1000, 0, () => {});
            var sumaDeDinero = SumaDeDinero.De(600);
            var nuevoSaldo = sut.Sustraer(sumaDeDinero);

            Assert.Equal(-600, nuevoSaldo.Total);
        }
    }
}