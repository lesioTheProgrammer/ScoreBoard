using FluentAssertions;
using ScoreBoard;

namespace ScoreBoardTests
{
    [TestClass]
    public class ScoreTests
    {
        [TestMethod]
        public void Should_Initialize_Score()
        {
            // Arrange
            var homeTeamScore = 2;
            var awayTeamScore = 1;

            // Act
            var score = new Score(homeTeamScore, awayTeamScore);

            // Assert
            Assert.AreEqual(homeTeamScore, score.HomeTeamScore);
            Assert.AreEqual(awayTeamScore, score.AwayTeamScore);
        }

        [TestMethod]
        public void Should_Throw_Exception()
        {
            // Arrange
            var homeTeamScore = 2;
            var awayTeamScore = -1;

            // Act
            var act = () => new Score(homeTeamScore, awayTeamScore);

            // Assert
            act.Should().Throw<ArgumentException>();
        }
    }
}
