using System.Text.RegularExpressions;

namespace ScoreBoard
{
    public class Scoreboard
    {
        private List<Match> Matches;

        public Scoreboard()
        {
            Matches = new List<Match>();
        }

        public List<Match> GetMatches()
        {
            return Matches.OrderByDescending(x => x.GetScore().GetTotalScore()).ThenBy(x => x.DateGameStarted).ToList();
        }

        public void StartMatch(string homeTeam, string awayTeam)
        {
            var match = new Match(homeTeam, awayTeam);
            Matches.Add(match);
        }

        public void UpdateScore(string homeTeam, string awayTeam, int homeTeamScore, int awayTeamScore)
        {
            Match match = Matches.SingleOrDefault(m => m.HomeTeam == homeTeam && m.AwayTeam == awayTeam);
            if (match != null)
            {
                match.UpdateScore(homeTeamScore, awayTeamScore);
            }
            else
            {
                throw new ArgumentException("Match not found");
            }
        }

        public void FinishMatch(string homeTeam, string awayTeam)
        {
            Matches.RemoveAll(x => x.HomeTeam == homeTeam && x.AwayTeam == awayTeam);
        }
    }
}
