using System;

namespace NrlWebServiceWrapper.Core.Domain
{
    public class MatchScorecard
    {
        private readonly TeamPoints _homeTeam;
        private readonly TeamPoints _awayTeam;
        private readonly MatchStatus _status;

        public MatchScorecard(TeamPoints homeTeam, TeamPoints awayTeam, MatchStatus status)
        {
            if (homeTeam == null) throw new ArgumentNullException("homeTeam");
            if (awayTeam == null) throw new ArgumentNullException("awayTeam");
            _homeTeam = homeTeam;
            _awayTeam = awayTeam;
            _status = status;
        }

        public TeamPoints HomeTeam
        {
            get { return _homeTeam; }
        }

        public TeamPoints AwayTeam
        {
            get { return _awayTeam; }
        }

        public MatchStatus Status
        {
            get { return _status; }
        }
    }
}