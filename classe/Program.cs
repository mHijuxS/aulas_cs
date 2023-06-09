using ex_classes;
using System;

namespace ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa maria, joao;
            maria = new Pessoa();
            joao = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa");
            Console.Write("Nome: ");
            maria.nome = Console.ReadLine()!;
            Console.Write("Idade: ");
            maria.idade = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            joao.nome = Console.ReadLine()!;
            Console.Write("Idade: ");
            joao.idade = int.Parse(Console.ReadLine()!);
            
            
            Console.Write("Pessoa mais velha: ");
            if (maria.idade >= joao.idade)
            {
                Console.WriteLine( maria.nome);
            }
            else
            {
                Console.WriteLine( joao.nome);
            }
        }
    }
}