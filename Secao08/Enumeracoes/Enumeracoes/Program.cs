using System;
using Enumeracoes.Entities;
using Enumeracoes.Entities.Enums;

namespace Enumeracoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            String txt = OrderStatus.PendingPayment.ToString();

            // OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivere");
            
            Console.WriteLine(txt);
            Console.WriteLine(os);
        }
    }
}
