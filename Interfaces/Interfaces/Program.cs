using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{




    class Program
    {
        static void Main(string[] args)
        {
            //TestCharacter();
            TestConflict();
        }

        static void TestConflict()
        {
            MyClass2 obj = new MyClass2();

            Interface1 int1 = obj;
            int1.Foo();

            Interface2 int2 = obj;
            int2.Foo();
        }

        static void TestCharacter()
        {
            int key;

            Console.WriteLine("1. Sonic");
            Console.WriteLine("2. Foxy");
            key = int.Parse(Console.ReadLine());

            ICharacter character = null;

            if (key == 1)
            {
                character = new Sonic();
            }
            else
            {
                character = new Foxy();
            }

            Play(character);
        }
        static void Play(ICharacter character)
        {
            int key;

            do
            {
                key = int.Parse(Console.ReadLine());

                switch (key)
                {
                    case 1:
                        character.Run();
                        break;

                    case 2:
                        character.Jump();
                        break;

                    case 3:
                        character.Super();
                        break;
                }
            } while (key != 0);

        }
    }
}
