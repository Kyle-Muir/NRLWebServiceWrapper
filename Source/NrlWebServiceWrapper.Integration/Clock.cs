using System;

namespace NrlWebServiceWrapper.Integration
{
    public class Clock : IClock
    {
        public DateTime UtcNow
        {
            get { return DateTime.UtcNow; }
        }

        public DateTime Now
        {
            get { return DateTime.Now; }
        }
    }
}