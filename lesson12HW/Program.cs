namespace lesson12HW
{
  internal class Program
  {
    static void Main(string[] args)
    {
    //////////////////////// moswavleebi

      Student s1 = new Student("Luka", "Nadiradze", 16, 95);
      Student s2 = new Student("Luka", "Kapanadze", 17, 85);
      Student s3 = new Student("Shalva", "Modebadze", 16, 70);
      Student s4 = new Student("Mate", "Bejanishvili", 17, 90);
      Student s5 = new Student("Benjamin", "Netanyahu", 16, 80);

      Student[] students = { s1, s2, s3, s4, s2 };

    ////////////////////////////

      for (int i = 0; i < students.Length - 1; i++)
      {
        for (int j = 0; j < students.Length - 1 - i; j++)
        {
          if (students[j].Grade.CompareTo(students[j + 1].Grade) > 0)
          {
            Student temp = students[j];
            students[j] = students[j + 1];
            students[j + 1] = temp;
          }
        }
      }

      Console.WriteLine("STUDENTS:");

      foreach (Student s in students)
      {
        Console.WriteLine($"{s.Name} {s.Surname} - {s.Grade}");
      }



      Console.WriteLine("Duplicate students:");

      for (int i = 0; i < students.Length; i++)
      {
        for (int j = i + 1; j < students.Length; j++)
        {
          if (ReferenceEquals(students[i], students[j]))
          {
            Console.WriteLine(students[i].Name + " " + students[i].Surname);
            break;
          }
        }
      }


 //////////////////////////// filmebi

      Movie m1 = new Movie("Interstellar", 2014);
      Movie m2 = new Movie("MarrowBone", 2017);
      Movie m3 = new Movie("The Matrix", 1999);
      Movie m4 = new Movie("SuperNatural", 2005);
      Movie m5 = new Movie("Dead Poets Society", 1989);

      Movie[] movies = { m1, m2, m3, m4, m2 };

//////////////////////////////////////////

      for (int i = 0; i < movies.Length - 1; i++)
      {
        for (int j = 0; j < movies.Length - 1 - i; j++)
        {
          if (movies[j].Year.CompareTo(movies[j + 1].Year) > 0)
          {
            Movie temp = movies[j];
            movies[j] = movies[j + 1];
            movies[j + 1] = temp;
          }
        }
      }

      Console.WriteLine("\nMOVIES:");

      foreach (Movie m in movies)
      {
        Console.WriteLine($"{m.Title} - {m.Year}");
      }



      Console.WriteLine("Duplicate movies:");

      for (int i = 0; i < movies.Length; i++)
      {
        for (int j = i + 1; j < movies.Length; j++)
        {
          if (ReferenceEquals(movies[i], movies[j]))
          {
            Console.WriteLine(movies[i].Title);
            break;
          }
        }
      }
    }
  }
}

