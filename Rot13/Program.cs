using System;

namespace Rot13
{
    class Program
    {
        /* ROT13 is a simple letter substitution cipher that replaces a letter with the letter 13 letters after it in the alphabet. 
         * ROT13 is an example of the Caesar cipher.
         * Create a function that takes a string and returns the string ciphered with Rot13. 
         * If there are numbers or special characters included in the string, they should be returned as they are. 
         * Only letters from the Latin/English alphabet should be shifted, like in the original Rot13 "implementation".
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Create a function that encrypts a string using the ROT13 cypher.\n");
            Console.WriteLine($"The ROT13 cypher of 'test' is: {Rot13("test")}\n");
            Console.WriteLine($"The ROT13 cypher of 'Test' is: {Rot13("Test")}\n");
            Console.WriteLine($"The ROT13 cypher of 'Te5$st' is: {Rot13("Te5$st")}\n");
        }
        public static string Rot13(string message)
        {
            string messageCypher = "";
            for (int i = 0; i < message.Length; i++)
            {
                if ((message[i]<'A' || message[i]>'Z') && (message[i]<'a' || message[i]>'z'))
                {
                    messageCypher += message[i];
                }
                else
                {
                    if (message[i]>='A' && message[i]<='Z')
                    {
                        char shiftedChar = (char)(message[i] + 13);
                        if (shiftedChar>'Z')
                        {
                            int leftover = Math.Abs(shiftedChar - 'Z');
                            shiftedChar = (char)('A' - 1 + leftover);
                        }
                        messageCypher += shiftedChar;
                    }
                    if (message[i] >= 'a' && message[i] <= 'z')
                    {
                        char shiftedChar = (char)(message[i] + 13);
                        if (shiftedChar > 'z')
                        {
                            int leftover = Math.Abs(shiftedChar - 'z');
                            shiftedChar = (char)('a' - 1 + leftover);
                        }
                        messageCypher += shiftedChar;
                    }
                }
            }
            return messageCypher;
        }
    }
}
