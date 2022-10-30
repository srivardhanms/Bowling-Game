using Bowling_Game;
using Xunit.Sdk;
using FluentAssertions;

namespace BowlingGameUnitTests
{
    [TestClass]
    public class BowlingGameUnitTests
    {
        [TestMethod]
        public void Roll_PinsMoreThan10_InvalidPinsException()
        {
            BowlingGame bowlingGame = new ();

            Action act = () => bowlingGame.Roll(11);

            act().Should().
        }
    }
}