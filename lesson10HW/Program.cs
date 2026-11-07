namespace lesson10HW
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.OutputEncoding = System.Text.Encoding.UTF8;

      var nurse = new Nurse("ნინო ბერიძე", 1200, "ქირურგია");
      nurse.CompleteShift();
      nurse.CompleteShift();
      nurse.CompleteShift();

      var employees = new List<Employee>
            {
                new Doctor("გიორგი მაისურაძე", 3000, "კარდიოლოგი"),
                nurse,
                new Receptionist("მარიამ კაპანაძე", 900)
            };

      Console.WriteLine("===== მოვალეობების შესრულება =====");
      foreach (var emp in employees)
      {
        emp.PerformDuty();
        emp.PerformDuty();
      }

      Console.WriteLine("\n===== თანამშრომლების ინფორმაცია =====");
      foreach (var emp in employees)
      {
        emp.ShowInfo();
        Console.WriteLine($"   ბონუსი: {emp.CalculateBonus()} ლარი");
        Console.WriteLine();
      }

      Console.WriteLine("===== ხელფასის კონტროლირებადი შეცვლა =====");
      employees[0].ChangeSalary(3500);
      employees[0].ChangeSalary(-100);
    }
  }
}
