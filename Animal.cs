using System;

namespace sda_csharp_exercises_classes
{
    class Animal
    {
        public string Name { get; set; }
        public Animal(string name)
        {
            Name = name;
        }
        public virtual void MakeSound()
        {           
        }
    }
}
