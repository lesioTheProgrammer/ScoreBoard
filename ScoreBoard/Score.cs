namespace ScoreBoard
{
    public class Score
    {
        public int HomeTeamScore { get; }
        public int AwayTeamScore { get; }

        public Score(int homeTeamScore, int awayTeamScore)
        {
            HomeTeamScore = homeTeamScore;
            AwayTeamScore = awayTeamScore;
        }

    }
}