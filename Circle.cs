using System;

namespace sda_csharp_exercises_classes
{
    class Circle:AbstractShape
    {
        public int Radius { get; set; }
        public Circle(int radius)
        {
            Radius = radius;
        }
        public override double GetArea()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
