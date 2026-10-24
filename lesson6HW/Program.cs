namespace lesson6HW
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.OutputEncoding = System.Text.Encoding.UTF8;

      Task1();
      Console.WriteLine();
      Task2();
    }

    // ========================= 1 =========================
    static void Task1()
    {
      Console.WriteLine("===== Task 1 =====");

     
      bool IsValidScore(int score) => score >= 0 && score <= 100;

      int[] scores = new int[3];

      for (int i = 0; i < scores.Length; i++)
      {
        while (true)
        {
          Console.Write($"შეიყვანეთ მე-{i + 1} გამოცდის ქულა (0-100): ");

          if (int.TryParse(Console.ReadLine(), out int s) && IsValidScore(s))
          {
            scores[i] = s;
            break;
          }

          Console.WriteLine("არასწორი ქულა! შეიყვანეთ მთელი რიცხვი 0-დან 100-მდე.");
        }
      }

      double average = CalculateAverage(scores[0], scores[1], scores[2]);
      string grade = GetGrade(average);
      bool passed = IsPassed(average);

      Console.WriteLine($"საშუალო ქულა: {average:F2}");
      Console.WriteLine($"შეფასება: {grade}");
      Console.WriteLine($"სტატუსი: {(passed ? "ჩააბარა" : "ვერ ჩააბარა")}");
    }

    static double CalculateAverage(int a, int b, int c)
    {
      return (a + b + c) / 3.0;
    }

    static string GetGrade(double average)
    {
      if (average >= 91) return "A";
      if (average >= 81) return "B";
      if (average >= 71) return "C";
      if (average >= 61) return "D";
      if (average >= 51) return "E";
      if (average >= 41) return "FX";
      return "F";
    }

    static bool IsPassed(double average)
    {
      return average >= 51;
    }

    // ========================= 2 =========================
    static void Task2()
    {
      Console.WriteLine("===== Task 2 =====");


      bool IsPositive(long n) => n > 0;

      long number;
      while (true)
      {
        Console.Write("შეიყვანეთ მთელი რიცხვი: ");
        if (long.TryParse(Console.ReadLine(), out number))
        {
          break;
        }
        Console.WriteLine("ეს არ არის მთელი რიცხვი, სცადეთ თავიდან.");
      }

      Console.WriteLine($"ლუწია: {(IsEven(number) ? "დიახ" : "არა, კენტია")}");
      Console.WriteLine($"მარტივია: {(IsPrime(number) ? "დიახ" : "არა")}");
      Console.WriteLine($"ციფრების რაოდენობა: {CountDigits(number)}");
      Console.WriteLine($"შებრუნებული რიცხვი: {ReverseNumber(number)}");
      Console.WriteLine($"დადებითია: {(IsPositive(number) ? "დიახ" : "არა (ნულია ან უარყოფითი)")}");
    }

    static bool IsEven(long n)
    {
      return n % 2 == 0;
    }

    static bool IsPrime(long n)
    {
      if (n < 2) return false;

      for (long i = 2; i * i <= n; i++)
      {
        if (n % i == 0) return false;
      }
      return true;
    }

    static int CountDigits(long n)
    {
      if (n == 0) return 1;

      int count = 0;
      n = Math.Abs(n);
      while (n > 0)
      {
        count++;
        n /= 10;
      }
      return count;
    }

    static long ReverseNumber(long n)
    {
      if (n == 0) return 0;

      bool negative = n < 0;
      n = Math.Abs(n);

      long reversed = 0;
      while (n > 0)
      {
        reversed = reversed * 10 + n % 10;
        n /= 10;
      }
      return negative ? -reversed : reversed;
    }
  }
}
