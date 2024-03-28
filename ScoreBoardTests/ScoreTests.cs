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
            Score score = new Score(homeTeamScore, awayTeamScore);

            // Assert
            Assert.AreEqual(homeTeamScore, score.HomeTeamScore);
            Assert.AreEqual(awayTeamScore, score.AwayTeamScore);
        }
    }
}
