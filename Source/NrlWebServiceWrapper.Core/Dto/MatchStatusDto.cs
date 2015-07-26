namespace NrlWebServiceWrapper.Core.Dto
{
    public class MatchStatusDto
    {
        public TeamPointsDto Home { get; set; } 
        public TeamPointsDto Away { get; set; }
        public string MatchStatus { get; set; }
    }
}