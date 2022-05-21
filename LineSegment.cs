using System;

namespace sda_csharp_exercises_classes
{
    class LineSegment
    {
        public MyPoint Start { get; set; }
        public MyPoint End { get; set; }
        public LineSegment(MyPoint start, MyPoint end)
        {
            Start = start;
            End = end;
        }
        public LineSegment(int startX, int startY, int endX, int endY)
        {
            Start = new(startX, startY);
            End = new(endX, endY);
        }
        public double Lenght()
        {
            return Math.Sqrt(Math.Pow(End.X - Start.X, 2) + Math.Pow(End.Y - Start.Y, 2));
        }
    }
}
