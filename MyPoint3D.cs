namespace sda_csharp_exercises_classes
{
    class MyPoint3D : MyPoint
    {
        public int Z { get; set; }
        public MyPoint3D(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }
    }
}
