using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface IArtefact
    {
        string Name { get; }
    }

    interface ICharacter
    {
        void Run();
        void Jump();
        void Super();

        string Name { get; }
    }

    interface ICharacterExtended : ICharacter
    {
        void Add(IArtefact artefact);
        void Remove(IArtefact artefact);

        IArtefact this[string name] { get; }
    }

    class Sonic : ICharacter
    {
        public string Name { get; } = "Sonic";
        public void Run()
        {
            Console.WriteLine("Sonic is running");
        }
        public void Jump()
        {
            Console.WriteLine("Sonic is jumping");
        }
        public void Super()
        {
            Console.WriteLine("Sonic is super running");
        }
    }

    class Foxy : ICharacter
    {
        public string Name { get; } = "Foxy";

        public void Run()
        {
            Console.WriteLine("Foxy is running");
        }
        public void Jump()
        {
            Console.WriteLine("Foxy is jumping");
        }
        public void Super()
        {
            Console.WriteLine("Foxy is flying");
        }
    }
}
