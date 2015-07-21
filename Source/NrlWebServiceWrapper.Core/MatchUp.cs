using System;

namespace NrlWebServiceWrapper.Core
{
    public class MatchUp
    {
        private readonly string _round;
        private readonly string _match;
        private readonly string _venue;
        private readonly DateTime _startDate;
        //Teamid = 1
        public MatchUp(string round, string match, string venue, DateTime startDate)
        {
            if (string.IsNullOrEmpty(round)) throw new ArgumentNullException("round");
            if (string.IsNullOrEmpty(match)) throw new ArgumentNullException("match");
            if (string.IsNullOrEmpty(venue)) throw new ArgumentNullException("venue");

            _round = round;
            _match = match;
            _venue = venue;
            _startDate = startDate;
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
    }
}