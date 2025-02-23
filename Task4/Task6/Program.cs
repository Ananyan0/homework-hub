public class Movie
{
    private int rating;

    public int Rating
    {
        get { return rating; }
        set
        {
            if (value >= 1 && value <= 5)
            {
                rating = value;
                Console.WriteLine(rating);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}

public class Program
{
    public static void Main()
    {
        Movie movie = new Movie();

        movie.Rating = int.Parse(Console.ReadLine());

        Console.ReadKey();
    }
}