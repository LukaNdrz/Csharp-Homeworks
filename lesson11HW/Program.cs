namespace lesson11HW
{
  internal class Program
  {
    static void Main(string[] args)
    {
     
      Array arr = new Array(1, 2, 2, 3, 4, 4, 4, 5, -3, -6, 0);


      IOutput2 output = arr;
      output.ShowEven();
      output.ShowOdd();

    
      ICalc2 calc = arr;
      Console.WriteLine("Distinct: " + calc.CountDistinct());   
      Console.WriteLine("Equal to 4: " + calc.EqualToValue(4));    
      Console.WriteLine("Equal to 2: " + calc.EqualToValue(2));   
      Console.WriteLine("Equal to 99: " + calc.EqualToValue(99)); 

 
      Console.WriteLine("\n--- Only odd ---");
      Array onlyOdd = new Array(1, 3, 5, 5);
      onlyOdd.ShowEven();
      onlyOdd.ShowOdd();
      Console.WriteLine("Distinct: " + onlyOdd.CountDistinct());  

   
      Console.WriteLine("\n--- Empty array ---");
      Array empty = new Array();
      empty.ShowEven();
      empty.ShowOdd();
      Console.WriteLine("Distinct: " + empty.CountDistinct());    

      Console.ReadKey();
    }
  }
}
