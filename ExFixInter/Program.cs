using System.Globalization;
using ExFixInter.Entities;
using ExFixInter.Services;

namespace ExFixInter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine()!);
            Console.Write("Data (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine()!, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int n_installments = int.Parse(Console.ReadLine()!);

            Contract cont = new Contract(number, date, value);

            ContractService service = new ContractService(new PaypalServices());
            service.ProcessContract(cont, n_installments);


            Console.WriteLine("Installments:");

            
            foreach(Installment inst in cont.Installments)
            {
                Console.WriteLine(inst);
            }

        }
    }
}