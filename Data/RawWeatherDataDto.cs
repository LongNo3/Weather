using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Weather.Data
{
    public class RawWeatherDataDto
    {
        /// <summary>基本情報データ</summary>
        public BasicInformationDto BasicInformationDto { get; set; } = new BasicInformationDto();

        /// <summary>現在天気データ</summary>
        public CurrentDto CurrentDto { get; set; } = new CurrentDto();

        /// <summary>現在天気単位データ</summary>
        public CurrentUnitsDto CurrentUnitsDto { get; set; } = new CurrentUnitsDto();

        /// <summary>週間天気データ</summary>
        public DailyDto DailyDto { get; set; } = new DailyDto();

        /// <summary>週間天気単位データ</summary>
        public DailyUnitsDto DailyUnitsDto { get; set; } = new DailyUnitsDto();

        /// <summary>時間天気データ</summary>
        public HourlyDto HourlyDto { get; set; } = new HourlyDto();

        /// <summary>時間天気単位データ</summary>
        public HourlyUnitsDto HourlyUnitsDto { get; set; } = new HourlyUnitsDto();
    }
}
