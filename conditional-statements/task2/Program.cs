using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {

            // prompt user
            Console.Write("please enter a number: ");

            // Read user input
            string userInput;
            userInput = Console.ReadLine();

            // Evaluate user input

            int evaluatedNumber;
            bool isTrue;
            isTrue = int.TryParse(userInput, out evaluatedNumber);

            if (isTrue == true)
            {


                if (evaluatedNumber % 2 == 0)
                {
                    // number 0 is considered to be even
                    Console.WriteLine("number {0} is even", evaluatedNumber);
                }

                else
                {
                    Console.WriteLine("number {0} is odd", evaluatedNumber);
                }
            }
            else
            {
                Console.WriteLine("Invalid char");
            }
                

            // wait for user input
            Console.ReadKey();

        }
    }
}
