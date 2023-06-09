using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExFixList
{
    internal class Employee
    {
        public int Id { get; private set; }

        public string Name { get; private set; }

        public double Salary { get; private set; }

   
        public Employee(int id, double salary, string name)
        {
            Id = id;
            Salary = salary;
            Name = name;
        }

        public void IncreaseSalary(double percentage)
        {
            Salary *= (1+ percentage/100);
        }

        public override string ToString()
        {
            return Id +
                ", " +
                Name +
                ", " +
                Salary.ToString("F3", CultureInfo.InvariantCulture);
        }
    }
}
