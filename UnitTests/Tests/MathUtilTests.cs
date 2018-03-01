using System;
using UnitTests.Utils;
using Xunit;

namespace UnitTests.Tests
{
    public class MathUtilTests
    {
        [Fact]
        public void Test_Sum()
        {
            Assert.Equal(2, MathUtil.Sum(1, 1));
            Assert.Equal(3, MathUtil.Sum(1, 2));
            Assert.Equal(2, MathUtil.Sum(3, -1));
        }

        [Fact]
        public void Test_Fibbonacci()
        {
            Assert.Equal(0, MathUtil.Fibbonacci(0));
            Assert.Equal(1, MathUtil.Fibbonacci(1));
            Assert.Equal(1, MathUtil.Fibbonacci(2));
            Assert.Equal(2, MathUtil.Fibbonacci(3));
            Assert.Equal(3, MathUtil.Fibbonacci(4));
            Assert.Equal(5, MathUtil.Fibbonacci(5));
            Assert.Equal(8, MathUtil.Fibbonacci(6));
            Assert.Equal(55, MathUtil.Fibbonacci(10));
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(1, 2)]
        [InlineData(2, 3)]
        [InlineData(3, 4)]
        [InlineData(5, 5)]
        [InlineData(8, 6)]
        [InlineData(55, 10)]
        public void Test_Fibbonacci_WithTheory(int result, int index)
        {
            Assert.Equal(result, MathUtil.Fibbonacci(index));
        }

        [Fact]
        public void Test_Fibbonacci_ThrowsArgumentExceptionIfNegativeValue()
        {
            Assert.Throws<ArgumentException>(() => MathUtil.Fibbonacci(-1));
        }
    }
}
