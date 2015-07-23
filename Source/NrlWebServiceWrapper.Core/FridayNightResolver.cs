using System;

namespace NrlWebServiceWrapper.Core
{
    public class FridayNightResolver : IFridayNightResolver
    {
        public DateTime FindFridayNightRound(DateTime today)
        {
            if (today.DayOfWeek == DayOfWeek.Tuesday ||
                today.DayOfWeek == DayOfWeek.Wednesday ||
                today.DayOfWeek == DayOfWeek.Thursday ||
                today.DayOfWeek == DayOfWeek.Friday)
            {
                DateTime nextFriday = FindNextFriday(today);
                return nextFriday;
            }
            return GetPreviousFriday(today);
        }

        private DateTime GetPreviousFriday(DateTime date)
        {
            switch (date.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    return date.AddDays(-3);
                case DayOfWeek.Sunday:
                    return date.AddDays(-2);
                case DayOfWeek.Saturday:
                    return date.AddDays(-1);
                default:
                    throw new ArgumentException(string.Format("Unable to resolve previous Friday for {0}", date.DayOfWeek));
            }
        }

        //Finds next Friday or returns today if today is Friday.
        private DateTime FindNextFriday(DateTime today)
        {
            int daysUntilFriday = ((int)DayOfWeek.Friday - (int)today.DayOfWeek + 7) % 7;
            return today.AddDays(daysUntilFriday);
        }
    }
}