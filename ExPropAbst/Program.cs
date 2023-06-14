using ExPropAbst.Entities;
using System.Text;
using System.Globalization;

namespace ExPropAbst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine()!);

            List<Pessoa> pessoas = new List<Pessoa>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Tax payer #{1+i} data");
                Console.Write("Individual or company (i/c)? ");
                string option = Console.ReadLine()!;
                
                switch (option)
                {
                    case "i":
                        Console.Write("Name ");
                        string name = Console.ReadLine()!;
                        Console.Write("Anual income: ");
                        double income = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                        Console.Write("Health expenditures: ");
                        double healthExpenditures = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                        pessoas.Add(new PessoaFisica(healthExpenditures, name, income));
                        break;
                    case "c":
                        Console.Write("Name ");
                        string nome = Console.ReadLine()!;
                        Console.Write("Anual income: ");
                        double renda = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                        Console.Write("Number of employees: ");
                        int employees = int.Parse(Console.ReadLine()!);
                        pessoas.Add(new PessoaJuridica(employees, nome, renda));
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine("\nTAXES PAID");
            double sum = 0;
            StringBuilder sb = new StringBuilder();
            foreach (Pessoa pessoa in pessoas)
            {
                sb.AppendLine(pessoa.Nome + ": $ " + pessoa.Imposto().ToString("F2", CultureInfo.InvariantCulture));
                sum += pessoa.Imposto();
            }
            sb.AppendLine("\nTOTAL TAXES: " + sum.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(sb.ToString());
        }
    }
}