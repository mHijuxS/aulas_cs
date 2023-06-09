using System;
using System.Globalization;
namespace Datetime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);

            DateTime d2 = new DateTime(2018, 11, 25);
            Console.WriteLine(d2);

            DateTime d3 = new DateTime(2018, 11, 24, 12, 23, 44);
            Console.WriteLine(d3);

            DateTime d4 = DateTime.Today;
            Console.WriteLine(d4);

            DateTime d5 = DateTime.UtcNow;
            Console.WriteLine(d5);

            DateTime d6 = DateTime.Parse("2000-08-15");
            Console.WriteLine(d6);

            DateTime d7 = DateTime.Parse("2000-08-1 13:05:58");
            Console.WriteLine(d7);

            DateTime d8 = DateTime.Parse("15/08/2000 13:05:58");
            Console.WriteLine(d8);

            DateTime d9 = DateTime.ParseExact("2000-08-12", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine(d9);
        }
    }
}