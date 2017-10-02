using System;

namespace task04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("give me text");
            string userInput;
            userInput = Console.ReadLine();

            string spaceLessInput;
            spaceLessInput = userInput.Replace(" ", "");

            char[] inputarray = spaceLessInput.ToCharArray();
            Array.Reverse(inputarray);
            string reverseInput = new string(inputarray);

            if (string.Equals(spaceLessInput, reverseInput) == true)
            {
                Console.WriteLine("'{0}' is palindrome",userInput);
            }
            else
            {
                Console.WriteLine("'{0}' is not palindrome",userInput);
            }
            
            Console.ReadKey();
        }
    }
}
