using System;

namespace NrlWebServiceWrapper.Core
{
    public interface IFridayNightResolver
    {
        DateTime FindFridayNightRound(DateTime today);
    }
}