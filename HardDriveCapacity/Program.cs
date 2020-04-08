using System;

namespace HardDriveCapacity
{
    class Program
    {
        /*
         * Your task is to determine how many files of the copy queue you will be able to save into your Hard Disk Drive.
           Input:
           Array of file sizes (0 <= s <= 100)
           Capacity of the HD (0 <= c <= 500)
           Output:
           Number of files that can be fully saved in the HD
           Examples:
           save([4,4,4,3,3], 12) -> 3
           # 4+4+4 <= 12, but 4+4+4+3 > 12
           save([4,4,4,3,3], 11) -> 2
           # 4+4 <= 11, but 4+4+4 > 11
           Do not expect any negative or invalid inputs.
         * 
         */

        static void Main(string[] args)
        {
            Console.WriteLine("Given an array of the sizes of files to be saved to the hard drive, and given the capacity of the hard drive, " +
                "return the number of files that can be saved to the hard drive. " +
                "Note: The files are saved sequentially, so a large file at the beginning of the array may prevent multiple smaller files at the end from being saved.\n");

            Console.WriteLine($"{HardDriveCapacity(new int[] { 4, 4, 4, 3, 3 }, 12)}");
            Console.WriteLine($"{HardDriveCapacity(new int[] { 4, 4, 4, 3, 3 }, 11)}");
            Console.WriteLine($"{HardDriveCapacity(new int[] { 4, 8, 15, 16, 23, 42 }, 108)}");
            Console.WriteLine($"{HardDriveCapacity(new int[] { 13 }, 13)}");
            Console.WriteLine($"{HardDriveCapacity(new int[] { 1, 2, 3, 4 }, 250)}");
            Console.WriteLine($"{HardDriveCapacity(new int[] { 100 }, 500)}");
            Console.WriteLine($"{HardDriveCapacity(new int[] { 11, 13, 15, 17, 19 }, 8)}");
            Console.WriteLine($"{HardDriveCapacity(new int[] { 45 }, 12)}");
        }

        public static int HardDriveCapacity(int[] sizes, int hd)
        {
            int count = 0;
            int cumulativeSize=0;
            if (sizes[0]>hd)
            {
                return 0;
            }
            else if (sizes[0]==hd)
            {
                return 1;
            }
            else
            {
                for (int i = 0; i < sizes.Length; i++)
                {
                    cumulativeSize += sizes[i];
                    if (cumulativeSize <= hd)
                    {
                        count++;
                    }
                    else if (cumulativeSize > hd)
                    {
                        break;
                    }
                }
                return count;
            }
        }

    }
}
