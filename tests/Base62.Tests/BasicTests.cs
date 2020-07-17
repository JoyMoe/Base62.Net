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

        [Fact]
        public void ByteArrayConversionIdentityTest()
        {
            var bytes = new byte[] { 0, 0, 0, 128, 128, 0, 0, 1, 2, 3, 0, 0, 0 };
            string s = bytes.ToBase62();
            byte[] back = s.FromBase62();
            Assert.Equal(bytes, back);
        }

        [Fact]
        public void ByteArrayConversionZeroArray()
        {
            var bytes = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            string s = bytes.ToBase62();
            byte[] back = s.FromBase62();
            Assert.Equal(bytes.Length, back.Length);
            Assert.Equal(bytes, back);
        }

        [Fact]
        public void ByteArrayConversionAlmostZeroArray()
        {
            var bytes = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 };
            string s = bytes.ToBase62();
            byte[] back = s.FromBase62();
            Assert.Equal(bytes.Length, back.Length);
            Assert.Equal(bytes, back);
        }
    }
}
