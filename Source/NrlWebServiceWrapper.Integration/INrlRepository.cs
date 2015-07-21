using System.Collections.Generic;
using NrlWebServiceWrapper.Core;

namespace NrlWebServiceWrapper.Integration
{
    public interface INrlRepository
    {
        int LoadCurrentRound();
        IEnumerable<MatchUp> LoadCurrentRoundMatchUps(int roundNumber);
    }
}