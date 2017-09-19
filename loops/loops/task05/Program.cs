using System;

namespace task05
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
            int l = 0;
            int m = 0;

            if (num01 < 0)
            {
                for (int n = -1; n >= num01; n--)
                {
                    if (n % 2 == 0)
                    {
                        l = l + n;
                    }
                    else
                    {
                        m = m + n;
                    }
                }
                Console.WriteLine("even numbers sum {0}", l);
                Console.WriteLine("odd numbers sum {0}", m);
            }

            else
            {
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
            }
            Console.ReadKey();
        }
    }
}
