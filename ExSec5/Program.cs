using System;
using System.Globalization;
namespace ExSec5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine()!);
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine()!;

            Banco conta = new Banco(titular, numero);

            Console.Write("Haverá depósito inicial (s/n)? ");
            string op = Console.ReadLine()!;
            if (op == "s" || op == "S")
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double aux = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                conta.Depositar(aux);
                Console.WriteLine("\nDados da conta:\n" + conta, CultureInfo.InvariantCulture);
            } else
            {
                Console.WriteLine("\nDados da conta:");
                Console.WriteLine(conta);
            }

            Console.Write("\nEntre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            conta.Depositar(deposito);
            Console.WriteLine("Dados da conta atualizados:" +
                                "\n" +
                                conta);

            Console.Write("\nEntre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            conta.Sacar(saque);
            Console.WriteLine("Dados da conta atualizados:" +
                                "\n" +
                                conta);
        }
    }
}