namespace firstC_homework
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Enter x: ");
      double x = double.Parse(Console.ReadLine()!);

      Console.Write("Enter y: ");
      double y = double.Parse(Console.ReadLine()!);

      Console.Write("Enter operation ( +, -, *, /, %, ^ ): ");
      string action = Console.ReadLine()!;

      switch (action)
      {
        case "+":
          Console.WriteLine($"Result: {x} + {y} = {x + y}");
          break;
        case "-":
          Console.WriteLine($"Result: {x} - {y} = {x - y}");
          break;
        case "*":
          Console.WriteLine($"Result: {x} * {y} = {x * y}");
          break;
        case "/":
          if (y == 0)
          {
            Console.WriteLine("ERROR: cannot divide by zero");
          }
          else
          {
            Console.WriteLine($"Result: {x} / {y} = {x / y}");
          }
          break;
        case "%":
          if (y == 0)
          {
            Console.WriteLine("ERROR: cannot divide by zero");
          }
          else
          {
            Console.WriteLine($"Result: {x} % {y} = {x % y}");
          }
          break;
        case "^":
          Console.WriteLine($"Result: {x} ^ {y} = {Math.Pow(x, y)}");
          break;
        default:
          Console.WriteLine("ERROR: invalid operation");
          break;
      }
    }
  }
}
