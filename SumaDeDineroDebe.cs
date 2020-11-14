using System;
using Xunit;

namespace CuentaBancaria.UnitTests
{
    public class SumaDeDineroDebe
    {
        [Fact]
        public void RetornarSumaDeDinero_CuandoSeCreaConValorValido()
        {
            var sut = SumaDeDinero.De(1000);
            Assert.NotNull(sut);
            Assert.Equal(1000, sut.Total);
        }

        [Fact]
        public void LanzarExcepcion_CuandoSeCreaConValorInvalido()
        {
            var exception = Assert.Throws<ArgumentException>(() => SumaDeDinero.De(-1));
            Assert.Equal(SumaDeDinero.NO_SE_PUEDE_CREAR_UNA_SUMA_DE_DINERO_NEGATIVA, exception.Message);
        }
    }
}