public class Shopping
{
    string name;
    float price;
    int quantity;

    public Shopping(string name, float price, int quantity)
    {
        this.name = name;
        this.price = price;
        this.quantity = quantity;
    }

    public float TotalPrice()
    {
        return price * quantity;
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("How many products you will take?");
        int product_count = int.Parse(Console.ReadLine());
        Shopping[] shopping = new Shopping[product_count];
        float cost = 0;

        for (int i = 0; i < product_count; i++)
        {
            Console.WriteLine($"Enter the product's name:");
            string name = Console.ReadLine();
            Console.WriteLine($"Enter the price for {name}:");
            float price = float.Parse(Console.ReadLine());
            Console.WriteLine($"Enter the quantity for {name}:");
            int quantity = int.Parse(Console.ReadLine());

            shopping[i] = new Shopping(name, price, quantity);
        }

        for (int i = 0; i < product_count; i++)
        {
            cost += shopping[i].TotalPrice();
        }
        if (product_count > 2) cost = cost - ((cost * 10) / 100);

        Console.WriteLine(cost);
        Console.ReadKey();
    }
}