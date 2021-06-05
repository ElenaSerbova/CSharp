using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CarEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CancelKeyPress += Console_CancelKeyPress;

            Mechanic chip = new Mechanic("Chip");
            Mechanic dale = new Mechanic("Dale");

            Car car = new Car();
            car.Broken += chip.CarBrokenHandler;
            car.Broken += dale.CarBrokenHandler;

            //car.Broken("haha");
          
            for (int i = 0; i < 10; i++)
            {
                car.Accelerate(20);
                Console.WriteLine("CurrentSpeed: {0}", car.CurrentSpeed);
                Thread.Sleep(300);
            }
        }

        private static void Console_CancelKeyPress(object sender, ConsoleCancelEventArgs e)
        {
            Console.WriteLine("Chip и Dale уходят");
        }
    }
}
