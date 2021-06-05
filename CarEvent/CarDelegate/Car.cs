using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDelegate
{
    delegate void CarBrokenHandler(string message);
    class Car
    {        
        private bool isBroken = false;
        public bool IsBroken => isBroken; //get

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

        private CarBrokenHandler carBroken;   

        public void AddCarBrokenHandler(CarBrokenHandler handler)
        {
            carBroken += handler;
        }

        public void RemoveCarBrokenHadler(CarBrokenHandler handler)
        {
            carBroken -= handler;
        }
        public void Accelerate(int dSpeed)
        {
            if (isBroken != true)
            {
                CurrentSpeed += dSpeed;

                if (CurrentSpeed > MaxSpeed)
                {
                    isBroken = true;

                    carBroken?.Invoke("car is broken");
                }
            }
        }

    }
}
