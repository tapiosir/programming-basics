using System;

namespace loops
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

            int j = 1;

            if (num01 < 0)
            {
                Console.WriteLine("invalid");
            }

            else
            {
                for (int i = 1; i <= num01; i++)
                {
                    j = j * i;
                }

                Console.WriteLine("{0}", j);
            }  
            

            Console.ReadKey();
        }
    }
}
