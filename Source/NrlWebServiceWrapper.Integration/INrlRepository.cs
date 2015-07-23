using System;
using System.Collections.Generic;
using NrlWebServiceWrapper.Core;

namespace NrlWebServiceWrapper.Integration
{
    public interface INrlRepository
    {
        IEnumerable<MatchUp> LoadCurrentRoundMatchUps(DateTime firstFridayOfRound);
    }
}