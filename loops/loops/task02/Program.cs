using System;

namespace task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a number");
            Console.WriteLine();

            string userInput;
            userInput = Console.ReadLine();

            int num01;
            int.TryParse(userInput, out num01);

            int i = 1;
            int j = 1;

            if (num01 < 1)
            {
                Console.WriteLine("number too small");
            }

            else
            {
                while (i++ < num01)
                {
                    j = j + i;
                }
                Console.WriteLine("{0}", j);
            }
            Console.ReadKey();
        }
    }
}
