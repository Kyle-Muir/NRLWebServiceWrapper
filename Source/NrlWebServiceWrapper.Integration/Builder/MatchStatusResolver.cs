using System;
using NrlWebServiceWrapper.Core;
using NrlWebServiceWrapper.Core.Domain;

namespace NrlWebServiceWrapper.Integration.Builder
{
    public static class MatchStatusResolver
    {
        public static MatchStatus Resolve(string statusId)
        {
            switch (statusId)
            {
                case "F":
                    return MatchStatus.Finished;
                case "L":
                    return MatchStatus.Live;
                case "N":
                    return MatchStatus.NotYetStarted;
                default:
                    throw new ArgumentException("Unable to resolve match status for status id \"{0}\"".FormatWith(statusId));
            }
        }

        public static string Resolve(MatchStatus status)
        {
            switch (status)
            {
                case MatchStatus.Finished:
                    return "Finished";
                case MatchStatus.Live:
                    return "Live";
                case MatchStatus.NotYetStarted:
                    return "Not yet started";
                default:
                    throw new ArgumentException("Unable to resolve match status \"{0}\"".FormatWith(status));
            }
        }
    }
}