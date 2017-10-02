using System;

namespace task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("give me text");
            string userInput;
            userInput = Console.ReadLine();

            int count = 0;
            foreach (char l in userInput)
            {
                if (l == 'l') count++;
                else if (l == 'L') count++;
            }

            Console.WriteLine(count);
            Console.ReadKey();

        }
    }
}
