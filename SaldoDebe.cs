using Xunit;

namespace oop
{
    public class SaldoDebe
    {
        [Fact]
        public void Test1()
        {
            var sut = Saldo.DeMasDe(0);
            Assert.Equal(0, sut.Total);
        }

        [Fact]
        public void Test2()
        {
            var sut = Saldo.DeMasDe(0, 10);
            Assert.Equal(10, sut.Total);
        }
    }

    public class Saldo
    {
        public decimal Total { get; }
        private decimal Minimo { get; }

        private Saldo(decimal minimo, decimal valorInicial)
        {
            Minimo = minimo;
            Total = valorInicial;
        }

        public static Saldo DeMasDe(decimal minimo)
        {
            return new Saldo(minimo, 0);
        }

        public static Saldo DeMasDe(decimal minimo, decimal valorInicial)
        {
            return new Saldo(minimo, valorInicial);
        }
    }
}