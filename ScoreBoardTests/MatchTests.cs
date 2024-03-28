using ScoreBoard;

namespace ScoreBoardTests
{
    [TestClass]
    public class MatchTests
    {
        [TestMethod]
        public void Should_Start_The_Match()
        {
            // Arrange
            var homeTeam = "HomeTeam";
            var awayTeam = "AwayTeam";

            // Act
            Match match = new Match(homeTeam, awayTeam);

            // Assert
            Assert.AreEqual(homeTeam, match.HomeTeam);
            Assert.AreEqual(awayTeam, match.AwayTeam);
        }

    }
}