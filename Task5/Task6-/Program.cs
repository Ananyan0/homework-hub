public class Program
{
    public void SumNumbers(params int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < 5; i++)
        {
            sum += numbers[i];
        }
        Console.WriteLine(sum);
    }


    public static void Main()
    {
        Program program = new Program();
        int[] arr = new int[5];

        for (int i = 0; i < 5; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        program.SumNumbers(arr);

        Console.ReadKey();
    }
}