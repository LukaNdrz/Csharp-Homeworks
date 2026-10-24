namespace GuessingGame
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Random random = new Random();
      int secret = random.Next(1, 101); 
      int attempts = 0;
      int maxAttempts = 7;
      bool won = false;

      Console.WriteLine("I picked a number from 1 to 100. You have 7 attempts.");

      while (attempts < maxAttempts)
      {
        Console.Write($"Attempt {attempts + 1}/{maxAttempts}. Your guess: ");
        string? input = Console.ReadLine();

        int guess;
        if (!int.TryParse(input, out guess))
        {
          Console.WriteLine("ERROR: please enter a valid number.");
          continue; 
        }

        attempts++;

        if (guess < secret)
        {
          Console.WriteLine("Too low!");
        }
        else if (guess > secret)
        {
          Console.WriteLine("Too high!");
        }
        else
        {
          Console.WriteLine("Correct!");
          won = true;
          break;
        }
      }

      if (won)
      {
        Console.WriteLine($"You guessed it in {attempts} attempts.");
      }
      else
      {
        Console.WriteLine($"Game over! The number was {secret}.");
      }

      ////////////////////////////////////////////////////////////

      int count;

      
      while (true)
      {
        Console.Write("Enter number of students: ");
        if (int.TryParse(Console.ReadLine(), out count) && count > 0)
        {
          break;
        }
        Console.WriteLine("ERROR: enter a positive whole number.");
      }

      int passed = 0;
      int failed = 0;

      for (int i = 1; i <= count; i++)
      {
        int score;

        
        while (true)
        {
          Console.Write($"Enter score for student {i} (0-100): ");
          if (int.TryParse(Console.ReadLine(), out score) && score >= 0 && score <= 100)
          {
            break;
          }
          Console.WriteLine("ERROR: score must be a number from 0 to 100.");
        }

        string grade;
        if (score >= 90)
        {
          grade = "A";
        }
        else if (score >= 80)
        {
          grade = "B";
        }
        else if (score >= 70)
        {
          grade = "C";
        }
        else if (score >= 60)
        {
          grade = "D";
        }
        else
        {
          grade = "F";
        }

        Console.WriteLine($"Student {i}: score {score}, grade {grade}");

        if (grade == "F")
        {
          failed++;
        }
        else
        {
          passed++;
        }
      }

      Console.WriteLine($"Passed: {passed}");
      Console.WriteLine($"Failed: {failed}");

    }
  }
}
