using IDCodingExercise.Models;
using IDCodingExercise.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace IDCodingExercise.Controllers
{
    public class APIController : ControllerBase
    {
        // GET: APIController
        private readonly IAgeSturctureSrv _srv;

        // GET: APIController/Details/5
        public APIController(IAgeSturctureSrv srv)
        {

            _srv = srv;
        }

        //  [HttpGet("{controller}/{action}/{regionid?:int}")]
        [HttpGet]
        [Route("api/GetAllAges_byregion_bysex/{id}/{regionid}/{sexid}")]
        public IEnumerable<APIResponseData> GetAllAges_byregion_bysex([FromQuery] int id, int regionid, int sexid)
        {
            return _srv.GetAllAges_byregion_bysex(regionid, sexid);
        }
        [HttpGet]
        [Route("api/GetAgeStructureDiff_bytime/{id}/{year1}/{year2}")]
        public IEnumerable<APIResponseData> GetAgeStructureDiff_bytime([FromQuery] int id, int year1, int year2)
        {
            return _srv.GetAgeStructureDiff_bytime(year1, year2);
        }

    }
}
