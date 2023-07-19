using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator1
{
    class BitReader
    {
        private byte bufferReader; // The type can be a byte or an array of items(each element in the array will represent a BIT)
        private int numberOfReadBits;
        private FileStream input;
        
        public long GetInputSize()
        {
            return input.Length;
        }
        public BitReader(string filePath) // filePath = the file path to the input file
        {
            input = new FileStream(filePath,FileMode.Open);
            numberOfReadBits = 0;// initialize to 0 or 1 or 7 or 8;
        }

        private bool IsBufferEmpty()
        {
            return (numberOfReadBits == 0);
        }

        private byte ReadBit()
        {
            if (IsBufferEmpty())
            {
                //Reset NumberOfReadBits
                numberOfReadBits = 8;
                //Read 1 byte (8bits) from input file and put in inside BufferReader
                bufferReader = (byte) input.ReadByte();
            }

            //Probably decrease number of available bits
            numberOfReadBits--;
            //take 1 bit from the buffer and put in into result
            return (byte) ((bufferReader >> numberOfReadBits) & 1);
        }

        public int ReadNBits(int nr) //nr will be a value [1..32]
        {
            int result = 0;
            for (int i=0; i<nr; i++)
            {
                byte bit = ReadBit();
                // add bit to result
                result = (result << 1) | bit;
            }
            return result;
        }
    }
}
