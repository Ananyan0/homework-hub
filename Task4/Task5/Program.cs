
public class SmartWatch
{
    public string ownerName;
    public int stepCount;

    public SmartWatch(string ownerName)
    {
        this.ownerName = ownerName;
        this.stepCount = 0;
    }

    public void AddSteps(int steps)
    {
        stepCount += steps;

    }

    public void ShowSteps()
    {
        Console.WriteLine($"{ownerName} you have {stepCount} steps");
    }

}

public class Program
{
    public static void Main()
    {
        SmartWatch mySmart = new SmartWatch("Karen");

        mySmart.AddSteps(int.Parse(Console.ReadLine()));
        mySmart.AddSteps(500);

        mySmart.ShowSteps();

    }
}