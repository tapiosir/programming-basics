using System;

namespace task10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            double decider = 0;
            for(int i = 1; i < 14; i++)
            {
                decider = rnd.NextDouble();
                if (decider <= 0.4)
                {
                    Console.WriteLine("{0}: 1",i);
                }
                else if (decider <= 0.6)
                {
                    Console.WriteLine("{0}: x",i);
                }
                else
                {
                    Console.WriteLine("{0}: 2",i);
                }

            }
            Console.ReadKey();
        }
    }
}
