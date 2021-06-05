using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    
   
    delegate int PerformCalculation(int a, int b);   

   
    class Program
    {        
        static void Main(string[] args)
        {
            //PerformCalculationTest();
            PredicateTest();
        }

        static void PerformCalculationTest()
        {
            PerformCalculation calc = new PerformCalculation(Sum);
            CalculationView(calc);

            CalculationView(new PerformCalculation(Sub));

            CalculationView(Mult); //new PerformCalculation(Mult)
        }

        static void PredicateTest()
        {
            //delegates with array
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int evenElement = Array.Find(arr, IsEven);
            Console.WriteLine($"First even element: {evenElement}");

            int[] evenElements = Array.FindAll(arr, IsEven);

            Console.Write("All even elements: ");
            foreach (var item in evenElements)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
        }

    
        static void CalculationView(PerformCalculation calculation)
        {
            try
            {
                Console.WriteLine("Enter first number: ");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter second number: ");
                int b = int.Parse(Console.ReadLine());

                int res = calculation(a, b); //calculation.Invoke(a, b)

                Console.WriteLine($"Result: {res}");
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int Sub(int a, int b)
        {
            return a - b;
        }

        static int Mult(int a, int b)
        {
            return a * b;
        }

        static bool IsEven(int num)
        {
            return num % 2 == 0;
        }
    }
}
