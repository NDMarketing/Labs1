using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QABank
{
    public class BankAccount
    {
        public string CustomerName { get; set; }
        public int? AccountNumber { get; set; }
        public decimal Balance { get; set; }

        public static int newAccountNumber = 100000;
        public BankAccount(string customerName, decimal balance, int? accountNumber = null)
        {
            
            CustomerName = customerName;

            if(accountNumber == null) 
            {
                AccountNumber = newAccountNumber; 
                GenerateAccountNumber();
            }

            else
            {
                AccountNumber = accountNumber;
            }
            Balance = balance;
        }

        public int GenerateAccountNumber()
        {
            return newAccountNumber++;
        }

        public void Deposit (decimal balance, decimal depositAmount)
        {
            Balance = balance + depositAmount;
        }

        public void Withdraw(decimal balance, decimal withdrawAmount)
        {
            Balance = balance - withdrawAmount;
        }
    }
}
