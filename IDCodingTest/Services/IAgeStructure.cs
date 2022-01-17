using IDCodingTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IDCodingTest.Services
{
    public interface IAgeStructure
    {
        public IEnumerable<ResponseData> GetAllAges_byregion_bysex(int region, int sex);

        public IEnumerable<ResponseData> GetAgeStructureDiff_bytime(int year1, int year2)
        { return null; }




    }
}
