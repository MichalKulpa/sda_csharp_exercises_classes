using System;

namespace sda_csharp_exercises_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractShape[] shapes = new AbstractShape[]
            {
                new Circle(3),
                new Circle(4),
                new Square(5),
                new Square(6)
            };
            Console.WriteLine(GetTotalArea(shapes));
        }
        static double GetTotalArea(AbstractShape[] shapes)
        {
            double sum = 0;
            for(int i = 0; i < shapes.Length; i++)
            {
                sum += shapes[i].GetArea();
            }
            return sum;
        }
    }
}
