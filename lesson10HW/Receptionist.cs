using System;
using System.Collections.Generic;
using System.Text;

namespace lesson10HW
{
  public class Receptionist : Employee
  {
    private int _registeredPatients;

    public int RegisteredPatients => _registeredPatients;

    public Receptionist(string fullName, decimal salary)
        : base(fullName, salary)
    {
    }

    public override void ShowInfo()
    {
      base.ShowInfo();
      Console.WriteLine($"   პოზიცია: რეგისტრატორი | დარეგისტრირებული პაციენტები: {RegisteredPatients}");
    }

    public override void PerformDuty()
    {
      _registeredPatients++;
      Console.WriteLine($"რეგისტრატორი {FullName} არეგისტრირებს პაციენტს.");
    }


    public override decimal CalculateBonus() => RegisteredPatients * 5m;
  }
}
