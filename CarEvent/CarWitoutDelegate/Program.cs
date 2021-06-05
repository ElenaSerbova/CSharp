using System;

namespace CarDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Mechanic chip = new Mechanic("Chip");
            Mechanic dale = new Mechanic("Dale");

            Car car = new Car();

            while (true)
            {
                car.Accelerate(20);
                Console.WriteLine($"Current speed: {car.CurrentSpeed}");

                if (car.IsBroken)
                {
                    chip.CarBrokenHandler("car is broken");
                    dale.CarBrokenHandler("car is broken");

                    break;
                }
            }
        }
    }
}
