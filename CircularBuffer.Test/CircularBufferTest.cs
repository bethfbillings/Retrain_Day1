using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            var result = new CircularBuffer().CreateBuffer(size);

            //act


            //assert
            Assert.True(result);
        }

        [Fact]
        public void AddToBufferTest()
        {
            //arrange
            var buffer = new CircularBuffer();
            var secBuffer = new CircularBuffer().CreateBuffer(6);
            var thirdBuffer = new CircularBuffer().CreateBuffer(6);

            //act
            buffer.AddToBuffer(4);

            //assert
            Assert.NotNull(buffer);
        }
        public void PrintOldestTest()
        {
            //arrange


            //act


            //assert


        }
        public void PrintBufferTest()
        {
            //arrange


            //act


            //assert
        }
    }
}

