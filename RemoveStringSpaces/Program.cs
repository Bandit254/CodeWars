using System;

namespace RemoveStringSpaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a function to remove all spaces from a string.\n");
            Console.WriteLine($"Removing the spaces from the string '8 j 8   mBliB8g  imjB8B8  jl  B' results in '{NoSpace("8 j 8   mBliB8g  imjB8B8  jl  B")}'.\n");
            Console.WriteLine($"Removing the spaces from the string '8 8 Bi fk8h B 8 BB8B B B  B888 c hl8 BhB fd' results in '{NoSpace("8 8 Bi fk8h B 8 BB8B B B  B888 c hl8 BhB fd")}'.\n");
            Console.WriteLine($"Removing the spaces from the string '8aaaaa dddd r     ' results in '{NoSpace("8aaaaa dddd r     ")}'.\n");
        }
        public static string NoSpace(string input)
        {
            string result = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]!=' ')
                {
                    result += input[i];
                }
            }
            return result;
        }
    }
}
