using System;
using System.Collections.Generic;
using System.Text;

namespace lesson15HW
{
  internal class CollectionHelper
  {
    public static void PrintReverse<T>(IEnumerable<T> collection)
    {
      List<T> list = new List<T>(collection);

      for (int i = list.Count - 1; i >= 0; i--)
      {
        Console.WriteLine(list[i]);
      }
    }

    //////////////////// GetFirstElement
    public static T GetFirstElement<T>(IEnumerable<T> collection)
    {
      foreach (T item in collection)
      {
        return item;
      }

      return default(T);
    }

   ///////////// GetLastElement
    public static T GetLastElement<T>(IEnumerable<T> collection)
    {
      T last = default(T);

      foreach (T item in collection)
      {
        last = item;
      }

      return last;
    }

    //////////////////// ContainsElement
    public static bool ContainsElement<T>(IEnumerable<T> collection, T value)
    {
      foreach (T item in collection)
      {
        if (EqualityComparer<T>.Default.Equals(item, value))
          return true;
      }

      return false;
    }

    ///////////////// CountElements
    public static int CountElements<T>(IEnumerable<T> collection)
    {
      int count = 0;

      foreach (T item in collection)
      {
        count++;
      }

      return count;
    }

    //////////// FindIndex
    public static int FindIndex<T>(IEnumerable<T> collection, T value)
    {
      int index = 0;

      foreach (T item in collection)
      {
        if (EqualityComparer<T>.Default.Equals(item, value))
          return index;

        index++;
      }

      return -1;
    }
  }
}
