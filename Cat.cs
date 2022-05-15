using System;

namespace sda_csharp_exercises_classes
{
    class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
            Name = name;
        }
        public override void MakeSound()
        {
            Console.WriteLine(value: $"{Name} wydaje dźwięk miau");
        }
    }
}
