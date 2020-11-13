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
    }
}