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
        public String DateCode { get; set; } = string.Empty;

        /// <summary>
        /// 天気コードWMO
        /// </summary>
        [JsonProperty("weather_code")]
        public String WeatherCodeWmo { get; set; } = string.Empty;

        /// <summary>
        /// 2m以下の最高温度単位
        /// </summary>
        [JsonProperty("temperature_2m_max")]
        public String Temperature2mMaxUnit { get; set; } = string.Empty;

        /// <summary>
        /// 2m以下の最低温度単位
        /// </summary>
        [JsonProperty("temperature_2m_min")]
        public String Temperature2mMinUnit { get; set; } = string.Empty;

        /// <summary>
        /// 見かけの最高温度単位
        /// </summary>
        [JsonProperty("apparent_temperature_max")]
        public String ApparentTemperatureMaxUnit { get; set; } = string.Empty;

        /// <summary>
        /// 見かけの最高温度単位
        /// </summary>
        [JsonProperty("apparent_temperature_min")]
        public String ApparentTemperatureMinUnit { get; set; } = string.Empty;

        /// <summary>
        /// 最大降水確率単位
        /// </summary>
        [JsonProperty("precipitation_probability_max")]
        public String PrecipitationProbabilityMaxUnit { get; set; } = string.Empty;
    }
}
