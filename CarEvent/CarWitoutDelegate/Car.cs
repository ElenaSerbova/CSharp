using System;

namespace CarDelegate
{
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

        public void Accelerate(int dSpeed)
        {
            if (isBroken != true)
            {
                CurrentSpeed += dSpeed;

                if (CurrentSpeed > MaxSpeed)
                {
                    isBroken = true;
                }
            }
        }

    }
}
