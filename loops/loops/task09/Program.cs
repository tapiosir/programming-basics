using System;

namespace task09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many flips");
            Console.WriteLine();

            string userInput;
            userInput = Console.ReadLine();

            int coinFlips;
            int.TryParse(userInput, out coinFlips);

            Random rnd = new Random();

            int heads = 0;
            int tails = 0;
            int decider = 0;

            for (int i = 0; i < coinFlips; i++)
            {
                decider = rnd.Next(2);
                if (decider == 0)
                {
                    heads++;
                }
                else if (decider == 1)
                {
                    tails++;
                }
            }

            Console.WriteLine("coin has been flipped {0} times \n heads {1} and tails {2} ",coinFlips, heads, tails );
            Console.ReadKey();

        }
    }
}
