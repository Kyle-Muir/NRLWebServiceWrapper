using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using NrlWebServiceWrapper.Core;
using NrlWebServiceWrapper.Integration;

namespace NrlWebServiceWrapper.Controllers
{
    [EnableCors("*", headers: "*", methods: "*")]
    public class NrlController : ApiController
    {
        private readonly INrlRepository _nrlRepository;
        // GET api/values
        public NrlController()
        {
            _nrlRepository = new NrlRepository(new Uri("http://rbl.webservice.sportsflash.com.au/WebService.asmx"), 151);
        }

        public IEnumerable<MatchUpDto> Get()
        {
            int currentRound = _nrlRepository.LoadCurrentRound();
            IEnumerable<MatchUp> roundMatchUps = _nrlRepository.LoadCurrentRoundMatchUps(currentRound);
            return roundMatchUps.Select(item => new MatchUpDto
            {
                Match = item.Match,
                Name = item.Round,
                StartDate = item.StartDate.ToString("o"),
                Venue = item.Venue
            });
        }
    }
}
