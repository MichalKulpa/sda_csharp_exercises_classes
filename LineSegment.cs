using System;

namespace sda_csharp_exercises_classes
{
    class LineSegment
    {
        public MyPoint3D Start { get; set; }
        public MyPoint3D End { get; set; }
        public LineSegment(MyPoint3D start, MyPoint3D end)
        {
            Start = start;
            End = end;
        }
        public LineSegment(int startX, int startY, int startZ, int endX, int endY, int endZ)
        {
            Start = new(startX, startY, startZ);
            End = new(endX, endY, endZ);
        }
        public double Lenght()
        {
            return Math.Sqrt(Math.Pow(End.X - Start.X, 2) + Math.Pow(End.Y - Start.Y, 2) + Math.Pow(End.Z - Start.Z, 2));
        }
    }
}
