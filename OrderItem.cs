namespace sda_csharp_exercises_classes
{
    class OrderItem
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; } 
        public decimal UnitPrice { get; set; }
        public OrderItem(string productName,int quantity,decimal unitPrice)
        {
            ProductName = productName;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }
        public virtual decimal GetValue()
        {
            return Quantity*UnitPrice;
        }
        public override string ToString()
        {
            return $"{ProductName}, cena: {UnitPrice} PLN, {Quantity} szt, wartość: {GetValue()} PLN";
        }
    }
}
