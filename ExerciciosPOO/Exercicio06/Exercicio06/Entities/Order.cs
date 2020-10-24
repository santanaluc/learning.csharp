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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Order Status: ");
            //sb.AppendLine(Status);
            sb.Append("Client: ");
            sb.AppendLine(Client.Name + " (" + Client.Birth + ") - " + Client.Email);
            sb.AppendLine("Order items:");

            foreach (OrderItem o in Item)
            {
                sb.AppendLine(o.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2"));
            return sb.ToString();
        }
    }
}
