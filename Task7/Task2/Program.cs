public class InkReservoir
{
    private string Color { get; }
    private double InkAmount { get; }

    public InkReservoir(string Color, double InkAmount)
    {
        this.Color = Color;
        this.InkAmount = InkAmount;
    }
    public override string ToString()
    {
        return ($"Color: {Color} InkAmount {InkAmount}");
    }

    public static InkReservoir operator +(InkReservoir reserv1, InkReservoir reserv2)
    {
        if (reserv1.Color == reserv2.Color)
        {
            return new InkReservoir("new_black", reserv1.InkAmount + reserv2.InkAmount);
        }
        Console.WriteLine("Colors are different, can't be merge");
        return null;
    }

    public static InkReservoir operator -(InkReservoir reserv, string str)
    {
        if (str.Length <= reserv.InkAmount)
        {
            return new InkReservoir(reserv.Color, reserv.InkAmount - str.Length);
        }
        Console.WriteLine("Not enough Ink");
        return null;
    }
}

public class Program
{
    public static void Main()
    {
        InkReservoir reserv1 = new InkReservoir("Blue", 44);
        InkReservoir reserv2 = new InkReservoir("Blue", 73);

        InkReservoir merge_result = reserv1 + reserv2;
        Console.WriteLine(merge_result);
        Console.WriteLine("Write something");
        string str = Console.ReadLine();
        if (str != null)
        {
            InkReservoir write_smth = reserv1 - str;
            Console.WriteLine(write_smth);
        }

        Console.ReadKey();
    }
}