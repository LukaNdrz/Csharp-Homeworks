using System.Text;

namespace lesson8HW
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.OutputEncoding = Encoding.UTF8;

      try
      {

        Student student = new Student();

        student.FirstName = "ლუკა";
        student.LastName = "კაპანაძე";
        student.Age = 20;
        student.Email = "luka@example.com";
        student.PersonalId = "01234567890";
        student.Phone = "555123456";
        student.Gpa = 87.5;
        student.Course = 2;
        student.Faculty = "ინფორმატიკა";
        student.IsActive = true;

        student.PrintInfo();
      }
      catch (Exception ex)
      {
        Console.WriteLine("შეცდომა: " + ex.Message);
      }
    }
  }
}
