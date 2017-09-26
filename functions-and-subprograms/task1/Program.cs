using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintStars();
            Console.ReadKey();
        }
        public static void PrintStars()
        {
            Console.Write("please enter a number: ");

            string userInput;
            userInput = Console.ReadLine();

            int numberOfStars ;
            int.TryParse(userInput, out numberOfStars);

            if (numberOfStars < 0)
            {
                Console.WriteLine("{0} is not a positive number", numberOfStars);
            }
            else
            {
                for (int i = 0; i < numberOfStars; i++)
                {
                    Console.Write("*");
                }
            }
        }

    }
}
