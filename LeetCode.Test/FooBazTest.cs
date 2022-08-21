using System;
using Xunit;

namespace LeetCode.Test
{
    public class FooBazTest
    {
        [Fact]
        public void ShouldReturFoo()
        {
            var fooBaz = new FooBaz();
            var res = fooBaz.GetFooBaz("foo");

            Assert.Equal(1, res);
        }
    }
}
