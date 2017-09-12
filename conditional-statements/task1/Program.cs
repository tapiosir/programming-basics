using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            // prompt user
            Console.Write("please enter a number");

            // Read user input
            string userInput;
            userInput = Console.ReadLine();

            // Evaluate user input

            int evaluatedNumber;
            int.TryParse(userInput, out evaluatedNumber);

                                   
            if (evaluatedNumber > 0)
            {
                Console.WriteLine("number {0} is positive", evaluatedNumber);
            }
                      
            else if (evaluatedNumber < 0)
            {
                Console.WriteLine("number {0} is negative", evaluatedNumber);
            }
                        
            else
            {
                Console.WriteLine("number {0} is 0", evaluatedNumber);
            } 

            //wait for user input
            Console.ReadKey();

        }
    }
}
