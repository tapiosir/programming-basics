using System;

namespace task08
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            

            
            int j = 0;

            while (j++ < 5)
            {
                int i = rnd.Next(50);
                Console.WriteLine(i.ToString());
            }



            Console.ReadKey();
            
        }
    }
}
