using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Weather.Data
{
    /// <summary>
    /// 日次データ単位クラス
    /// </summary>
    [JsonObject("daily_units")]
    public class DailyUnitsDto
    {
        /// <summary>
        /// 日付ISOコード
        /// </summary>
        [JsonProperty("time")]
        public IList<String>? DateCode { get; set; }

        /// <summary>
        /// 天気コードWMO
        /// </summary>
        [JsonProperty("weather_code")]
        public IList<String>? WeatherCodeWmo { get; set; }

        /// <summary>
        /// 2m以下の最高温度単位
        /// </summary>
        [JsonProperty("temperature_2m_max")]
        public IList<String>? Temperature2mMaxUnit { get; set; }

        /// <summary>
        /// 2m以下の最低温度単位
        /// </summary>
        [JsonProperty("temperature_2m_min")]
        public IList<String>? Temperature2mMinUnit { get; set; }

        /// <summary>
        /// 見かけの最高温度単位
        /// </summary>
        [JsonProperty("apparent_temperature_max")]
        public IList<String>? ApparentTemperatureMaxUnit { get; set; }

        /// <summary>
        /// 見かけの最高温度単位
        /// </summary>
        [JsonProperty("apparent_temperature_min")]
        public IList<String>? ApparentTemperatureMinUnit { get; set; }

        /// <summary>
        /// 最大降水確率単位
        /// </summary>
        [JsonProperty("precipitation_probability_max")]
        public IList<String>? PrecipitationProbabilityMaxUnit { get; set; }
    }
}
