using System;

namespace sda_csharp_exercises_classes
{
    class MyPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
        public MyPoint(int x=0, int y=0)
        {
            X = x;
            Y = y;
        }
        
        public virtual double GetDistanceFromPoint(MyPoint end)
        {
            return Math.Sqrt(Math.Pow(X+end.X,2)+Math.Pow(Y+end.Y,2));
        }
    }
}
