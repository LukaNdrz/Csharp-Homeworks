namespace lesson7HW
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.OutputEncoding = System.Text.Encoding.UTF8;


      Product pizza = new Product();
      pizza.Id = 1;
      pizza.Name = "Margherita";
      pizza.Price = 20;
      pizza.Nuts = false;
      pizza.Image = "pizza.jpg";
      pizza.Vegeterian = true;
      pizza.Spiciness = 0;
      pizza.Category = "Pizza";


      Product wings = new Product();
      wings.Id = 2;
      wings.Name = "Spicy Wings";
      wings.Price = 14;
      wings.Nuts = false;
      wings.Image = "wings.jpg";
      wings.Vegeterian = false;
      wings.Spiciness = 4;
      wings.Category = "Chicken";


      pizza.PrintInfo();
      Console.WriteLine();

      Console.WriteLine($"Pizza ცხარეა: {pizza.IsSpicy()}");
      Console.WriteLine($"Wings ცხარეა: {wings.IsSpicy()}");

      pizza.ApplyDiscount(10);
      Console.WriteLine($"Pizza ფასი 10% ფასდაკლების შემდეგ: {pizza.Price}");

      Console.WriteLine($"Wings არის Chicken კატეგორიაში: {wings.IsInCategory("Chicken")}");
    }
  }
}
