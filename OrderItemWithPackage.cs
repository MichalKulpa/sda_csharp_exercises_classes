namespace sda_csharp_exercises_classes
{
    class OrderItemWithPackage:OrderItem
    {
        public string PackageName { get; set; }
        public decimal PackagePrice { get; set; }
        public OrderItemWithPackage(string productName,int quantity, decimal unitPrice, string packageName, decimal packagePrice) :base(productName,quantity,unitPrice)
        {
            PackageName = packageName;
            PackagePrice = packagePrice;
        }
        public override decimal GetValue()
        {
            return base.GetValue()+PackagePrice*Quantity;
        }
        public override string ToString()
        {
            return $"{ProductName}, cena: {UnitPrice} PLN, opakowanie:{PackageName}, cena opakowania: {PackagePrice} PLN, {Quantity} szt, wartość: {GetValue()} PLN";
        }
    }
}
