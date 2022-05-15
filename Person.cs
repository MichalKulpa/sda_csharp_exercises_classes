using System;

namespace sda_csharp_exercises_classes
{
    class Person
    {
        const int PROPER_AGE = 18;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int YearOfBirth { get; set; }
        public void WhoAmI()
        {
            Console.WriteLine($"{FirstName} {LastName} ");
        }
        //public bool IsAdult()
        //{
        //    const int PROPER_AGE = 18;
        //    int currentYear = DateTime.Now.Year;
        //    return currentYear - YearOfBirth >= PROPER_AGE;
        //}
        public bool IsAdult => (DateTime.Now.Year) - YearOfBirth >= PROPER_AGE;
        public Person(string firstName, string lastName, int yearOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            YearOfBirth = yearOfBirth;
        }
    }
}
