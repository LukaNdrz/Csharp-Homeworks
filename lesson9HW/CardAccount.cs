using System;

namespace lesson9HW
{
  public class CardAccount : BankAccount
  {
    private string cardNumber;

    public string CardNumber
    {
      get { return cardNumber; }
      set
      {
        if (string.IsNullOrEmpty(value) || value.Length > 16)
        {
          throw new ArgumentException(
              "Card number must contain maximum 16 digits!");
        }

        foreach (char digit in value)
        {
          if (!char.IsDigit(digit))
          {
            throw new ArgumentException(
                "Card number must contain only digits!");
          }
        }

        cardNumber = value;
      }
    }

    public DateTime CardExpiryDate { get; set; }

    public CardAccount(string accountNumber, decimal balance,
                       string cardNumber, DateTime cardExpiryDate)
        : base(accountNumber, balance)
    {
      CardNumber = cardNumber;
      CardExpiryDate = cardExpiryDate;
    }
  }
}
