using Heranca.Entities;
using System;
namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Account acc = new Account(1001, "Alex", 0.0);

            //BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            ////UPCASTING
            //Account acc1 = bacc;

            //Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);

            //Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            ////DOWNCASTING (OPERAÇÃO INSEGURA)
            //BusinessAccount acc4 = (BusinessAccount)acc2;
            //acc4.Loan(100.0);

            //// BusinessAccount acc5 = (BusinessAccount)acc3; //ERRO EM TEMPO DE EXECUÇÃO

            ////TESTES 
            //if (acc3 is BusinessAccount)
            //{
            //    BusinessAccount acc5 = (BusinessAccount)acc3;
            //    acc5.Loan(200);
            //    Console.WriteLine("Loan!");
            //}
            //if (acc3 is SavingsAccount)
            //{
            //    //SavingsAccount acc5 = (SavingsAccount)acc3;
            //    //OU
            //    SavingsAccount acc5 = acc3 as SavingsAccount;
            //    acc5.UpdateBalance();
            //    Console.WriteLine("Update!");
            //}

            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}