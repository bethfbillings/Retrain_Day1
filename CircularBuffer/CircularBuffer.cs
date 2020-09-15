using System;
using System.Collections;

namespace CircularBuffer
{
    public class CircularBuffer
    {
        public int Newest { get; set; } = 0;
        public object[] Buffer { get; set;}



        public bool CreateBuffer(int size)
        {

            if (size > 0) 
            {
                Buffer = new object[size];
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public void AddToBuffer(object addObj) 
        {
            if (Buffer[Buffer.Length - 1] == null) 
            {
                for (int i = 0; i < Buffer.Length; i++)
                {
                    if (Buffer[i] == null) 
                    {
                        Buffer[i] = addObj;
                        Newest = i;
                        return;
                    }

                }

            }
            if (Newest == Buffer.Length - 1)
            {
                Buffer[0] = addObj;
                Newest = 0;
            }
            else
            {
                Buffer[Newest + 1] = addObj;
                Newest++;
            }
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
