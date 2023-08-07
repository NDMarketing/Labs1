namespace QABank.Interfaces
{
    public interface IBankAccountService
    {
        int GenerateAccountNumber();
        decimal Deposit(decimal depositAmount);
        decimal Withdraw(decimal depositAmount);
    }
}
