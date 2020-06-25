using System;

namespace DataReverse
{
    class Program
    {
        /* A stream of data is received and needs to be reversed.
         * Each segment is 8 bits long, meaning the order of these segments needs to be reversed, for example:
         * 11111111  00000000  00001111  10101010
         * (byte1)   (byte2)   (byte3)   (byte4)
         * should become:
         * 10101010  00001111  00000000  11111111
         * (byte4)   (byte3)   (byte2)   (byte1)
         * The total number of bits will always be a multiple of 8.
         * The data is given in an array as such:
         * [1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,0,1,0,1,0,1,0]
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Reverse the bytes in a given array of data.\n");
            int[] data = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 1, 0, 1, 0, 1, 0 };
            foreach (int x in DataReverse(data))
            {
                Console.Write($"{x} ");
            }
        }
        public static int[] DataReverse(int[] data)
        {
            int[] reverseData = new int[data.Length];
            int numBytes = data.Length / 8;
            int L = data.Length;
            for (int k = numBytes; k > 0; k--)
            {
                int byteIndex = 0;
                for (int i = (L-k*8); i < (L-8*(k-1)); i++)
                {
                    reverseData[i] = data[8 * (k - 1) + byteIndex];
                    byteIndex++;
                }
            }
            return reverseData;
        }
    }
}
