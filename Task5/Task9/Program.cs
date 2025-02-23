public class Program
{
    public void SecondToTime(out int hours, out int minutes, out int seconds, ref int total_sec)
    {
        hours = total_sec / 3600;
        int temp = total_sec % 3600;
        minutes = temp / 60;
        seconds = total_sec % 60;
    }

    public static void Main()
    {
        Program program = new Program();

        int total_sec = int.Parse(Console.ReadLine());
        int hours, minutes, seconds;
        if (total_sec > 0)
        {
            program.SecondToTime(out hours, out minutes, out seconds, ref total_sec);


            Console.WriteLine($"{total_sec} is: hours: {hours} minutes: {minutes} seconds: {seconds}");

            Console.ReadKey();
        }
    }
}