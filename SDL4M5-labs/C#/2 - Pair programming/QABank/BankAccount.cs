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
            AccountNumber = accountNumber ?? GenerateAccountNumber();
            Balance = balance;
        }

        public int GenerateAccountNumber() => newAccountNumber++;

        public decimal Deposit(decimal depositAmount) => Balance += depositAmount;

        public decimal Withdraw(decimal depositAmount) => Balance -= depositAmount;

    }
}
