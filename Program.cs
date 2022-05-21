using System;

namespace sda_csharp_exercises_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            MyPoint3D start = new(1, 2,3);
            MyPoint3D end = new(5, 6,7);
            LineSegment lineSegment1 = new(1, 2,3, 5, 6,7);
            LineSegment lineSegment2 = new(start, end);
            Console.WriteLine(lineSegment1.GetLenght());
            Console.WriteLine(lineSegment2.GetLenght());
        }
    }
}
