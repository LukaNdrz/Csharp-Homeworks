using System;
using System.Collections.Generic;
using System.Text;

namespace lesson10HW
{
  public abstract class Employee
  {
    private string _fullName;
    private decimal _salary;

    protected Employee(string fullName, decimal salary)
    {
      FullName = fullName;
      Salary = salary;
    }

    public string FullName
    {
      get => _fullName;
      set
      {
        if (string.IsNullOrWhiteSpace(value))
          throw new ArgumentException("სახელი და გვარი ვერ იქნება ცარიელი.");
        _fullName = value.Trim();
      }
    }

    public decimal Salary
    {
      get => _salary;
      private set
      {
        if (value < 0)
          throw new ArgumentException("ხელფასი არ შეიძლება იყოს უარყოფითი.");
        _salary = value;
      }
    }

    public void ChangeSalary(decimal newSalary)
    {
      if (newSalary < 0)
      {
        Console.WriteLine("შეცდომა: ხელფასი არ შეიძლება იყოს უარყოფითი. ცვლილება არ შესრულდა.");
        return;
      }
      Salary = newSalary;
      Console.WriteLine($"{FullName}-ის ახალი ხელფასია: {Salary} ლარი.");
    }

    public virtual void ShowInfo()
    {
      Console.WriteLine($"თანამშრომელი: {FullName} | ხელფასი: {Salary} ლარი");
    }

    public abstract void PerformDuty();

    public abstract decimal CalculateBonus();
  }
}
