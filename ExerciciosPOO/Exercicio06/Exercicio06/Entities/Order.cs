using Exercicio06.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio06.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Item { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }
        public double TotalItem { get; set; }

        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Item.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Item.Add(item);
        }
        public double Total()
        {
            double sum = TotalItem;
            foreach(OrderItem price in Item)
            {
                sum += price.SubTotal();
            }
            return sum;
        }
    }
}
