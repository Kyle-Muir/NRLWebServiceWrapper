using System;
using NrlWebServiceWrapper.Core.Domain;
using NrlWebServiceWrapper.Integration.Contracts;

namespace NrlWebServiceWrapper.Integration.Builder
{
    public class MatchScorecardBuilder
    {
        private readonly Scorecard _scorecard;

        public MatchScorecardBuilder(Scorecard scorecard)
        {
            if (scorecard == null) throw new ArgumentNullException("scorecard");
            _scorecard = scorecard;
        }

        public MatchScorecard Build()
        {
            ScorecardMatchTeam[] teams = _scorecard.Match.Team;
            TeamPointsBuilder builder = new TeamPointsBuilder(teams);
            MatchStatus status = MatchStatusResolver.Resolve(_scorecard.Match.statusId);
            return new MatchScorecard(builder.BuildHomeTeam(), builder.BuildAwayTeam(), status);
        }
    }
}