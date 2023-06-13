using ExPropHer.Entities;
using System.Globalization;

namespace ExPropHer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine()!);

            List<Product> products = new List<Product>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Product #{i+1} data:");
                Console.Write("Common, used or imported? (c/u/i)? ");
                string option = Console.ReadLine()!;
                if (option == "c")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine()!;
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                    products.Add(new Product { Name = name, Price = price });
                }
                else if (option == "i")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine()!;
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                    Console.Write("Customs fee: ");
                    double fee = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                    products.Add(new ImportedProduct { Name = name, Price = price, CustomFee = fee });
                }
                else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine()!;
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine()!);
                    products.Add(new UsedProduct { Name = name, ManufactureDate = date , Price = price});                    
                }
            }

            Console.WriteLine("\nPRICE TAGS:");
            foreach (Product prod in products)
            {
                Console.WriteLine(prod.PriceTag());
            }

        }
    }
}

