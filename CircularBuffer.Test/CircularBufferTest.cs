
using System;
using Xunit;

namespace CircularBuffer.Test
{
    public class CircularBufferTest
    {
        [Theory]
        [InlineData(3)]
        public void CreateCircularBufferIsTrue(int size)
        {
            //arrange
            var result = new CircularBuffer().CreateBuffer(size);

            //act


            //assert
            Assert.True(result);
        }

        [Theory]
        [InlineData(-6)]
        [InlineData(null)]
        public void CreateCircularBufferIsFalse(int size)
        {
            //arrange
            var result = new CircularBuffer().CreateBuffer(size);

            //act


            //assert
            Assert.False(result);
        }

        [Fact]
        public void AddToBufferTestEmpty()
        {
            //arrange
            var buffer = new CircularBuffer();
            buffer.CreateBuffer(3);

            //act
            buffer.AddToBuffer(4);

            //assert
            Assert.NotNull(buffer.Buffer[0]);
        }

        [Fact]
        public void AddToBufferTestFull()
        {
            //arrange
            var buffer = new CircularBuffer();
           buffer.CreateBuffer(3);
          
            //for (int i = 0; i < buffer.Buffer.Length; i++)
            //{
            //    buffer.Buffer[i] = 0;
            //}


            //act
            buffer.AddToBuffer(4);
            buffer.AddToBuffer(4);
            buffer.AddToBuffer(4);
            buffer.AddToBuffer(0);

            //assert
            Assert.Equal(0,buffer.Buffer[0]);
        }
        [Fact]
        public void AddToBufferTestFull2()
        {
            //arrange
            var buffer = new CircularBuffer();
            buffer.CreateBuffer(3);

            //for (int i = 0; i < buffer.Buffer.Length; i++)
            //{
            //    buffer.Buffer[i] = 0;
            //}


            //act
            buffer.AddToBuffer(4);
            buffer.AddToBuffer(4);
            buffer.AddToBuffer(4);
            buffer.AddToBuffer(0);
            buffer.AddToBuffer(0);

            //assert
            Assert.Equal(0, buffer.Buffer[1]);
        }

        [Fact]
        public void PrintOldestTest()
        {
            //arrange


            //act


            //assert


        }

        [Fact]
        public void PrintBufferTest()
        {
            //arrange


            //act


            //assert
        }
    }
}

