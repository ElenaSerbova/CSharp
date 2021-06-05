using System;

namespace CarDelegate
{
    class Mechanic
    {
        public string Name { get; set; }
        public Mechanic(string name)
        {
            Name = name;
        }

        public void CarBrokenHandler(string message)
        {
            Console.WriteLine("{0} спешит на помощь", Name);
        }
    }
}
