using System;

namespace task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" please give me a text");
            string userInput;
            userInput = Console.ReadLine();

            Console.WriteLine("text '{0}' is {1} charaters long", userInput, userInput.Length);
            Console.ReadKey();
        }
    }
}
