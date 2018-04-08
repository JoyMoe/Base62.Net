using System.Linq;
using Xunit;

namespace Base62.Tests
{
    public class BasicTests
    {
        [Fact]
        public void Test1()
        {
            byte[] x = { 128, 128, 128, 128, 128, 128 };
            var s = x.ToBase62();
            var x2 = s.FromBase62();
            Assert.True(x.SequenceEqual(x2));
        }
    }
}
