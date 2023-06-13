using ExPropException.Entities;
using ExPropException.Entities.Exceptions;
using System.Globalization;

namespace ExPropException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            { 
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine()!);
                Console.Write("Holder: ");
                string holder = Console.ReadLine()!;
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double limit = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                Account account = new Account(holder, number, balance, limit);

                Console.Write("\nEnter amount for withdraw: ");
                double withdraw = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                account.Withdraw(withdraw);
                Console.WriteLine("New Balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch(DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
            

        }
    }
}