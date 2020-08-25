using Ohce;
using Ohce.Tests;
using System;

namespace Ohce_7_31
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to the Ohce Kata!");

      DateTime dt = DateTime.Now;
      Console.WriteLine(OhceGreeting.GetWelcome(dt));

      String input = "";

      while (true)
      {
        Console.Write("Enter a word or \"Stop!\" to quit: ");

        input = Console.ReadLine();

        if (input.Equals("Stop!"))
        {
          break;
        }
        var result = EchoProcessor.Echo(input);
        Console.WriteLine("The reverse is: " + result.Reversal);
        if ( result.isPalindrome )
        {
          Console.WriteLine("Good Palindrome!");
        }

      }

      Console.WriteLine("Adios!");

    }
  }
}
