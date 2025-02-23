public class Employee
{
    public string Name;
    public string Position;
    public float SalaryPerHour;
    public float HoursWorked;

    public Employee(string Name, string Position, float SalaryPerHour, float HoursWorked)
    {
        this.Name = Name;
        this.Position = Position;
        this.SalaryPerHour = SalaryPerHour;
        this.HoursWorked = HoursWorked;
    }

    public float CalculateSalary()
    {
        return SalaryPerHour * HoursWorked;
    }
}

public class Program
{
    public static void Main()
    {
        int employee_size = 2;
        Employee[] employee = new Employee[employee_size];

        for (int i = 0; i < employee_size; i++)
        {
            Console.WriteLine($"Enter your name:");
            string Name = Console.ReadLine();
            Console.WriteLine($"Enter your position:");
            string Position = Console.ReadLine();
            Console.WriteLine($"Enter your salary per hour:");
            float SalaryPerHour = float.Parse(Console.ReadLine());
            Console.WriteLine($"How many hours you are wroking per day:");
            float HoursWorked = float.Parse(Console.ReadLine());

            employee[i] = new Employee(Name, Position, SalaryPerHour, HoursWorked);
        }

        for (int i = 0; i < employee_size; i++)
        {
            double salary = employee[i].CalculateSalary();
            if (employee[i].HoursWorked > 40)
            {
                salary *= 1.5;
            }
            Console.WriteLine(employee[i].Name + " Your salary is: " + salary);
        }

        Console.ReadKey();
    }
}