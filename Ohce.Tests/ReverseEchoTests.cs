using System;
using System.Collections.Generic;
using System.Text;

using Xunit;

namespace Ohce.Tests
{
  public class ReverseEchoTests
  {
    [Fact]
    public void SimpleStringReversal()
    {
      String toReverse = "echo";

      var result = EchoProcessor.Echo(toReverse);

      Assert.Equal("ohce", result.Reversal);

    }

    [Fact]
    public void StringReverseAndIdentifyPalindrome()
    {
      String simplePal = "oto";

      var result = EchoProcessor.Echo(simplePal);

      Assert.Equal("oto", result.Reversal);
      Assert.True(result.isPalindrome);
    }
  }
}
