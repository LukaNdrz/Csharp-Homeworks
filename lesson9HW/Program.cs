using System;

namespace lesson9HW
{
  internal class Program
  {
    static void Main(string[] args)
    {
      CurrentAccount current = new CurrentAccount(
          "1234567890123456789012", 1000, 500);

      DepositAccount deposit = new DepositAccount(
          "1234567890123456789013", 2000,
          "1234567890123456", new DateTime(2028, 12, 31));

      CreditAccount credit = new CreditAccount(
          "1234567890123456789014", 3000,
          "9876543210123456", new DateTime(2029, 6, 30));

      Console.WriteLine("Current Account:");
      Console.WriteLine(current.AccountNumber);
      Console.WriteLine(current.Balance);
      Console.WriteLine(current.OverdraftLimit);

      Console.WriteLine("\nDeposit Account:");
      Console.WriteLine(deposit.AccountNumber);
      Console.WriteLine(deposit.Balance);
      Console.WriteLine(deposit.CardNumber);
      Console.WriteLine(deposit.CardExpiryDate);

      Console.WriteLine("\nCredit Account:");
      Console.WriteLine(credit.AccountNumber);
      Console.WriteLine(credit.Balance);
      Console.WriteLine(credit.CardNumber);
      Console.WriteLine(credit.CardExpiryDate);
    }
  }
}
