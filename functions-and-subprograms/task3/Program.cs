using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            NumChecker();
            Console.ReadKey();
        }
        public static void  NumChecker()
        {
            for (int j = 0; j < 1;)
            {
                Console.WriteLine("please enter a number between 1 and 10");
                string userInput;
                userInput = Console.ReadLine();
                int i;
                bool isTrue;
                isTrue = int.TryParse(userInput, out i);
                if (isTrue == true)
                {
                    if (i < 1)
                    {
                        Console.WriteLine("number is too small");
                    }
                    else if (i > 10)
                    {
                        Console.WriteLine("number is too large"); 
                    }
                    else if (i == i)
                    {
                        Console.WriteLine("number you entered is: {0}", i);
                        j++;
                    }
                }
                else
                {
                    Console.WriteLine("invalid charater");
                }
            }
        }     
    }
}
