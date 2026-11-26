namespace lesson14HW
{
  internal class Program
  {


    static void Main(string[] args)
    {
      List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

      var evenNumbers = MyCollection.Where(numbers, x => x % 2 == 0);

      var firstEven = MyCollection.FirstOrDefault(numbers, x => x % 2 == 0);

      bool hasEven = MyCollection.Any(numbers, x => x % 2 == 0);

      bool allPositive = MyCollection.All(numbers, x => x > 0);

      int evenCount = MyCollection.Count(numbers, x => x % 2 == 0);

      Console.WriteLine(string.Join(", ", evenNumbers));
      Console.WriteLine(firstEven);
      Console.WriteLine(hasEven);
      Console.WriteLine(allPositive);
      Console.WriteLine(evenCount);
    }
  }
}
  

