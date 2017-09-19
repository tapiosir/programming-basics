using System;

namespace task06
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            double j = 1;

            do
            {
                j = Math.Sqrt(i);
                Console.WriteLine("{0}\t {1}", i, j);

            }
            while (i++ < 10);
            
                
            
            Console.ReadKey();
        }
    }
}
