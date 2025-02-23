public class Program
{
    public int FindMaximum(ref int max, int size, params int[] numbers)
    {
        max = numbers[0];

        for (int i = 1; i < size; i++)
        {
            if (max < numbers[i])
            {
                max = numbers[i];
            }
        }
        return max;
    }

    public static void Main()
    {
        Program program = new Program();
        int max = 0;
        Console.WriteLine("How many numbers you want to input?:");
        int size = int.Parse(Console.ReadLine());
        if (size > 0)
        {
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(program.FindMaximum(ref max, size, arr));
        }
        else
        {
            Console.WriteLine("Numbers need to be more then 0");

        }

        Console.ReadKey();

    }
}