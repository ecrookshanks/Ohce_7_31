using System;

namespace Ohce
{
  public class OhceGreeting
  {
    public const String MORNING = "Good Morning";
    public const String NIGHT = "Good Night";
    public const String AFTERNOON = "Good Afternoon";
    public const String DAY = "Good Day";

    public static string GetWelcome(DateTime date)
    {
      return GetWelcomString(date) + "!";
    }

    public static string GetWelcome(DateTime date, String userName)
    {
      string welcome = GetWelcomString(date);

      return welcome + " " + userName + "!";
    }



    private static string GetWelcomString(DateTime date)
    {
      int hour = date.Hour;

      if ((hour > 20) || (hour >= 0 && hour < 6))
      {
        return NIGHT;
      }
      else if (hour >= 6 && hour < 12)
      {
        return MORNING;
      }
      else if (hour >= 12 && hour <= 20)
      {
        return AFTERNOON;
      }
      else
      {
        return DAY;
      }
    }
  }
}