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

            car.AddCarBrokenHandler(chip.CarBrokenHandler);
            car.AddCarBrokenHandler(dale.CarBrokenHandler);           

            for (int i = 0; i < 10; i++)            
            {
                car.Accelerate(20);
                Console.WriteLine($"Current speed: {car.CurrentSpeed}");                
            }
        }
    }
}
