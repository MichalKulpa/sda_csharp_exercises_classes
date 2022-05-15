using System;

namespace sda_csharp_exercises_classes
{
    class Employee : Person
    {
        public decimal Salary { get; set; }
        //public Employee()
        //{
        //    Console.WriteLine($"{nameof(Employee)} created without parameters");
        //}
        public Employee(string firstName,string lastName,int yearOfBirth,decimal salary): base( firstName, lastName,yearOfBirth)
        {
            Salary = salary;
        }
    }
}
