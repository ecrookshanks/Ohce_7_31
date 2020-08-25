using System;
using System.Text;

namespace Ohce.Tests
{
  public class EchoProcessor
  {
    public static (string Reversal, bool isPalindrome) Echo(string toReverse)
    {
      int len = toReverse.Length;
      StringBuilder bldr = new StringBuilder(len);

      for (int i = len - 1; i >= 0; i--)
      {
        bldr.Append(toReverse[i]);
      }
      String result = bldr.ToString();
      bool isPal = toReverse.Equals(result);

      return (result, isPal);

    }
  }
}