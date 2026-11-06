using System;

namespace lesson9HW
{
  public class BankAccount
  {
    private string accountNumber;
    private decimal balance;

    public string AccountNumber
    {
      get { return accountNumber; }
      set
      {
        if (value == null || value.Length != 22)
        {
          throw new ArgumentException(
              "Account number must contain exactly 22 characters!");
        }

        accountNumber = value;
      }
    }

    public decimal Balance
    {
      get { return balance; }
      set
      {
        if (value < 0)
        {
          throw new ArgumentException(
              "Balance cannot be negative!");
        }

        balance = value;
      }
    }

    public BankAccount(string accountNumber, decimal balance)
    {
      AccountNumber = accountNumber;
      Balance = balance;
    }
  }
}
