using System;

namespace sda_csharp_exercises_classes
{
    class Order
    {
       public OrderItem[] Items { get; set; }
        public Order(OrderItem[] items)
        {
            Items = items;
        }
        public void PrintOrderInfo()
        {
            decimal sum = 0.00M;
            foreach (OrderItem item in Items)
            {
                Console.WriteLine(item.ToString());
                sum += item.GetValue();
            }
            Console.WriteLine($"Całkowita wartość zamówienia: {sum} PLN");
        }
    }
}
