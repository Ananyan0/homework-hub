public class BankAccount
{
    public int AccountNumber { get; set; }
    public int Balance { get; set; }

    public BankAccount(int accountNumber, int balance)
    {
        AccountNumber = accountNumber;
        Balance = balance;
    }

    public override string ToString()
    {
        return ($"Account number: {AccountNumber} Balance: {Balance}");
    }

    public override bool Equals(object obj)
    {
        BankAccount other = (BankAccount)obj;
        return AccountNumber == other.AccountNumber;
    }

    public override int GetHashCode()
    {
        return AccountNumber.GetHashCode() ^ 2131;
    }

    public static BankAccount operator +(BankAccount obj1, int amount)
    {
        return new BankAccount(obj1.AccountNumber, obj1.Balance + amount);
    }

    public static BankAccount operator -(BankAccount obj2, int amount)
    {
        if (amount > obj2.Balance)
        {
            Console.WriteLine("Do not have enough money");
            return null;
        }
        return new BankAccount(obj2.AccountNumber, obj2.Balance - amount);
    }

    public static bool operator >(BankAccount obj1, BankAccount obj2)
    {
        return obj1.Balance > obj2.Balance;
    }
    public static bool operator <(BankAccount obj1, BankAccount obj2)
    {
        return obj1.Balance < obj2.Balance;
    }
    public static bool operator >=(BankAccount obj1, BankAccount obj2)
    {
        return obj1.Balance >= obj2.Balance;
    }
    public static bool operator <=(BankAccount obj1, BankAccount obj2)
    {
        return obj1.Balance <= obj2.Balance;
    }
}


public class Program
{
    public static void Main()
    {
        BankAccount obj1 = new BankAccount(205009095, 1000);
        BankAccount obj2 = new BankAccount(205011095, 5000);

        Console.WriteLine(obj1.ToString());
        Console.WriteLine(obj1.Equals(obj2));
        Console.WriteLine(obj1.GetHashCode());

        Console.WriteLine("Enter deposit amount:");
        int deposit_amount = int.Parse(Console.ReadLine());
        BankAccount deposit = obj1 + deposit_amount;
        Console.WriteLine(deposit);
        Console.WriteLine("Enter withdraw amount:");
        int withdraw_amount = int.Parse(Console.ReadLine());
        BankAccount withdraw = obj2 - withdraw_amount;
        Console.WriteLine(withdraw);

        Console.ReadLine();
    }
}