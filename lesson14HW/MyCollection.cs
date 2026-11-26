using System;
using System.Collections.Generic;
using System.Text;

namespace lesson14HW
{
  internal class MyCollection
  {
    public static List<T> Where<T>(List<T> collection, Predicate<T> condition)
    {
      List<T> result = new List<T>();

      foreach (T item in collection)
      {
        if (condition(item))
          result.Add(item);
      }

      return result;
    }

    ///////////// FirstOrDefault
    public static T FirstOrDefault<T>(List<T> collection, Predicate<T> condition)
    {
      foreach (T item in collection)
      {
        if (condition(item))
          return item;
      }

      return default(T);
    }

    ////////////////////// Any
    public static bool Any<T>(List<T> collection, Predicate<T> condition)
    {
      foreach (T item in collection)
      {
        if (condition(item))
          return true;
      }

      return false;
    }

    /////////////////// All
    public static bool All<T>(List<T> collection, Predicate<T> condition)
    {
      foreach (T item in collection)
      {
        if (!condition(item))
          return false;
      }

      return true;
    }

    ///////////////////////////// Count
    public static int Count<T>(List<T> collection, Predicate<T> condition)
    {
      int count = 0;

      foreach (T item in collection)
      {
        if (condition(item))
          count++;
      }

      return count;
    }
  }
}
