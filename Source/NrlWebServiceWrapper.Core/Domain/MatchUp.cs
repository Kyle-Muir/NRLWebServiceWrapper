using System;

namespace NrlWebServiceWrapper.Core.Domain
{
    public class MatchUp
    {
        private readonly int _matchId;
        private readonly string _round;
        private readonly string _match;
        private readonly string _venue;
        private readonly DateTime _startDate;
        private readonly bool _isCurrentlyInProgress;

        public MatchUp(int matchId, string round, string match, string venue, DateTime startDate, bool isCurrentlyInProgress)
        {
            if (string.IsNullOrEmpty(round)) throw new ArgumentNullException("round");
            if (string.IsNullOrEmpty(match)) throw new ArgumentNullException("match");
            if (string.IsNullOrEmpty(venue)) throw new ArgumentNullException("venue");

            _matchId = matchId;
            _round = round;
            _match = match;
            _venue = venue;
            _startDate = startDate;
            _isCurrentlyInProgress = isCurrentlyInProgress;
        }

        public string Round
        {
            get { return _round; }
        }

        public string Match
        {
            get { return _match; }
        }

        public string Venue
        {
            get { return _venue; }
        }

        public DateTime StartDate
        {
            get { return _startDate; }
        }

        public bool IsCurrentlyInProgress
        {
            get { return _isCurrentlyInProgress; }
        }

        public int MatchId
        {
            get { return _matchId; }
        }
    }
}