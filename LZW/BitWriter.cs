using System.IO;

namespace Laborator1
{
    class BitWriter
    {
        private byte bufferWriter; // It can be a byte or an array of items (each element in the array will represent a BIT)
        private int numberOfBitsWritten;
        private FileStream output;

        public BitWriter(string filePath) // file path of the output file
        {
            output = new FileStream(filePath, FileMode.Create);
            numberOfBitsWritten = 0; // initialize to 0 or 1 or 7 or 8;
        }

        private bool IsBufferFull()
        {
            return numberOfBitsWritten == 8;
        }

        //The value type can be byte or int or even a boolean. But always it will take only the last bit of the value
        //???????????? debuggggg
        private void WriteBit(uint value)
        {
            //write last bit from value into BufferWrite and 
            bufferWriter = (byte)(bufferWriter << 1 | value);
            //increase / decrease the counter of NumberOfBitsWrites
            numberOfBitsWritten++;
            if (IsBufferFull())
            {
                //Write BufferWrite into the output file
                output.WriteByte(bufferWriter);
                numberOfBitsWritten = 0; // initialize to 0 or 1 or 7 or 8;
                bufferWriter = 0;
            }
        }

        public void WriteNBits(int nr, uint value) //nr will be a value [1..32].
        //Value must be an unsigned number which can be store at least on 32 bits.E.g. in C# UINT32
        {
            for (int i = nr-1; i >= 0 ; i--)
            {
                // WriteBit(...)
                WriteBit((value >> i) & 1);
            }
        }
    }
}

/*
    writeNBits(bits:4, value:3)
    0111

    writeBit(0111>>3&1) = 0000&1=0
    writeBit(0111>>2&1) = 0001&1=1
    writeBit(0111>>1&1) = 0011&1=1
    writeBit(0111>>0&1) = 0111&1=1
*/
