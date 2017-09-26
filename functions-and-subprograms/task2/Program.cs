using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please enter a number: ");

            string userInput1, userInput2;
            userInput1 = Console.ReadLine();
            userInput2 = Console.ReadLine();

            int num01, num02;
            int.TryParse(userInput1, out num01);
            int.TryParse(userInput2, out num02);

            Minimi(num01, num02);
            Console.ReadKey();
        }
        public static void  Minimi(int num01, int num02)
        {
                if (num01 < num02)
                {
                    Console.WriteLine("number {0} is smaller", num01);
                }
                else if (num01 > num02)
                {
                    Console.WriteLine("number {0} is smaller", num02);
                }
                else
                {
                    Console.WriteLine("numbers are equal");
                }
        }
           

    }
}
