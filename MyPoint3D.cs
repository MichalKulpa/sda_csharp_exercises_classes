using System;

namespace sda_csharp_exercises_classes
{
    class MyPoint3D : MyPoint
    {
        public int Z { get; set; }
        public MyPoint3D(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }
        public override double GetDistanceFromPoint(MyPoint3D point)
        {          
           return Math.Sqrt(Math.Pow(X + point.X, 2) + Math.Pow(Y + point.Y, 2) + Math.Pow(Z + point.Z, 2));
                       
        }
    }
}
