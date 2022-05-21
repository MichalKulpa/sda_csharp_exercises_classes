namespace sda_csharp_exercises_classes
{
    class Square:AbstractShape
    {
        public int Side { get; set; }
        public Square(int side)
        {
            Side = side;
        }
        public override double GetArea()
        {
            return Side * Side;
        }
    }
}
