using System.Runtime;
using System.Runtime.InteropServices;
using System.Reflection;
using Xunit;

namespace oop
{
    public class SumaDeDineroDebe
    {
        [Fact]
        public void Test1()
        {
            var sut = SumaDeDinero.De(1000);
            Assert.NotNull(sut);
            Assert.Equal(1000, sut.Total);
        }
    }
}