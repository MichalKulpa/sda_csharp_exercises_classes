using System;

namespace sda_csharp_exercises_classes
{
    class MyPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
        public MyPoint(int x, int y)
        {
            X = x;
            Y = y;
        }
        public virtual double GetDistanceFromPoint(MyPoint3D point)
        {
            return Math.Sqrt(Math.Pow(X+point.X,2)+Math.Pow(Y+point.Y,2));
        }
    }
}
