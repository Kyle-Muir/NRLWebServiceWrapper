using System;
using NrlWebServiceWrapper.Core;
using NrlWebServiceWrapper.Core.Domain;
using NrlWebServiceWrapper.Integration.Contracts;

namespace NrlWebServiceWrapper.Integration.Builder
{
    public class MatchUpBuilder
    {
        private readonly FixtureEvent _item;

        public MatchUpBuilder(FixtureEvent item)
        {
            if (item == null) throw new ArgumentNullException("item");
            _item = item;
        }

        public MatchUp Build()
        {

            bool isCurrentlyInProgress = CalculateIfGameIsCurrentlyInProgress(_item.Status);
            return new MatchUp(_item.matchId, _item.Round, _item.Match, _item.Venue.Value,
                _item.StartDateTimeUTC, isCurrentlyInProgress);

        }

        private bool CalculateIfGameIsCurrentlyInProgress(string status)
        {
            return status == "P";
        }
    }
}