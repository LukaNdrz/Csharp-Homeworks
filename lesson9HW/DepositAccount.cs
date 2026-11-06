using System;

namespace lesson9HW
{
  public class DepositAccount : CardAccount
  {
    public DepositAccount(string accountNumber, decimal balance,
                          string cardNumber, DateTime cardExpiryDate)
        : base(accountNumber, balance, cardNumber, cardExpiryDate)
    {
    }
  }
}
