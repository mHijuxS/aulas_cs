using System;
using System.Globalization;

namespace ExVect
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine()!);

            Registry[] registry = new Registry[10];

            for (int i =0; i < n; i++)
            {
                Console.WriteLine("\nRent # " + (i+1));
                Console.Write("Name: ");
                string name = Console.ReadLine()!;
                Console.Write("Email: ");
                string mail = Console.ReadLine()!;
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine()!);

                registry[room] = new Registry(name, room, mail);
            }

            Console.WriteLine("\nBusy rooms:");
            for (int i = 0; i < 10; i++)
            {
                if (registry[i] != null)
                {
                    Console.WriteLine(registry[i].Room + ": " + registry[i].Name + ", " + registry[i].Mail);
                }
            }
        }
    }
}