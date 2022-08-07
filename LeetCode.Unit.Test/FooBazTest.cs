using System;
using Xunit;

namespace LeetCode.Unit.Test
{
    public class FooBazTest
    {
        [Fact]
        public void ShouldreturnEmptyString()
        {
            var fooBaz = new FooBaz();

            var res = fooBaz.GetFooBaz(0);

            Assert.Equal(string.Empty, res + "ok");
        }
    }
}
