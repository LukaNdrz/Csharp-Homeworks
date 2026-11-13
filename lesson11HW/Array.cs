using System;
using System.Collections.Generic;
using System.Text;

namespace lesson11HW
{
  internal class Array : IOutput2, ICalc2
  {
    private int[] data;

    public Array(params int[] values)
    {
      data = new int[values.Length];
      for (int i = 0; i < values.Length; i++)
        data[i] = values[i];
    }

    // ---------- IOutput2 ----------
    public void ShowEven()
    {
      Console.Write("Even: ");
      bool found = false;
      for (int i = 0; i < data.Length; i++)
      {
        if (data[i] % 2 == 0)
        {
          Console.Write(data[i] + " ");
          found = true;
        }
      }
      if (!found) Console.Write("(none)");
      Console.WriteLine();
    }

    public void ShowOdd()
    {
      Console.Write("Odd: ");
      bool found = false;
      for (int i = 0; i < data.Length; i++)
      {
        if (data[i] % 2 != 0)  
        {
          Console.Write(data[i] + " ");
          found = true;
        }
      }
      if (!found) Console.Write("(none)");
      Console.WriteLine();
    }

    // ---------- ICalc2 ----------
    public int CountDistinct()
    {
      int count = 0;
      for (int i = 0; i < data.Length; i++)
      {
        bool seenBefore = false;
        for (int j = 0; j < i; j++)
        {
          if (data[j] == data[i])
          {
            seenBefore = true;
            break;
          }
        }
        if (!seenBefore) count++;
      }
      return count;
    }

    public int EqualToValue(int valueToCompare)
    {
      int count = 0;
      for (int i = 0; i < data.Length; i++)
        if (data[i] == valueToCompare)
          count++;
      return count;
    }
  }
}
