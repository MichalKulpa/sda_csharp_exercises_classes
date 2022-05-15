using System;

namespace sda_csharp_exercises_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Order[] order = new Order[]
            {
                new OrderItem("Chleb",5,3.50M),
                new OrderItemWithPackage("Mleko",5,2.20M,"butelka",1.00M),
                new OrderItem("Bułka",20,1.00M),
                new OrderItemWithPackage("Ser",10,5.50M,"pudełko",0.50M)
            };
            PrintOrderInfo(order);
        }
        static void PrintOrderInfo(Order[] order)
        {
            decimal sum = 0.00M;
            foreach(Order item in order)
            {
                Console.WriteLine(item.ToString());
                sum += item.GetValue();
            }
            Console.WriteLine($"Całkowita wartość zamówienia: {sum} PLN");
        }
    }
}
