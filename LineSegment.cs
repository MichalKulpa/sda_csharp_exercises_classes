using System;

namespace sda_csharp_exercises_classes
{
    class LineSegment
    {
        public MyPoint Start { get; set; }
        public MyPoint End { get; set; }
        public LineSegment(MyPoint3D start, MyPoint3D end)
        {
            Start = start;
            End = end;
        }
        public LineSegment(int startX, int startY, int startZ, int endX, int endY, int endZ)
        {
            Start = new MyPoint3D(startX, startY, startZ);
            End = new MyPoint3D(endX, endY, endZ);
        }
        public LineSegment(int startX, int startY, int endX, int endY)
        {
            Start = new MyPoint(startX, startY);
            End = new MyPoint(endX, endY);
        }
        public LineSegment(MyPoint start,MyPoint end)
        {
            Start = new MyPoint(start.X,start.Y);
            End = new MyPoint(end.X,end.Y);
        }
        public double GetLenght()
        {
            return Start.GetDistanceFromPoint(End);           
        }
    }
}
