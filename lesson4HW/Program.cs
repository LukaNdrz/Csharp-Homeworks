namespace lesson4HW
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.OutputEncoding = System.Text.Encoding.UTF8;
      //////////////////////////////   1 
      int[] numbers = [5, 10, 15, 20, 25];

      int sum = 0;
      for (int i = 0; i < numbers.Length; i++)
      {
        sum += numbers[i];
      }
      double average = (double)sum / numbers.Length;
      Console.WriteLine($"1) საშუალო არითმეტიკული: {average}");

      ////////////////////////////////// 2
      int[][] jagged =
      [
          [3, 8, 1, 6],
            [12, 4, 9],
            [7, 2, 15, 11, 5]
      ];

      Console.WriteLine("2) უდიდესი რიცხვები:");
      for (int i = 0; i < jagged.Length; i++)
      {
        int max = jagged[i][0];
        for (int j = 1; j < jagged[i].Length; j++)
        {
          if (jagged[i][j] > max)
          {
            max = jagged[i][j];
          }
        }
        Console.WriteLine($"   მასივი {i + 1}: {max}");
      }

      //////////////////////////////// 3
      int[][] jagged2 =
      [
          [2, 4, 6],
            [10, 20],
            [1, 3, 5, 7]
      ];

      int total = 0;
      int count = 0;
      for (int i = 0; i < jagged2.Length; i++)
      {
        for (int j = 0; j < jagged2[i].Length; j++)
        {
          total += jagged2[i][j];
          count++;
        }
      }
      double avgAll = (double)total / count;
      Console.WriteLine($"3) ყველა რიცხვის საშუალო: {avgAll}");
    }
  }
}
