using ScoreBoard;

namespace ScoreBoardTests
{
    [TestClass]
    public class MatchTests
    {
        [TestMethod]
        public void Should_Return_Match_With_Default_Score()
        {
            // Arrange
            var homeTeam = "HomeTeam";
            var awayTeam = "AwayTeam";

            // Act
            Match match = new Match(homeTeam, awayTeam);

            // Assert
            Assert.AreEqual(homeTeam, match.HomeTeam);
            Assert.AreEqual(awayTeam, match.AwayTeam);
            Assert.AreEqual(0, match.GetScore().HomeTeamScore);
            Assert.AreEqual(0, match.GetScore().AwayTeamScore);
        }

        [TestMethod]
        public void Should_Update_The_Score()
        {
            // Arrange
            Match match = new Match("HomeTeam", "AwayTeam");
            var homeTeamScore = 2;
            var awayTeamScore = 1;

            // Act
            match.UpdateScore(homeTeamScore, awayTeamScore);

            // Assert
            Assert.AreEqual(homeTeamScore, match.GetScore().HomeTeamScore);
            Assert.AreEqual(awayTeamScore, match.GetScore().AwayTeamScore);
        }


    }
}