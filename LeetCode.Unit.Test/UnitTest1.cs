using Xunit;

namespace LeetCode.Unit.Test
{
    public class UnitTest1
    {
        [Fact]
        public void FooBazTest()
        {
            FooBaz fooBaz = new FooBaz();
            var res = fooBaz.GetFooBaz(5);

            Assert.Equal(string.Empty, res);
        }
    }
}
