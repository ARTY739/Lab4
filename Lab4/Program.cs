class Program
{
    static void Main(string[] args)
    {
        IAccountManager accountManager = new AccountManager();

        accountManager.OpenAccount("123456");
        accountManager.Deposit("123456", 1000);
        accountManager.Withdraw("123456", 500);
        accountManager.CloseAccount("123456");

        Console.ReadLine();
    }
}