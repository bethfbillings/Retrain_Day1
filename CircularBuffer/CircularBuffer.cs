using System;

namespace CircularBuffer
{
    public class CircularBuffer
    {
        public bool SizeBuffer(int size)
        {
            if ((size <= 2147483647) && (size > 0)) 
            {
                Console.WriteLine("I work");
            }
            throw new NotImplementedException("Did not Create Object");
        }

    }
}
