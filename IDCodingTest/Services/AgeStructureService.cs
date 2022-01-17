using IDCodingTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IDCodingTest.Services
{
    public class AgeStructureService : IAgeStructure
    {
        private readonly ApplicationContext _cxt;
        public AgeStructureService(ApplicationContext cxt)
        {
            _cxt = cxt;
        }
        public IEnumerable<ResponseData> GetAllAges_byregion_bysex(int SA4Code, int sex) 
        {
            var result = new List<ResponseData>();

            //get popuation data
            // convert to r =esponse model 
             var values = _cxt.ABSPopulationValues.Where(x=>x.regionid == SA4Code).ToList();
             foreach(ABSPopulationValues r in values)
            {
                var data = new ResponseData();
                data.regionCode = _cxt.Region.Where(x => x.ASGS_2016 == SA4Code).Select(y => y.regiontype).FirstOrDefault().ToString(); ;
                data.regionName = _cxt.Region.Where(x => x.ASGS_2016 == SA4Code).Select(y => y.region).FirstOrDefault().ToString() ;
                data.age = r.age.ToString();
                data.sex = r.sexid.ToString();
                data.population = r.value;
                result.Add(data);

            }


            return result;
        }

        public IEnumerable<ResponseData> GetAgeStructureDiff_bytime(int year1, int year2)
        {
            // get differnce in the age differnce for year1 and year 2. 

            return null;

        }
    }
}
