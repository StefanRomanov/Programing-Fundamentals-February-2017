using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Index_Of_Letters
{
    class IndexOfLetters
    {
        public static void Main()
        {
            var input = File.ReadAllText("input.txt").ToCharArray();

            var result = new List<string>();

            var alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0;  j < alphabet.Length; j++)
                {
                    if (input[i] == alphabet[j])
                    {
                        result.Add($"{input[i]} -> {(int)(alphabet[j] - 'a')}");
                    }
                }
            }

            File.AppendAllLines("output.txt", result);
        }
    }
}
