public class Program
{
    public static void Main()
    {

        int num = int.Parse(Console.ReadLine());
        int count = 0;

        if (num <= 1)
        {
            Console.WriteLine("Input the number which is greater then 1");
            return;
        }

        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0) count++;
        }
        if (count != 2)
        {
            Console.WriteLine("The number is not prime;");
        }
        else
        {
            Console.WriteLine("The number is prime");
        }
        Console.ReadKey();
    }
}