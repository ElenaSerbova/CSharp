using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface Interface1
    {
        void Foo();
    }

    interface Interface2
    {
        void Foo();
    }

    class MyClass : Interface1, Interface2
    {
        //неявная реализация
        public void Foo()
        {
            Console.WriteLine("MyClass.Foo");
        }
    }

    class MyClass2 : Interface1, Interface2
    {
        //явная реализация
        void Interface1.Foo()
        {
            Console.WriteLine("Interface1.Foo");
        }

        void Interface2.Foo()
        {
            Console.WriteLine("Interface2.Foo");
        }
    }
}
