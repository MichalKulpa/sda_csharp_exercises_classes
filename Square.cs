namespace sda_csharp_exercises_classes
{
    class Square : IShape
    {
        public int Side { get; set; }
        public Square(int side)
        {
            Side = side;
        }
        public double GetArea()
        {
            return Side * Side;
        }

    }
}
