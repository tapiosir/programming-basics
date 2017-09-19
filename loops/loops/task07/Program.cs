using System;

namespace task07
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int j = 1;
            int k;
            do
            {
                k = i * j;
                Console.WriteLine("{0}x{1}={2}", i, j, k);
            }
            while (j++ < 9);
            
            
            Console.ReadKey();
        }
    }
}
