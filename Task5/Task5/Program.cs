public class Program
{
    public void area_perimeter(ref float radius, out float area, out float perimeter)
    {
        const float p = 3.14f;
        area = p * (radius * radius);
        perimeter = 2 * p * radius;
    }


    public static void Main()
    {
        Program program = new Program();

        float radius = int.Parse(Console.ReadLine());
        float area, perimeter;

        program.area_perimeter(ref radius, out area, out perimeter);
        Console.WriteLine($"Area: {area} \nPerimeter: {perimeter}");

        Console.ReadKey();
    }
}