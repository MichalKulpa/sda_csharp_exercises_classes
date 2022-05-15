using System;

namespace sda_csharp_exercises_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderItem[] order = new OrderItem[]
            {
                new OrderItem("Chleb",5,3.50M),
                new OrderItemWithPackage("Mleko",5,2.20M,"butelka",1.00M),
                new OrderItem("Bułka",20,1.00M),
                new OrderItemWithPackage("Ser",10,5.50M,"pudełko",0.50M)
            };
            Order order1 = new Order(order);
            order1.PrintOrderInfo();
        }
        
    }
}
