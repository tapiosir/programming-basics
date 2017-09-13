using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            // prompt user
            Console.Write("enter age");
            Console.WriteLine();

            // Read user input
            string userInput;
            userInput = Console.ReadLine();
            
          
            // Evaluate user input

            int age;
            int.TryParse(userInput, out age);

            



            Console.ReadKey();


            
        }
    }
}
