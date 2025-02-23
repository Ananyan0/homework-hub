public class Car
{
    public string Model;
    public int Year;
    public bool IsRented = false;

    public Car(string Model, int Year)
    {
        this.Model = Model;
        this.Year = Year;
        this.IsRented = false;
    }
    public void RentCar()
    {
        if (IsRented)
        {
            Console.WriteLine($"This car already has owner: {Model} {Year}");
        }
        else
        {
            IsRented = true;
            Console.WriteLine($"You have rented the {Model} ({Year}).");
        }
    }

    public void ReturnCar()
    {
        if (IsRented)
        {
            IsRented = false;
            Console.WriteLine($"You have returned the {Model} ({Year})");
        }
        else
        {
            Console.WriteLine($"This car was not rented: {Model} ({Year})");
        }
    }


    public void DisplayInfo()
    {
        Console.WriteLine($"The model of the car is: {Model}");
        Console.WriteLine($"Year: {Year}");
    }

}

public class Program
{
    public static void Main()
    {
        int size = 3;
        Car[] car = new Car[size];

        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("Enter car's model:");
            string model = Console.ReadLine();
            Console.WriteLine("Enter the year:");
            int year = int.Parse(Console.ReadLine());

            car[i] = new Car(model, year);
        }
        for (int i = 0; i < size; i++)
        {
            car[i].DisplayInfo();
        }

        bool exit = true;
        while (exit)
        {
            Console.WriteLine("1. if you want to rent a car::: 2. for returning :: 0 to exit");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.Write("Enter the number of the car you want to rent: ");
                    int choice = int.Parse(Console.ReadLine()) - 1;
                    if (choice >= 0 && choice < car.Length)
                    {
                        car[choice].RentCar();
                    }
                    else { Console.WriteLine("Invalid choice"); }
                    break;
                case 2:
                    Console.Write("Enter the number of the car which you want to return: ");
                    choice = int.Parse(Console.ReadLine()) - 1;
                    if (choice >= 0 && choice < car.Length)
                    {
                        car[choice].ReturnCar();
                    }
                    else { Console.WriteLine("Invalid choice"); }
                    break;
                case 0:
                    exit = false;
                    break;
            }
        }










    }
}