using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegates
{
    static class CalculationHelper
    {
        public static void Sum(int a, int b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }

        public static void Sub(int a, int b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
        }

        public static void Mult(int a, int b)
        {
            Console.WriteLine($"{a} * {b} = {a * b}");
        }

        public static void Div(int a, int b)
        {
            try
            {
                Console.WriteLine($"{a} / {b} = {a / b}");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
