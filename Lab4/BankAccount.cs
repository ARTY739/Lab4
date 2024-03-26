public class BankAccount : IAccount
{
    public string AccountNumber { get; }
    public decimal Balance { get; private set; }

    public BankAccount(string accountNumber)
    {
        AccountNumber = accountNumber;
        Balance = 0;
    }

    public void Deposit(decimal amount)
    {
        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount > Balance)
        {
            Console.WriteLine("������������ ������� �� �����.");
        }
        else
        {
            Balance -= amount;
        }
    }

    public void DisplayAccountInfo()
    {
        Console.WriteLine($"���� �: {AccountNumber}");
        Console.WriteLine($"������: {Balance}");
    }
}