using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises_classes
{
    class Dog : Animal
    {
        public Dog(string name):base(name)
        {
            Name = name;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} wydae dźwięk hau");
        }
    }
}
