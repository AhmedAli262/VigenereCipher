using System;
using System.Collections.Generic;

namespace Vigenere_cipher
{
    static class KeyGenerator
    {
        public static string[] GenerateKeysBelow(string characters, int maxLength)
        {
            List<string> keys = new List<string>();

            for (int i = 1; i <= maxLength; i++)
            {
                keys.AddRange(InternalGenerateKeys(characters, string.Empty, i));
            }

            return keys.ToArray();
        }

        public static string[] GenerateKeys(string characters, int length)
        {
            return InternalGenerateKeys(characters, string.Empty, length);
        }


        private static string[] InternalGenerateKeys(string characters, string precedingText, int length)
        {
            List<string> keys = new List<string>();

            foreach (char character in characters)
            {
                if (length > 1)
                {
                    keys.AddRange(InternalGenerateKeys(characters, precedingText + character, length - 1));
                }
                else
                {
                    keys.Add(precedingText + character);
                }
            }

            return keys.ToArray();
        }
    }
}
