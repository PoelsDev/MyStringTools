using System;
using Xunit;
using MyStringTools;

namespace MyStringToolsTests
{
    public class StringToolsTests
    {
        [Fact]
        public void CountDigitsShouldCountDigitsInAString()
        {
            Assert.Equal(10, StringTools.CountDigits("1234567890"));
            Assert.Equal(10, StringTools.CountDigits(" 1234567890 "));
            Assert.Equal(10, StringTools.CountDigits("abc12def345ghi67jklm890nop"));
            Assert.Equal(3, StringTools.CountDigits("aaa555"));
        }

        [Fact]
        public void GetAsciiCodesShouldReturnAsciiCodesAsByteArray()
        {
            byte[] cs;

            cs = StringTools.GetAsciiCodes("aAbBcC");

            Assert.Equal(97, cs[0]);
            Assert.Equal(65, cs[1]);
            Assert.Equal(98, cs[2]);
            Assert.Equal(66, cs[3]);
            Assert.Equal(99, cs[4]);
            Assert.Equal(67, cs[5]);

            cs = StringTools.GetAsciiCodes("A1 B2 C3");

            Assert.Equal(65, cs[0]);
            Assert.Equal(49, cs[1]);
            Assert.Equal(32, cs[2]);
            Assert.Equal(66, cs[3]);
            Assert.Equal(50, cs[4]);
            Assert.Equal(32, cs[5]);
            Assert.Equal(67, cs[6]);
            Assert.Equal(51, cs[7]);
        }

        [Fact]
        public void GetHexadecimalAsciiStringShouldReturnStringWithHexadecimalAsciiCodes()
        {
            Assert.Equal("61 41 62 42 63 43", StringTools.GetHexadecimalAsciiString("aAbBcC"));
            Assert.Equal("4A 31 20 4B 32 20 4C 33", StringTools.GetHexadecimalAsciiString("J1 K2 L3"));
        }
    }
}
