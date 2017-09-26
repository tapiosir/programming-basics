using System;

namespace task4
{
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            NumberCollector();
            Console.WriteLine();
            Console.ReadKey();
            
        }
        public static void NumberCollector()
        {
            List<int> list = new List<int>(); //https://www.dotnetperls.com/list
            Console.WriteLine("enter 10 numbers");
            for (int j = 1; j <= 11;)
            {
                if (j == 11)
                {
                    j++;
                    foreach (var el in list)
                        Console.Write("{0},",el);
                }
                else
                {
                    Console.Write("{0}: ", j);
                    string userInput;
                    userInput = Console.ReadLine();
                    int i;
                    bool isTrue;
                    isTrue = int.TryParse(userInput, out i);

                    if (isTrue == true)
                    {
                        if (i < 0)
                        {
                            Console.WriteLine("number {0} is negative, please enter positive number", i);
                        }
                        else
                        {
                            j++;
                            list.Add(i);
                                          
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
}
