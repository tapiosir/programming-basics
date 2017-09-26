using System;

namespace task4
{
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            NumberCollector();
            Console.ReadKey();
            
        }
        public static void NumberCollector()
        {
            Console.WriteLine("enter 10");
            string userInput;
            userInput = Console.ReadLine();
            int i;
            int.TryParse(userInput, out i);
            
          
            
            List<int> list = new List<int>(); //https://www.dotnetperls.com/list

            list.Add(i);
            list.Add(i);

            foreach (int prime in list)
            {
                Console.WriteLine(prime);
            }




        }
    }
}
