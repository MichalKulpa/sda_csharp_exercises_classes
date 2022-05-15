using System;

namespace sda_csharp_exercises_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal []
            {
                new Cat("Mruczek"),
                new Dog ("Burek"),
                new Cat ("Czesiek"),
                new Dog("Reksio")
            };
            foreach(Animal animal in animals)
            {
                animal.MakeSound();
                if(animal is Cat)
                {
                    Console.WriteLine("kot");
                }
                else if (animal is Dog)
                {
                    Console.WriteLine("pies");
                }
            }
        }
    }
}
