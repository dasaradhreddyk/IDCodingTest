using IDCodingTest.Models;
using IDCodingTest.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IDCodingTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class APIController : ControllerBase
    {
        // GET: APIController
        private readonly IAgeStructure _srv;

        // GET: APIController/Details/5
        public APIController(IAgeStructure srv)
        {
            
            _srv = srv;
        }

      //  [HttpGet("{controller}/{action}/{regionid?:int}")]
        [HttpGet]
        [Route ("api/GetAllAges_byregion_bysex/{id}")]
        public IEnumerable<ResponseData>  GetAllAges_byregion_bysex([FromQuery] int id, int sexid)
        {
            return _srv.GetAllAges_byregion_bysex(id, sexid);
        }

        // GET: APIController/Create







    }
}
