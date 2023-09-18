using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Mobile.Global
{
    public static class GlobalData
    {
        public static Dictionary<string, string> WeatherImages = new Dictionary<string, string>
        {
            { "clear", "clear" },
            { "mostClear", "cloudy1" },
            { "slightCloudy", "cloudy1" },
            { "partCloudy", "cloudy2" },
            { "modCloudy", "cloudy2" },
            { "prevCloudy", "cloudy3" },
            { "overcast", "cloudy4" },
            { "FG", "fog" },
            { "DZ", "drizzle" },
            { "FZDZ", "drizzle" },
            { "RA", "rain" },
            { "FZRA", "rain" },
            { "RASN", "rain_snow" },
            { "SN", "snow" },
            { "SHRA", "rain" },
            { "SHRASN", "rain_snow" },
            { "SHSN", "snow" },
            { "SHGR", "graupel" },
            { "TS", "thunder" },
            { "TSRA", "thunder_rain" },
            { "TSRASN", "thunder_rain_snow" },
            { "TSSN", "thunder_snow" },
            { "TSGR", "thunder_hail" }
        };
    }
}
