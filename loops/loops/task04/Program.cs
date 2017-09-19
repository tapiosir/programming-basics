using System;

namespace task04
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
            int k = -1;
            int l = -1;

            if (num01 < 1)
            {
                while (l-- > num01)
                {
                    k = k + l;
                }
                Console.WriteLine("{0}", k);
                
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
