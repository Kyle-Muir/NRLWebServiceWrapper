using System;

namespace NrlWebServiceWrapper.Integration
{
    public interface IClock
    {
        DateTime UtcNow { get; }
        DateTime Now { get; }
    }
}