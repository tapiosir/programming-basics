using System;
using System.Collections.Generic;
using System.Text;

namespace CarObject
{
    class Car
    {
        public string Brand;
        public double Speed;

        public Car(string brand)
        {
            Brand = brand;
            Speed = 0;
        }
        public void Accelerate()
        {
            Speed = Speed + 12;
        }
        public void Accelerate(double value)
        {
            Speed = Speed + value;
        }
        public void Brake()
        {
            Speed = Speed * 0.9;
        }

        public override string ToString()
        {
            return $"brand: {Brand}, Speed: {Speed}";
        }


    }
}
