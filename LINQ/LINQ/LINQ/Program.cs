using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            BuildAnonType();
        }

        private static void DeclareImplicitVars()
        {
            // Неявно типизированные локальные переменные.
            var myInt = 0;
            var myBool = true;
            var myString = "Time, marches on...";

            // Вывод имен типов, лежащих в основе этих переменных.
            Console.WriteLine("myInt is а: {0}", myInt.GetType().Name);
            Console.WriteLine("myBool is а: {0}", myBool.GetType().Name);
            Console.WriteLine("myString is а: {0}", myString.GetType().Name);
        }

        private static void InitializationOfObjectsAndCollectionSyntax()
        {
            List<Rectangle> myListOfRects = new List<Rectangle>
            {
                new Rectangle {Location = new Point {X = 1, Y = 2}, Height = 100, Width = 50},
                new Rectangle {Location = new Point {X = 2, Y = 2}, Height = 100, Width = 100},
                new Rectangle {Location = new Point {X = 5, Y = 5}, Height = 90, Width = 75}
            };
               
        }

        private static void LambdaExpressionSyntax()
        {
            // Создать список целых.
            List<int> list = new List<int>() {20, 1, 4, 8, 9, 44};
           
            // Лямбда-выражение C#.
            List<int> evenNumbers = list.FindAll(i => (i % 2) == 0);
            // Вывод на консоль четных чисел.
            Console.WriteLine("Here are your even numbers:");
            foreach (int evenNumber in evenNumbers)
            {
                Console.Write("{0}\t", evenNumber);
            }

            Console.WriteLine();
        }

        private static void UsingExtensionMethod()
        {
            // Поскольку все расширяет System.Object, все классы и структуры
            // могут использовать это расширение.
            int myInt = 12345678;
            myInt.DisplayDefiningAssembly();

            System.Data.DataSet d = new System.Data.DataSet();
            d.DisplayDefiningAssembly();

        }

        private static void BuildAnonType()
        {
            // Построить анонимный тип, используя входные аргументы,
            var car = new { Make = "Saab", Color = "Bright Pink", Speed = 55 };

            // Обратите внимание, что теперь этот тип можно
            // использовать для получения данных свойств!
            Console.WriteLine("You have а {0} {1} going {2} MPH",
                car.Color, car.Make, car.Speed);
            
            // Анонимные типы имеют специальные реализации каждого
            // виртуального метода System.Object. Например:
            Console.WriteLine("ToString() == {0}", car.ToString());

        }
    }

    static class ObjectExtensions
    {
        // Определение расширяющего метода для System.Object.
        public static void DisplayDefiningAssembly(this object obj)
        {
            Console.WriteLine("{0} lives here:\n\t->{1}\n", obj.GetType().Name, Assembly.GetAssembly(obj.GetType()));
        }
    }
  

}
