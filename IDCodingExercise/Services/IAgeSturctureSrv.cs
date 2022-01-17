using IDCodingExercise.Models;
using System.Collections.Generic;

namespace IDCodingExercise.Services
{
    public interface IAgeSturctureSrv
    {
        public IEnumerable<APIResponseData> GetAllAges_byregion_bysex(int region, int sex);

        public IEnumerable<APIResponseData> GetAgeStructureDiff_bytime(int year1, int year2)
        { return null; }
    }
}
