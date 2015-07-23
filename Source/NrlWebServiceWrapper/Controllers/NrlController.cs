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
        private readonly IFridayNightResolver _fridayNightResolver;

        // GET api/values
        public NrlController()
        {
            _nrlRepository = new NrlRepository(new Uri("http://rbl.webservice.sportsflash.com.au/WebService.asmx"), 151);
            _fridayNightResolver = new FridayNightResolver();
        }

        public IEnumerable<MatchUpDto> Get()
        {
            DateTime friday = _fridayNightResolver.FindFridayNightRound(DateTime.Today);
            IEnumerable<MatchUp> roundMatchUps = _nrlRepository.LoadCurrentRoundMatchUps(friday);
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
