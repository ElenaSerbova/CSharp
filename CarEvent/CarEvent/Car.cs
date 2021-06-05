using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarEvent
{
    delegate void CarBrokenHandler(string message);
    class Car
    {
        public event CarBrokenHandler Broken; //приватный объект делегата и два метода подписки и отписки

        public int MaxSpeed { get; set; }
        public int CurrentSpeed { get; set; }

        public Car()
        {
            MaxSpeed = 150;
            CurrentSpeed = 0;
        }

        public Car(int maxSpeed)
        {
            MaxSpeed = maxSpeed;
            CurrentSpeed = 0;
        }

        public void Accelerate(int dSpeed)
        {
            CurrentSpeed += dSpeed;

            if (CurrentSpeed > MaxSpeed)
            {                
                Broken?.Invoke("Car is broken");
            }
        }

    }
}
