class Program
{
    static void Main(string[] args)
    {
        IAccountManager accountManager = new AccountManager();

        while (true)
        {
            Console.WriteLine("Выберите операцию (1 - Открыть счёт, 2 - Положить деньги на счёт, 3 - Снять деньги со счёта, 4 - Закрыть счёт): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Выберите номер счёта: ");
                string number = Console.ReadLine();
                accountManager.OpenAccount(number);
            }
            else if (choice == 2)
            {
                Console.WriteLine("Выберите номер счёта: ");
                string number = Console.ReadLine();
                Console.WriteLine("Выберите сумму: ");
                int money = Convert.ToInt32(Console.ReadLine());
                accountManager.Deposit(number, money);
            }
            else if (choice == 3)
            {
                Console.WriteLine("Выберите номер счёта: ");
                string number = Console.ReadLine();
                Console.WriteLine("Выберите сумму: ");
                int money = Convert.ToInt32(Console.ReadLine());
                accountManager.Withdraw(number, money);
            }
            else if (choice == 4)
            {
                Console.WriteLine("Выберите номер счёта: ");
                string number = Console.ReadLine();
                accountManager.CloseAccount(number);
            }
            else
            {
                Console.WriteLine("Неверный выбор.");
                continue;
            }
        }
    }
}