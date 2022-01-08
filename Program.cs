using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{  
  public static string PigIt(string str)
  {
    public static bool Scramble(string str1, string str2)
    {
      char[] arr = str2.ToCharArray();
      List<Char> target = str1.ToCharArray().ToList();

      for (int i = 0; i < arr.Length; i++)
      {
        if (!target.Contains(arr[i])) return false;
        target.Remove(arr[i]);
      }
      return true;
    }
  }
}