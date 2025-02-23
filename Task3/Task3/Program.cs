public class BankAccount
{
    public int AccountNumber;
    public string HolderName;
    public double Balance;

    public BankAccount(int Account_Number, string Holder_Name, double _Balance)
    {
        AccountNumber = Account_Number;
        HolderName = Holder_Name;
        Balance = _Balance;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Name: " + HolderName);
        Console.WriteLine("Account Number: " + AccountNumber);
        Console.WriteLine("Balance: " + Balance);
    }

    public void Deposit(double amount)
    {
        Balance += amount;
        DisplayDetails();
    }

    public void Withdraw(double amount)
    {
        Balance -= amount;
        if (Balance >= 0)
        {
            DisplayDetails();
        }
        else
        {
            Console.WriteLine("You do not have enough money:");
        }
    }

}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("What is the holder's name?");
        string HolderName = Console.ReadLine();
        Console.WriteLine("What is the holder's account number?");
        int AccountNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the balance");
        double balance = double.Parse(Console.ReadLine());

        BankAccount account = new BankAccount(AccountNumber, HolderName, balance);
        account.DisplayDetails();

        bool loop = true;
        while (loop)
        {
            Console.WriteLine("You want deposit or withdraw, press [1] for deposit, [2] for withdraw or [0] to exit programm");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.WriteLine("Input amount:");
                    double deposit_amount = double.Parse(Console.ReadLine());
                    account.Deposit(deposit_amount);
                    break;
                case 2:
                    Console.WriteLine("Input amount:");
                    double withdraw_amount = double.Parse(Console.ReadLine());
                    account.Withdraw(withdraw_amount);
                    break;
                case 0:
                    loop = false;
                    break;
            }
        }
    }
}