public class AccountManager : IAccountManager
{
    private readonly Dictionary<string, BankAccount> accounts;

    public AccountManager()
    {
        accounts = new Dictionary<string, BankAccount>();
    }

    public void OpenAccount(string accountNumber)
    {
        if (!accounts.ContainsKey(accountNumber))
        {
            BankAccount account = new BankAccount(accountNumber);
            accounts.Add(accountNumber, account);
            Console.WriteLine($"���� {accountNumber} ������� ������.");
        }
        else
        {
            Console.WriteLine($"���� {accountNumber} ��� ����������.");
        }
    }

    public void CloseAccount(string accountNumber)
    {
        if (accounts.ContainsKey(accountNumber))
        {
            accounts.Remove(accountNumber);
            Console.WriteLine($"���� {accountNumber} ������� ������.");
        }
        else
        {
            Console.WriteLine($"���� {accountNumber} �� ������.");
        }
    }

    public void Deposit(string accountNumber, decimal amount)
    {
        if (accounts.ContainsKey(accountNumber))
        {
            accounts[accountNumber].Deposit(amount);
            Console.WriteLine($"�� ���� {accountNumber} ������� {amount}.");
        }
        else
        {
            Console.WriteLine($"���� {accountNumber} �� ������.");
        }
    }

    public void Withdraw(string accountNumber, decimal amount)
    {
        if (accounts.ContainsKey(accountNumber))
        {
            accounts[accountNumber].Withdraw(amount);
            Console.WriteLine($"�� ����� {accountNumber} ����� {amount}.");
        }
        else
        {
            Console.WriteLine($"���� {accountNumber} �� ������.");
        }
    }
}