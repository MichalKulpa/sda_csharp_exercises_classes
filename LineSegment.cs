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
            Start = new MyPoint3D(startX, startY, startZ);
            End = new MyPoint3D(endX, endY, endZ);
        }
        public LineSegment(int startX, int startY, int endX, int endY)
        {
            Start = new MyPoint3D(startX, startY,0);
            End = new MyPoint3D(endX, endY,0);
        }
        public LineSegment(MyPoint start,MyPoint end)
        {
            Start = new MyPoint3D(start.X,start.Y,0);
            End = new MyPoint3D(end.X,end.Y,0);
        }
        public double Lenght()
        {
            return Start.GetDistanceFromPoint(End);           
        }
    }
}
