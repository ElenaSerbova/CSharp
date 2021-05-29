using Generics.Accounts;
using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintInfo<int>(123);

            String str = "string";
            PrintInfo(str);

            int a = 10;
            int b = 20;

            Swap(ref a, ref b);

            Console.WriteLine($"a = {a}, b = {b}");


            string str1 = "Cat";
            string str2 = "Dog";

            Swap(ref str1, ref str2);

            Console.WriteLine($"str1: {str1}\nstr2: {str2}");

            ForeginAccount account = new ForeginAccount();
            account.Balance = 27700;

            PrintAccountInfo(account);

            A<int, string> obj;

          
        }

        static void PrintInfo<T>(T obj)
        {           
            Console.WriteLine(obj.GetType().Name);  
        }

        static void Swap(ref object obj1, ref object obj2)
        {
            Object temp = obj1;
            obj1 = obj2;
            obj2 = temp;
        }

        static void Swap<T>(ref T obj1, ref T obj2)
        {
            T temp = obj1;
            obj1 = obj2;
            obj2 = temp;
        }

        static void PrintAccountInfo<T> (T account)  where T: IAccount, new()
        {
            Console.WriteLine(account.GetBalanceInfo());
        }
    }

    class A<T, U> where T : new()
    {
        T field1;
        U field2;

        public void Method (T par) { }
        public T Method2() { return new T(); }
    }

    class B : A<int, int> { }
}
