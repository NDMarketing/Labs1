using System;
using System.Collections.Generic;

namespace QABank
{
    class Program
    {
        // helper for printing results
        static void printResults (string transaction, BankAccount account)
        {
            Console.WriteLine($"Customer Name: {account.CustomerName}, Account Number: {account.AccountNumber}, Balance: {account.Balance}");
            if (transaction != null)
            {
                Console.WriteLine($"After {transaction} **************************");
                return;
            }
            return;
        }

        static void Main(string[] args)
        {

            // creating bankAccount Objects and add to list
            List<BankAccount> accounts = new List<BankAccount>();
            accounts.Add( new BankAccount("Jimmy",30.5m));
            accounts.Add(new BankAccount("Pete", 30.5m, 100002));
            accounts.Add(new BankAccount("Paul", 30.5m));

            // run through accounts and print details.
            foreach (BankAccount account in accounts) 
            {
                Console.WriteLine("Starting Balance**************************"); printResults(null, account);
                account.Deposit(100); printResults("Deposit", account);
                account.Deposit(50); printResults("Deposit", account);
                account.Withdraw(200); printResults("Withdrawal", account);
                account.Deposit(25650); printResults("Deposit", account);
            }

            // so we can read it
            Console.ReadLine();

        }
    }
}
