using IDCodingExercise.Entities;
using IDCodingExercise.Models;
using System.Collections.Generic;
using System.Linq;

namespace IDCodingExercise.Services
{
    public class AgeSturctureSrv : IAgeSturctureSrv
    {
        private readonly ApplicationContext _cxt;
        public AgeSturctureSrv(ApplicationContext cxt)
        {
            _cxt = cxt;
        }
        public IEnumerable<APIResponseData> GetAllAges_byregion_bysex(int SA4Code, int sex)
        {
            var result = new List<APIResponseData>();

            //get popuation data
            // convert to r =esponse model 
            var values = _cxt.ABSPopulationValues.Where(x => x.regionid == SA4Code).ToList();
            foreach (ABSPopulationValues r in values)
            {
                var data = new APIResponseData();
                data.regionCode = _cxt.Region.Where(x => x.ASGS_2016 == SA4Code).Select(y => y.regiontype).FirstOrDefault().ToString(); ;
                data.regionName = _cxt.Region.Where(x => x.ASGS_2016 == SA4Code).Select(y => y.region).FirstOrDefault().ToString();
                data.age = r.age.ToString();
                data.sex = r.sexid.ToString();
                data.population = r.value;
                result.Add(data);

            }


            return result;
        }
        public IEnumerable<APIResponseData> GetAgeStructureDiff_bytime(int year1, int year2)
        {
            // get differnce in the age differnce for year1 and year 2. 

            var result = new List<APIResponseData>();
            var data1 = _cxt.ABSPopulationValues.Where(x => x.time == year1 && x.sexid == 1).ToList();
            var data2 = _cxt.ABSPopulationValues.Where(x => x.time == year1 && x.sexid == 1).ToList();
            var values = data2.Where(p => data1.All(p2 => p2.id != p.id));
            foreach (ABSPopulationValues r in values)
            {
                var data = new APIResponseData();
                data.regionCode = _cxt.Region.Where(x => x.id == r.regionid).Select(y => y.regiontype).FirstOrDefault().ToString(); ;
                data.regionName = _cxt.Region.Where(x => x.id == r.regionid).Select(y => y.region).FirstOrDefault().ToString();
                data.age = r.age.ToString();
                data.sex = r.sexid.ToString();
                data.population = r.value;
                result.Add(data);

            }


            return result;





            return null;

        }
    }
}
