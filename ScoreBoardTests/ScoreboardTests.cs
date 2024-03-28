using FluentAssertions;
using ScoreBoard;

namespace ScoreBoardTests
{

    [TestClass]
    public class ScoreboardTests
    {
        [TestMethod]
        public void Scoreboard_Initialization_ShouldHaveEmptyListOfMatches()
        {
            // Arrange
            var scoreboard = new Scoreboard();

            // Act
            var matches = scoreboard.GetMatches();

            // Assert
            Assert.AreEqual(0, matches.Count);
        }

        [TestMethod]
        public void Should_Start_The_Match_On_Board()
        {
            // Arrange
            var scoreboard = new Scoreboard();
            var homeTeam = "HomeTeam";
            var awayTeam = "AwayTeam";

            // Act
            scoreboard.StartMatch(homeTeam, awayTeam);

            // Assert
            Assert.AreEqual(1, scoreboard.GetMatches().Count);
            Assert.AreEqual(homeTeam, scoreboard.GetMatches()[0].HomeTeam);
            Assert.AreEqual(awayTeam, scoreboard.GetMatches()[0].AwayTeam);
        }

        [TestMethod]
        public void Should_Update_The_Scoreboard()
        {
            // Arrange
            var scoreboard = new Scoreboard();
            scoreboard.StartMatch("HomeTeam", "AwayTeam");
            var homeTeamScore = 2;
            var awayTeamScore = 1;

            // Act
            scoreboard.UpdateScore("HomeTeam", "AwayTeam", homeTeamScore, awayTeamScore);

            // Assert
            Assert.AreEqual(homeTeamScore, scoreboard.GetMatches()[0].GetScore().HomeTeamScore);
            Assert.AreEqual(awayTeamScore, scoreboard.GetMatches()[0].GetScore().AwayTeamScore);
        }

        [TestMethod]
        public void Should_Throw_NotFound_Game()
        {
            // Arrange
            var scoreboard = new Scoreboard();

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() =>
            {
                scoreboard.UpdateScore("NonexistentHomeTeam", "NonexistentAwayTeam", 1, 2);
            });
        }

        [TestMethod]
        public void Should_Finish_The_Game()
        {
            // Arrange
            var scoreboard = new Scoreboard();
            scoreboard.StartMatch("HomeTeam", "AwayTeam");
            scoreboard.StartMatch("HomeTeam2", "AwayTeam2");

            // Act
            scoreboard.FinishMatch("HomeTeam2", "AwayTeam2");

            // Assert
            Assert.AreEqual(1, scoreboard.GetMatches().Count);
        }

        [TestMethod]
        public void Should_Get_The_Summary_In_Order()
        {
            // Arrange
            var scoreboard = new Scoreboard();
            scoreboard.StartMatch("HomeTeam", "AwayTeam");
            scoreboard.StartMatch("HomeTeam2", "AwayTeam2");
            scoreboard.StartMatch("HomeTeam3", "AwayTeam3");
            scoreboard.StartMatch("HomeTeam4", "AwayTeam4");

            // (DateStarted, HighestScore)
            scoreboard.UpdateScore("HomeTeam3", "AwayTeam3", 3, 3); // (3, 2)
            scoreboard.UpdateScore("HomeTeam", "AwayTeam", 4, 2); // (1, 2)
            scoreboard.UpdateScore("HomeTeam2", "AwayTeam2", 1, 4); // (2, 3)
            scoreboard.UpdateScore("HomeTeam4", "AwayTeam4", 7, 4); // (4, 1)



            // Act
            var matches = scoreboard.GetMatches();

            // Assert
            Assert.AreEqual("HomeTeam4", matches[0].HomeTeam);
            Assert.AreEqual("HomeTeam", matches[1].HomeTeam);
            Assert.AreEqual("HomeTeam3", matches[2].HomeTeam);
            Assert.AreEqual("HomeTeam2", matches[3].HomeTeam);
        }
    }
}
