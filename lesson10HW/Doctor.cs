using System;
using System.Collections.Generic;
using System.Text;

namespace lesson10HW
{
  public class Doctor : Employee
  {
    private int _examinedPatients;

    public string Specialization { get; set; }
    public int ExaminedPatients => _examinedPatients;

    public Doctor(string fullName, decimal salary, string specialization)
        : base(fullName, salary)
    {
      Specialization = specialization;
    }

    public override void ShowInfo()
    {
      base.ShowInfo();
      Console.WriteLine($"   პოზიცია: ექიმი | სპეციალიზაცია: {Specialization} | გასინჯული პაციენტები: {ExaminedPatients}");
    }

    public override void PerformDuty()
    {
      _examinedPatients++;
      Console.WriteLine($"ექიმი {FullName} ({Specialization}) ათვალიერებს პაციენტს.");
    }


    public override decimal CalculateBonus() => ExaminedPatients * 20m;
  }
}
