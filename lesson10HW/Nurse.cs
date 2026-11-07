using System;
using System.Collections.Generic;
using System.Text;

namespace lesson10HW
{
  public class Nurse : Employee
  {
    private int _completedShifts;

    public string Department { get; set; }
    public int CompletedShifts => _completedShifts;

    public Nurse(string fullName, decimal salary, string department)
        : base(fullName, salary)
    {
      Department = department;
    }

    public void CompleteShift() => _completedShifts++;

    public override void ShowInfo()
    {
      base.ShowInfo();
      Console.WriteLine($"   პოზიცია: ექთანი | განყოფილება: {Department} | შესრულებული ცვლები: {CompletedShifts}");
    }

    public override void PerformDuty()
    {
      Console.WriteLine($"ექთანი {FullName} ({Department}) პაციენტს უწევს დახმარებას.");
    }

    public override decimal CalculateBonus() => CompletedShifts * 30m;
  }
}
