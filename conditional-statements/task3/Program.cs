using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            // prompt user
            Console.Write("please enter a number");
            Console.WriteLine();
            // Read user input
            string userInput;
            userInput = Console.ReadLine();

            // Evaluate user input

            int evaluatedNumber;
            int.TryParse(userInput, out evaluatedNumber);

            if (evaluatedNumber > 0)
            {

                if (evaluatedNumber % 2 == 0)
                {
                    Console.WriteLine("number {0} is positive and even", evaluatedNumber);
                }
                else
                    Console.WriteLine("number {0} is positive and odd", evaluatedNumber);
            }
            if (evaluatedNumber < 0)
            {
                if (evaluatedNumber % 2 == 0)
                {
                    Console.WriteLine("number {0} is negative and even", evaluatedNumber);
                }
                else
                    Console.WriteLine("number {0} is negative and odd", evaluatedNumber);
            }
            
            Console.ReadKey();
        }
    }
}
