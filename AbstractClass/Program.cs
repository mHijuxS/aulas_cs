using AbstractClass.Entities;
using AbstractClass.Entities.Enums;
using System.Globalization;

namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine()!);
            List<Shape> shapes = new List<Shape>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Shape #{1+i} data");
                Console.Write("Rectangle or Circle? (r/c)? ");
                string option = Console.ReadLine()!;
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine()!);

                if (option == "c")
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                    shapes.Add(new Circle(radius, color));
                }else 
                {
                    
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                    shapes.Add(new Rectangle(width, height, color));
                }
            }

            Console.WriteLine("\nSHAPE AREAS");
            foreach(Shape shape in shapes)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
