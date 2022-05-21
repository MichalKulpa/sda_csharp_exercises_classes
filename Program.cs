using System;

namespace sda_csharp_exercises_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            MyPoint start = new(1, 2);
            MyPoint end = new(5, 6);
            LineSegment lineSegment1 = new(1, 2, 5, 6);
            LineSegment lineSegment2 = new(start, end);
            Console.WriteLine(lineSegment1.Lenght());
            Console.WriteLine(lineSegment2.Lenght());
        }
    }
}
