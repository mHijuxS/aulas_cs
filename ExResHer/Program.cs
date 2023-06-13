using ExResHer.Entities;
using System.Globalization;
using System.Text;

namespace ExResHer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int number_employees = int.Parse(Console.ReadLine()!);

            List<Employee> employees = new List<Employee>();
            for(int i=0; i<number_employees; i++)
            {
                Console.WriteLine($"Employee #{1+i} data:");
                Console.Write("Outsourced (y/n)? ");
                string option = Console.ReadLine()!;
                if (option == "n")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine()!;
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine()!);
                    Console.Write("Value per hour: ");
                    double vph = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                    Employee employee = new Employee(name, hours, vph);
                    employees.Add(employee);
                }
                else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine()!;
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine()!);
                    Console.Write("Value per hour: ");
                    double vph = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                    Console.Write("Additional charge: ");
                    double add_charge = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

                    Employee employee = new OutsourcedEmployee(name, hours, vph, add_charge);
                    employees.Add(employee);
                }
            }

            Console.WriteLine("\nPAYMENTS");
            StringBuilder sb = new StringBuilder();
            foreach(Employee emp in employees)
            {
                sb.AppendLine(emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.WriteLine(sb.ToString());
        }
    }
}