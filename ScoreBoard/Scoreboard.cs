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
            return Matches;
        }

        public void StartMatch(string homeTeam, string awayTeam)
        {
            var match = new Match(homeTeam, awayTeam);
            Matches.Add(match);
        }
    }
}
