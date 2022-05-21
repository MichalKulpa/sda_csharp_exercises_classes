using System;

namespace sda_csharp_exercises_classes
{
    class Circle : IShape
    {
        public int Radius { get; set; }
        public Circle(int radius)
        {
            Radius = radius;
        }
        public double GetArea()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
