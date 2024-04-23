using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Data
{
    internal static class JsonDataChange
    {
        public static RawWeatherDataDto JsonDataInClass(JObject weatherDataObject) {

            RawWeatherDataDto rawWeatherDataDto = new RawWeatherDataDto();
            rawWeatherDataDto.CurrentDto = JsonConvert.DeserializeObject<CurrentDto>(weatherDataObject["current"].ToString());
            rawWeatherDataDto.CurrentUnitsDto = JsonConvert.DeserializeObject<CurrentUnitsDto>(weatherDataObject["current_units"].ToString());
            //rawWeatherDataDto.HourlyDto = JsonConvert.DeserializeObject<HourlyDto>(weatherDataObject["hourly"].ToString());
            //rawWeatherDataDto.HourlyUnitsDto = JsonConvert.DeserializeObject<HourlyUnitsDto>(weatherDataObject["hourly_units"].ToString());
            //rawWeatherDataDto.DailyDto = JsonConvert.DeserializeObject<DailyDto>(weatherDataObject["daily"].ToString());
            //rawWeatherDataDto.DailyUnitsDto = JsonConvert.DeserializeObject<DailyUnitsDto>(weatherDataObject["daily_units"].ToString());

            return rawWeatherDataDto;
        }
    }
}
