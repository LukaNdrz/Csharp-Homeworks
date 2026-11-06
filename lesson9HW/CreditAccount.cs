using System;

namespace lesson9HW
{
  public class CreditAccount : CardAccount
  {
    public CreditAccount(string accountNumber, decimal balance,
                         string cardNumber, DateTime cardExpiryDate)
        : base(accountNumber, balance, cardNumber, cardExpiryDate)
    {
    }
  }
}
