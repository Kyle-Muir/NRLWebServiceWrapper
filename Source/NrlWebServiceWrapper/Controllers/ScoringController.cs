using System;
using System.Web.Http;
using NrlWebServiceWrapper.Core.Domain;
using NrlWebServiceWrapper.Core.Dto;
using NrlWebServiceWrapper.Integration;
using NrlWebServiceWrapper.Integration.Builder;

namespace NrlWebServiceWrapper.Controllers
{
    public class ScoringController : ApiController
    {
        private readonly INrlRepository _nrlRepository;

        public ScoringController(INrlRepository nrlRepository)
        {
            if (nrlRepository == null) throw new ArgumentNullException("nrlRepository");
            _nrlRepository = nrlRepository;
        }

        public MatchStatusDto Get(int matchId)
        {
            MatchScorecard scorecard = _nrlRepository.LoadMatchScorecard(matchId);
            return new MatchStatusDto
            {
                Away = new TeamPointsDto
                {
                    Name = scorecard.AwayTeam.Name,
                    Points = scorecard.AwayTeam.Points
                },
                Home = new TeamPointsDto
                {
                    Name = scorecard.HomeTeam.Name,
                    Points = scorecard.HomeTeam.Points
                },
                MatchStatus = MatchStatusResolver.Resolve(scorecard.Status)
            };
        }
    }
}
