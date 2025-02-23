public class Program
{
    public static void Main()
    {
        for (int i = 1; i <= 7; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
        Console.ReadKey();

    }
}