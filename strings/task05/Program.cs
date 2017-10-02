using System;

namespace task05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input text please.");
            string userInput;
            userInput = Console.ReadLine();

            string[] array = { "a", "e", "i", "o", "u", "y" };
            int vowel = 0;

            foreach (var c in array)
            {
                if (userInput.Contains(c))
                {
                    vowel++;
                }
            }
            Console.WriteLine("word '{0}' contains {1} vowels",userInput,vowel);
            Console.ReadKey();

        }
    }
}
