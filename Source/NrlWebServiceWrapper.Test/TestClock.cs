using System;
using NrlWebServiceWrapper.Integration;

namespace NrlWebServiceWrapper.Test
{
    public class TestClock : IClock
    {
        private DateTime _utcNow;
        private DateTime _now;

        public TestClock()
        {
            _utcNow = DateTime.UtcNow;
            _now = DateTime.Now;
        }

        public DateTime UtcNow
        {
            get { return _utcNow; }
        }

        public DateTime Now
        {
            get { return _now; }
        }

        public void SetNow(DateTime now)
        {
            _now = now;
        }

        public void SetUtcNow(DateTime utcNow)
        {
            _utcNow = utcNow;
        }
    }
}