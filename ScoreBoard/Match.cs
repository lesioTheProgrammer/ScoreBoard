namespace ScoreBoard
{
    public class Match
    {
        public string HomeTeam { get; }
        public string AwayTeam { get; }
        private Score Score { get; set; }

        public DateTime DateGameStarted { get; private set; }


        public Match(string homeTeam, string awayTeam)
        {
            HomeTeam = homeTeam;
            AwayTeam = awayTeam;
            Score = new Score(0, 0);
            DateGameStarted = DateTime.Now;
        }

        public Score GetScore()
        {
            return Score;
        }

        public void UpdateScore(int homeTeamScore, int awayTeamScore)
        {
            Score = new Score(homeTeamScore, awayTeamScore);
        }
    }
}
