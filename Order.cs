namespace sda_csharp_exercises_classes
{
    class Order
    {
       public virtual decimal GetValue()
        {
            return 0.00M;
        }
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
