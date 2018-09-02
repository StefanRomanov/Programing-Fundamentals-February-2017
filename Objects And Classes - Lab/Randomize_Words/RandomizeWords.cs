using System;

namespace Randomize_Words
{
    class RandomizeWords
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split();

            var random = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                var randomNumber = words[random.Next(0, words.Length)];
                var currentWord = words[i];

                var temp = currentWord;
                currentWord = randomNumber;
                randomNumber = temp;
            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
