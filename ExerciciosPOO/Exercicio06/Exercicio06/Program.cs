using Exercicio06.Entities;
using Exercicio06.Entities.Enums;
using System;

namespace Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birthday (MM/DD/YYYY): ");
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            Console.WriteLine();

            Client client = new Client(name, email, birthday);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus statusOrder = Enum.Parse<OrderStatus>(Console.ReadLine());
            DateTime date = DateTime.Now;
            Console.Write("How many items to this order: ");
            int items = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Order order = new Order(date, statusOrder, client);

            for (int i = 1; i <= items; i++)
            {
                Console.WriteLine($"Enter #{i} item data");
                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Product Price: ");
                double priceProduct = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int quantityProduct = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Product product = new Product(nameProduct, priceProduct);
                OrderItem orderItem = new OrderItem(quantityProduct, priceProduct, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine();

            Console.WriteLine("Order Summary");
            Console.WriteLine(order);
        }
    }
}
