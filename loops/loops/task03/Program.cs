using System;

namespace task03
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

            int j = 0;
            int k = 0;

            for (int i = 1; i <= num01; i++)
            {
                if (i % 2 == 0)
                {
                    j = j + i;
                }
               
                else 
                {
                    k = k + i;
                }

                
            }
            Console.WriteLine("even numbers sum {0}", j);
            Console.WriteLine("odd numbers sum {0}", k);
            Console.ReadKey();
        }
    }
}
