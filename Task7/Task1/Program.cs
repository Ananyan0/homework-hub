public class WaterTank
{
    private double Capacity { get; set; }
    private double CurrentLevel { get; set; }

    public WaterTank(double capacity, double currentLevel)
    {
        Capacity = capacity;
        CurrentLevel = currentLevel;
    }

    public override string ToString()
    {
        return ($"Tank_capacity: {Capacity} Tank_level: {CurrentLevel}");
    }

    public static WaterTank operator +(WaterTank capacity1, WaterTank capacity2)
    {
        double newCurrentLevel = capacity1.CurrentLevel + capacity2.CurrentLevel;
        if (newCurrentLevel > capacity1.Capacity)
        {
            return null;
        }
        return new WaterTank(capacity1.Capacity, newCurrentLevel);
    }

    public static WaterTank operator -(WaterTank capacity, double consume)
    {
        if (capacity.CurrentLevel < consume) return null;

        return new WaterTank(capacity.Capacity, capacity.CurrentLevel - consume);
    }
}

public class Program
{
    public static void Main()
    {
        WaterTank capacity1 = new WaterTank(100, 10);
        WaterTank capacity2 = new WaterTank(100, 30);

        Console.WriteLine(capacity1.ToString());
        Console.WriteLine(capacity2.ToString());
        WaterTank add_water = capacity1 + capacity2;  

        Console.WriteLine(add_water); 

        WaterTank consume = capacity2 - 11;
        Console.WriteLine(consume);

        Console.ReadKey();
    }
}