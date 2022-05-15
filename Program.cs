using System;

namespace sda_csharp_exercises_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] guests = new Person[] 
            {
                new Person("Jan","Kowalski",1990),
                new Employee("Adam","Nowak",2000,5000.00M)
            };
            
        }
    }
}
