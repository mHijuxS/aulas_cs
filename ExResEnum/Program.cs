using ExResEnum.Entities.Enums;
using ExResEnum.Entities;
using System;
using System.Diagnostics.Contracts;

namespace ExResEnum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            Department department = new Department 
            { 
                Name = Console.ReadLine()! 
            };
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine()!;
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel workerLevel = Enum.Parse<WorkerLevel>(Console.ReadLine()!);
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine()!);
            Console.Write("How many contracts to this worker? ");
            int contracts = int.Parse(Console.ReadLine()!);

            List<HourContract> aux_contracts = new List<HourContract>();
            for (int i=0; i<contracts; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine()!);
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine()!);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine()!);
                HourContract contract = new HourContract
                {
                    Date = date,
                    ValuePerHour = valuePerHour,
                    Hours = hours
                };
                aux_contracts.Add(contract);
            }

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string[] aux_str = Console.ReadLine()!.Split('/');
            int month = int.Parse(aux_str[0]);
            int year = int.Parse(aux_str[1]);

            Worker worker = new Worker
            {
                Name = name,
                Level = workerLevel,
                BaseSalary = baseSalary,
                Department = department
            };

            foreach (HourContract contr in aux_contracts)
            {
                worker.AddContract(contr);
            }

            Console.WriteLine($"Name: {worker.Name} ");
            Console.WriteLine($"Department: {worker.Department.Name}");
            Console.WriteLine($"Income for {month}/{year}: {worker.Income(year,month)}");

        }
    }
}