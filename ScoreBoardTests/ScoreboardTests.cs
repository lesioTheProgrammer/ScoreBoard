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
            Scoreboard scoreboard = new Scoreboard();

            // Act
            var matches = scoreboard.GetMatches();

            // Assert
            Assert.AreEqual(0, matches.Count);
        }


    }
}
