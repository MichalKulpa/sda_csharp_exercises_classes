using System;

namespace sda_csharp_exercises_classes
{
    class MyPoint3D : MyPoint
    {
        public int Z { get; set; }
        public MyPoint3D(int x, int y, int z=0) : base(x, y)
        {
            Z = z;
        }
        public override double GetDistanceFromPoint(MyPoint end)
        {          
           if (end is MyPoint3D tmp)
            {
                return Math.Sqrt(Math.Pow(X + tmp.X, 2) + Math.Pow(Y + tmp.Y, 2)+Math.Pow(Z+tmp.Z,2));
            }
            else
            {
                return Math.Sqrt(Math.Pow(X + end.X, 2) + Math.Pow(Y + end.Y, 2));
            }
                       
        }
    }
}
