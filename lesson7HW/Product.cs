using System;

namespace lesson7HW
{
  internal class Product
  {

    public int Id { get; set; }
    public string Name { get; set; } = "";
    public double Price { get; set; }
    public bool Nuts { get; set; }
    public string Image { get; set; } = "";
    public bool Vegeterian { get; set; }
    public int Spiciness { get; set; }
    public string Category { get; set; } = "";


    public bool IsSpicy()
    {
      return Spiciness > 0;
    }

    public void ApplyDiscount(double percent)
    {
      Price = Price - Price * percent / 100;
    }


    public bool IsInCategory(string category)
    {
      return Category == category;
    }


    public void PrintInfo()
    {
      Console.WriteLine($"ID: {Id}");
      Console.WriteLine($"სახელი: {Name}");
      Console.WriteLine($"ფასი: {Price}");
      Console.WriteLine($"კატეგორია: {Category}");
      Console.WriteLine($"თხილეული: {Nuts}");
      Console.WriteLine($"ვეგეტარიანული: {Vegeterian}");
      Console.WriteLine($"სიცხარე: {Spiciness}");
      Console.WriteLine($"სურათი: {Image}");
    }
  }
}
