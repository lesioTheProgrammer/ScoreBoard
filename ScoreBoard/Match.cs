namespace ScoreBoard
{
    public class Match
    {
        public string HomeTeam { get; }
        public string AwayTeam { get; }

        public Match(string homeTeam, string awayTeam)
        {
            HomeTeam = homeTeam;
            AwayTeam = awayTeam;
        }
    }
}
