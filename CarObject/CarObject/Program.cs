using System;

namespace CarObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Car car = new Car("Ford");
            Car car1 = new Car("Toyota");
            Car car2 = new Car("Aixam");
            Console.WriteLine("{0}\n{1}\n{2}\n",car,car1,car2);

            car.Accelerate();
            car1.Accelerate(34);
            car2.Accelerate(87);

            Console.WriteLine("{0}\n{1}\n{2}\n", car, car1, car2);

            car.Brake();
            car1.Brake();
            car2.Brake();
            Console.WriteLine("{0}\n{1}\n{2}\n", car, car1, car2);
            Console.ReadKey();

        }
    }
}
