using System;

namespace QABank
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount("Jimmy",30.5m);
            BankAccount bankAccount2 = new BankAccount("Pete", 30.5m);

            Console.WriteLine(bankAccount.AccountNumber);
            Console.WriteLine(bankAccount2.AccountNumber);

            bankAccount.Deposit(bankAccount.Balance, 100m);
            Console.WriteLine(bankAccount.Balance);

            Console.ReadLine();

        }
    }
}
