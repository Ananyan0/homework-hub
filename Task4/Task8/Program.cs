public class Product
{
    public string name;
    public double price;
    public int quantity;

    public Product(string name, double price, int quantity)
    {
        this.name = name;
        this.price = price;
        this.quantity = quantity;
    }

    public void DisplayProduct()
    {
        Console.WriteLine($"Product's name is: {name} \nprice: {price} \nquantity: {quantity}\n");
    }
}

public class Program
{
    public static void Main()
    {
        Product[] product = new Product[3];

        product[0] = new Product("Banana", 750, 4);
        product[1] = new Product("Apple", 300, 10);
        product[2] = new Product("Orange", 1200, 7);

        foreach (var collect in product)
        {
            collect.DisplayProduct();
        }
        Console.ReadKey();
    }
}