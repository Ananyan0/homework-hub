public class Program
{
    public double Add(double a, double b)
    {
        return a + b;
    }
    public double Subtract(double a, double b)
    {
        return a - b;
    }
    public double Multiply(double a, double b)
    {
        return a * b;
    }
    public double Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("The number can't be divided to 0");
            return 0;
        }
        return a / b;
    }

    public static void Main()
    {
        Program program = new Program();
        bool exit = true;
        while (exit)
        {
            Console.WriteLine("Input the first number:");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Choose one of the following operations: (+, -, *, /) or X to exit");
            string operation = Console.ReadLine();
            if (operation == "X")
            {
                exit = false;
                Console.WriteLine("The programm closed");
                break;
            }
            Console.WriteLine("Input the second number:");
            double num2 = double.Parse(Console.ReadLine());


            double res = 0;

            switch (operation)
            {
                case "+":
                    res = program.Add(num1, num2);
                    Console.WriteLine(res);
                    break;
                case "-":
                    res = program.Subtract(num1, num2);
                    Console.WriteLine(res);
                    break;
                case "*":
                    res = program.Multiply(num1, num2);
                    Console.WriteLine(res);
                    break;
                case "/":
                    res = program.Divide(num1, num2);
                    Console.WriteLine(res);
                    break;
            }
        }
    }
}