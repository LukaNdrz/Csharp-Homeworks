namespace lesson15HW
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int[] numbers = { 1, 2, 3, 4, 5 };

      List<string> names = new List<string>
        {
            "Mate", "Shalva", "Luka"
        };

      CollectionHelper.PrintReverse(numbers);

      Console.WriteLine(CollectionHelper.GetFirstElement(names));
      Console.WriteLine(CollectionHelper.GetLastElement(names));

      Console.WriteLine(CollectionHelper.ContainsElement(numbers, 3));

      Console.WriteLine(CollectionHelper.CountElements(numbers));

      Console.WriteLine(CollectionHelper.FindIndex(numbers, 4));
    }
  }
}
