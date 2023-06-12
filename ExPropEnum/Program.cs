using ExPropEnum.Entities;
using ExPropEnum.Entities.Enums;
using System;
namespace ExPropEnum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");

            Console.Write("Name: ");
            string name = Console.ReadLine()!;
            Console.Write("Email: ");
            string email = Console.ReadLine()!;
            Console.Write("Birth date (DD/MM/YYYY: ");
            DateTime birhDate = DateTime.Parse(Console.ReadLine()!);
            Client client = new Client()
            {
                Name = name,
                Email = email,
                BirthDate = birhDate
            };

            Console.WriteLine("Enter order data:");

            Console.Write("Status: ");
            OrderStatus orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine()!);
            DateTime time = DateTime.Now;
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine()!);

            Order order = new Order()
            {
                Client = client,
                Moment = time,
                Status = orderStatus,

            };

            for (int i = 0; i < n; i++)
            {
                Console.Write("Product name: ");
                string prod_name = Console.ReadLine()!;
                Console.Write("Product price: ");
                double prod_price = double.Parse(Console.ReadLine()!);
                Console.Write("Quantity: ");
                int prod_quantity = int.Parse(Console.ReadLine()!);
                Product prod = new Product()
                {
                    Name = prod_name,
                    Price = prod_price,
                };
                OrderItem ord_it = new OrderItem()
                {
                    Quantity = prod_quantity,
                    Price = prod_price,
                    Product = prod
                };
                order.AddItem(ord_it);

            }

            Console.WriteLine("\n" + order);
        }
    }
}