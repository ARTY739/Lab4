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
            Console.WriteLine($"—чет {accountNumber} успешно открыт.");
        }
        else
        {
            Console.WriteLine($"—чет {accountNumber} уже существует.");
        }
    }

    public void CloseAccount(string accountNumber)
    {
        if (accounts.ContainsKey(accountNumber))
        {
            accounts.Remove(accountNumber);
            Console.WriteLine($"—чет {accountNumber} успешно закрыт.");
        }
        else
        {
            Console.WriteLine($"—чет {accountNumber} не найден.");
        }
    }

    public void Deposit(string accountNumber, decimal amount)
    {
        if (accounts.ContainsKey(accountNumber))
        {
            accounts[accountNumber].Deposit(amount);
            Console.WriteLine($"Ќа счет {accountNumber} внесено {amount}.");
        }
        else
        {
            Console.WriteLine($"—чет {accountNumber} не найден.");
        }
    }

    public void Withdraw(string accountNumber, decimal amount)
    {
        if (accounts.ContainsKey(accountNumber))
        {
            accounts[accountNumber].Withdraw(amount);
            Console.WriteLine($"—о счета {accountNumber} сн€то {amount}.");
        }
        else
        {
            Console.WriteLine($"—чет {accountNumber} не найден.");
        }
    }
}