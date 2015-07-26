using System;
using System.Collections.Generic;
using NrlWebServiceWrapper.Core;
using NrlWebServiceWrapper.Core.Domain;

namespace NrlWebServiceWrapper.Integration
{
    public interface INrlRepository
    {
        IEnumerable<MatchUp> LoadCurrentRoundMatchUps(DateTime firstFridayOfRound);
        MatchScorecard LoadMatchScorecard(int matchId);
    }
}