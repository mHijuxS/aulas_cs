using System;
using System.Globalization;

namespace ExFixList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine()!);

            List<Employee> list = new List<Employee>();
            for (int i=0; i < n; i++)
            {
                Console.WriteLine("Employee # " + (i+1));
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine()!);

                Console.Write("Name: ");
                string name = Console.ReadLine()!;

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

                list.Add(new Employee(id, salary, name));
            }

            Console.Write("\nEnter the employee id that will have salary increase: ");
            int inc_id = int.Parse(Console.ReadLine()!);
            Employee emp = list.Find(x => x.Id == inc_id);
            
            if (emp != null) 
            {
                Console.Write("Enter the percentage: ");
                int percentage = int.Parse(Console.ReadLine()!);

                emp.IncreaseSalary(percentage);
                Console.WriteLine("Updated list of employees");
                foreach(Employee aux in list)
                {
                    Console.WriteLine(aux);
                }
            }
            else
            {
                Console.WriteLine("This id does not exis!");
                Console.WriteLine("\nUpdated list of employees:");
                foreach(Employee aux in list)
                {
                    Console.WriteLine(aux);
                }
            }

        }
    }
}