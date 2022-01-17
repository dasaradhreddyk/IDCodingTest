namespace IDCodingExercise.Models
{
    public class APIResponseData
    {
       
            //Region Code (ex. SA4 code or STATE code), Region name,Age,Sex(ex.Males/Females/Persons),Population
            public string regionCode { get; set; }
            public string regionName { get; set; }
            public string age { get; set; }

            public string sex { get; set; }
            public int population { get; set; }
        }
    }
