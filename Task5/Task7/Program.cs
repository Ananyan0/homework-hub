public class Program
{
    public void QuadraticEquation(ref double a, ref double b, ref double c, out double x1, out double x2)
    {
        double discriminant = b * b - 4 * a * c;

        if (discriminant > 0)
        {
            x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
        }
        else if (discriminant == 0)
        {
            x1 = x2 = -b / (2 * a);
        }
        else
        {
            x1 = -b / (2 * a);
            x2 = Math.Sqrt(-discriminant) / (2 * a);
        }

    }


    public static void Main()
    {
        Program program = new Program();

        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double x1, x2;
        program.QuadraticEquation(ref a, ref b, ref c, out x1, out x2);
        Console.WriteLine($"X1: {x1} X2: {x2}");

        Console.ReadKey();
    }
}