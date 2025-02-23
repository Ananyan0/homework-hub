public class Program
{
    public float ConvertFarenheit(ref int celsius1, out float farenheit)
    {
        return farenheit = (celsius1 * 9f) / 5f + 32;
    }

    public float ConvertKelvin(ref int celsius2, out float kelvin)
    {
        return kelvin = celsius2 + 273.15f;
    }

    public static void Main()
    {
        Program program = new Program();

        int celsius1 = int.Parse(Console.ReadLine());
        int celsius2 = int.Parse(Console.ReadLine());
        float farenheit;
        float kelvin;

        Console.WriteLine(program.ConvertFarenheit(ref celsius1, out farenheit));
        Console.WriteLine(program.ConvertKelvin(ref celsius2, out kelvin));
        Console.ReadKey();
    }
}