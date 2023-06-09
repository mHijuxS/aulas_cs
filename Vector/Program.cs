using System;
using System.Globalization;
namespace Vector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);

            Product[] vect = new Product[n];
            //instancia apenas o vetor, devendo instanciar cada elemento do vetor separadamente

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                vect[i] = new Product { Name = name, Price = price };
            }

            double media = 0.0;
            for (int i=0;i<n;i++)
            {
                media += vect[i].Price;
            }
            media /= n;

            Console.WriteLine("AVERAGE PRICE = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}