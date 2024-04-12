namespace ScoreBoard
{
    public class Score
    {
        public int HomeTeamScore { get; }
        public int AwayTeamScore { get; }

        public Score(int homeTeamScore, int awayTeamScore)
        {
            if (homeTeamScore < 0 || awayTeamScore < 0)
            {
                throw new ArgumentException("Scores cannot be negative.");
            }

            HomeTeamScore = homeTeamScore;
            AwayTeamScore = awayTeamScore;
        }

        public int GetTotalScore()
        {
            return HomeTeamScore + AwayTeamScore;
        }
    }
}