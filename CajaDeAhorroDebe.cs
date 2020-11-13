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
            Assert.Equal(0, sut.Saldo);
        }

        private static CajaDeAhorro GetSubjectUnderTest() => new CajaDeAhorro();
   }
}
