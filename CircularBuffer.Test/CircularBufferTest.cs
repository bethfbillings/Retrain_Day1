using System;
using Xunit;

namespace CircularBuffer.Test
{
    public class CircularBufferTest
    {
        [Theory]
        [InlineData(null)]
        [InlineData(-6)]
        [InlineData(2147483648)]
        [InlineData(3)]
        public void CreateCircularBufferIsTrue(int size)
        {
            //arrange
            var result = new CircularBuffer().SizeBuffer(size);

            //act


            //assert
            Assert.True(result);
        }
    }
}
