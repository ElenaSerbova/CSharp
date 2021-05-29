using System;

namespace InterfaceCSharp8
{
    interface MyInterface
    {
        void Foo()
        {
            Console.WriteLine("Default foo");
        }
    }

    class MyClass1 : MyInterface
    {

    }

    class MyClass2 : MyInterface
    {
        public void Foo()
        {
            Console.WriteLine("MyClass2.Foo");
        } 
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyInterface myInterface = new MyClass1();
            myInterface.Foo();

            myInterface = new MyClass2();
            myInterface.Foo();

            MyClass1 obj = new MyClass1();
            //obj.Foo();
        }
    }
}
