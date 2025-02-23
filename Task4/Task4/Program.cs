public class WeatherReport
{
    public double temp;
    public int humidity;
    public string weatherCondition;

    public WeatherReport(double temp, int humidity, string weatherCondition)
    {
        this.temp = temp;
        this.humidity = humidity;
        this.weatherCondition = weatherCondition;
    }

    public void DisplayReport()
    {
        Console.WriteLine($"The temperature is: {temp}C, the humidity is: %{humidity}, condition is: {weatherCondition}");
    }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        WeatherReport[] report = new WeatherReport[3];

        report[0] = new WeatherReport(10, 50, "Sun");
        report[1] = new WeatherReport(2, 80, "Rain");
        report[2] = new WeatherReport(38, 10, "Clear");

        foreach (var weather in report)
        {
            weather.DisplayReport();
        }
        Console.ReadKey();
    }
}