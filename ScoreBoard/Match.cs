namespace ScoreBoard
{
    public class Match
    {
        public string HomeTeam { get; }
        public string AwayTeam { get; }
        private Score Score { get; set; }


        public Match(string homeTeam, string awayTeam)
        {
            HomeTeam = homeTeam;
            AwayTeam = awayTeam;
        }

        public Score GetScore()
        {
            return Score;
        }
    }
}
