using System;

namespace lesson9HW
{
  public class CurrentAccount : BankAccount
  {
    private decimal overdraftLimit;

    public decimal OverdraftLimit
    {
      get { return overdraftLimit; }
      set
      {
        if (value < 0)
        {
          throw new ArgumentException(
              "Overdraft limit cannot be negative!");
        }

        overdraftLimit = value;
      }
    }

    public CurrentAccount(string accountNumber, decimal balance,
                          decimal overdraftLimit)
        : base(accountNumber, balance)
    {
      OverdraftLimit = overdraftLimit;
    }
  }
}
