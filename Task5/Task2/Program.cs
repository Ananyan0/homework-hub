
public class Program
{
 public void SwapNumbers(ref int a, ref int b){
      int temp = a;
      a = b;
      b = temp;
 }
 
 public static void Main()
 {
      Program program = new Program();
  
      Console.WriteLine("Input first number:");
      int a = int.Parse(Console.ReadLine());
      Console.WriteLine("Input second number:");
      int b = int.Parse(Console.ReadLine());
  
      program.SwapNumbers(ref a, ref b);
  
      Console.WriteLine($"number1 = {a} number2 = {b}");

        Console.ReadKey();
 }
}