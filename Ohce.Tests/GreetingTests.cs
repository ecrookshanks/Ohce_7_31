using Moq; 
using System;
using Xunit;

namespace Ohce
{
  // This class tests the business logic for returning the correct greeting
  // based on time.
  public class GreetingTests
  {
    Mock<IDateTimeHelper> mockDateTimeHelper;
    
    // In MOQ, the consructor is the Setup method
    public GreetingTests()
    {
      mockDateTimeHelper = new Mock<IDateTimeHelper>();

    }


    [Fact]
    public void GreetingInMorningReturnsGoodMorning()
    {
      // arrange
      var morningDate = new DateTime(2020, 07, 15, 8, 0, 0); // 800 AM
      
      mockDateTimeHelper.Setup(d => d.GetDateTimeNow()).Returns(morningDate);

      // act
      String greeting = OhceGreeting.GetWelcome(morningDate);
      // assert

      Assert.Equal(OhceGreeting.MORNING + "!", greeting);

    }

    [Fact]
    public void GreetingInAfternoonReturnsGoodAfternoon()
    {
      var afternoonDate = new DateTime(2020, 07, 15, 13, 0, 0); // 100 PM
      mockDateTimeHelper.Setup(d => d.GetDateTimeNow()).Returns(afternoonDate);

      String greeting = OhceGreeting.GetWelcome(afternoonDate);
      // assert

      Assert.Equal(OhceGreeting.AFTERNOON + "!", greeting);
    }

    [Fact]
    public void GreetingInNightReturnsGoodNight()
    {
      var nightDate = new DateTime(2020, 07, 15, 23, 0, 0); // 1100 PM
      mockDateTimeHelper.Setup(d => d.GetDateTimeNow()).Returns(nightDate);

      String greeting = OhceGreeting.GetWelcome(nightDate);
      // assert

      Assert.Equal(OhceGreeting.NIGHT + "!", greeting);
    }

    [Fact]
    public void GreetingEdgeCases()
    {
      // midnight
      var midnght = new DateTime(2020, 07, 15, 0, 0, 0); 

      // 6AM
      var morning6AM = new DateTime(2020, 07, 15, 6, 0, 0); 

      // noon
      var noon = new DateTime(2020, 07, 15, 12, 0, 0); 

      // 8PM
      var afternoon8PM = new DateTime(2020, 07, 15, 20, 0, 0);

      String helloMidnight = OhceGreeting.GetWelcome(midnght);
      String helloMorning = OhceGreeting.GetWelcome(morning6AM);
      String helloNoon = OhceGreeting.GetWelcome(noon);
      String Hello8 = OhceGreeting.GetWelcome(afternoon8PM);

      Assert.Equal(OhceGreeting.NIGHT + "!", helloMidnight);
      Assert.Equal(OhceGreeting.MORNING + "!", helloMorning);
      Assert.Equal(OhceGreeting.AFTERNOON + "!", helloNoon);
      Assert.Equal(OhceGreeting.AFTERNOON + "!", Hello8);

    }

    [Fact]
    public void GreetingWithNameShouldReturnName()
    {
      // arrange
      var morningDate = new DateTime(2020, 07, 15, 8, 0, 0); // 800 AM
      String user = "Ted";

      mockDateTimeHelper.Setup(d => d.GetDateTimeNow()).Returns(morningDate);
      // act
      String greeting = OhceGreeting.GetWelcome(morningDate, user);
      // assert

      Assert.Equal("Good Morning Ted!", greeting);
    }

  }
}
