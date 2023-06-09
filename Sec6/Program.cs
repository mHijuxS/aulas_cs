//STRUCTS são tipos valor





using System; 
namespace Sec6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double? x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            double z = x ?? 2;
            Console.WriteLine($"x tem valor? {x.HasValue}\n z = {z}");
        }
    }
}