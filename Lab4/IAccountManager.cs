public interface IAccountManager
{
    void OpenAccount(string accountNumber);
    void CloseAccount(string accountNumber);
    void Deposit(string accountNumber, decimal amount);
    void Withdraw(string accountNumber, decimal amount);
}