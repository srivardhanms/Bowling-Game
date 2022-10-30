using Bowling_Game;
using FluentAssertions;

namespace BowlingUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Roll_11PinsInOneRoll_InvalidPinsException()
        {
            BowlingGame bowlingGame = new();

            Action act = () => bowlingGame.Roll(11);

            act.Should().Throw<InvalidPinsException>().Where(e => e.Message.Equals("Exceeds maximum number of pins!"));
        }

        [Fact]
        public void Roll_11PinsInTwoRoll_InvalidPinsException()
        {
            BowlingGame bowlingGame = new();

            bowlingGame.Roll(1);

            Action act = () => bowlingGame.Roll(10);

            act.Should().Throw<InvalidPinsException>().Where(e => e.Message.Equals("Exceeds maximum number of pins!"));
        }

        [Fact]
        public void Score_MaxPoints_Success()
        {
            BowlingGame game = new();

            game.Roll(10);
            game.Roll(0); // Frame 1
            game.Roll(10);
            game.Roll(0); // Frame 2
            game.Roll(10);
            game.Roll(0); // Frame 3
            game.Roll(10);
            game.Roll(0); // Frame 4
            game.Roll(10);
            game.Roll(0); // Frame 5
            game.Roll(10);
            game.Roll(0); // Frame 6
            game.Roll(10);
            game.Roll(0); // Frame 7
            game.Roll(10);
            game.Roll(0); // Frame 8
            game.Roll(10);
            game.Roll(0); // Frame 9
            game.Roll(10);
            game.Roll(0); // Frame 10
            game.Roll(10);
            game.Roll(10);

            game.Score().Should().Be(300);
        }
    }
}