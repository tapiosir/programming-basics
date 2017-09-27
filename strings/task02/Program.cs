using System;

namespace task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("give me text");
            string userInput;
            userInput = Console.ReadLine();

            userInput = userInput.Replace("e", "@");
            Console.WriteLine("{0}", userInput);
            Console.ReadKey();
        }
    }
}
