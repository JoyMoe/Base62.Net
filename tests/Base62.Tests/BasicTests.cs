using System.Linq;
using Xunit;

namespace Base62.Tests
{
    public class BasicTests
    {
        [Fact]
        public void TestByteArrayToBase62()
        {
            var s = new byte[] {128, 128, 128, 128, 128, 128}.ToBase62();
            Assert.Equal("e7Thjuc4", s);
        }

        [Fact]
        public void TestStringToBase62()
        {
            var s = "Hello world!".ToBase62();
            Assert.Equal("T8dgcjRGuYUueWht", s);
        }

        [Fact]
        public void TestIntToBase62()
        {
            var s = 987654321.ToBase62();
            Assert.Equal("14q60P", s);
        }

        [Fact]
        public void TestByteArrayFromBase62()
        {
            var x = "e7Thjuc4".FromBase62();
            Assert.True(x.SequenceEqual(new byte[] {128, 128, 128, 128, 128, 128}));
        }

        [Fact]
        public void TestStringFromBase62()
        {
            var s = "T8dgcjRGuYUueWht".FromBase62<string>();
            Assert.Equal("Hello world!", s);
        }

        [Fact]
        public void TestIntFromBase62()
        {
            var i = "14q60P".FromBase62<int>();
            Assert.Equal(987654321, i);
        }
    }
}
