public interface IAccount
{
    string AccountNumber { get; }
    decimal Balance { get; }
    void Deposit(decimal amount);
    void Withdraw(decimal amount);
    void DisplayAccountInfo();
}