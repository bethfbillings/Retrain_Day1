using System;
using System.Collections;

namespace CircularBuffer
{
    public class CircularBuffer
    {

        public bool CreateBuffer(int size)
        {
            if ((size <= 2147483647) && (size > 0)) 
            {
                Console.WriteLine("I work");
            }
            throw new NotImplementedException("Did not Create Object");
        }
        public void AddToBuffer(object addObj) 
        {
            throw new NotImplementedException("Did not Create Object");
        }
        public void PrintOldest() 
        {
            throw new NotImplementedException("Did not Create Object");
        }
        public void PrintBuffer() 
        {
            throw new NotImplementedException("Did not Create Object");
        }
    }
}
