using Enumeracao.Entities;
using Enumeracao.Entities.Enums;
using System;

namespace Enumeracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            // conversão de tipos
            string txt = OrderStatus.PendingPayment.ToString(); // tipo enum para string 
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); //tem que ser igual ao que está descrito no Enum

            Console.WriteLine(txt);
            Console.WriteLine(os);
        }
    }
}
