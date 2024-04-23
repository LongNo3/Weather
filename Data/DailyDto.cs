using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Weather.Data
{
    /// <summary>
    /// 日次データクラス
    /// </summary>
    [JsonObject("daily")]
    public class DailyDto
    {
        /// <summary>
        /// 日付
        /// </summary>
        [JsonProperty("time")]
        public String Date { get; set; } = string.Empty;

        /// <summary>
        /// 天気コード
        /// </summary>
        [JsonProperty("weather_code")]
        public String WeatherCode { get; set; } = string.Empty;

        /// <summary>
        /// 2m以下の最高温度
        /// </summary>
        [JsonProperty("temperature_2m_max")]
        public String Temperature2mMax { get; set; } = string.Empty;

        /// <summary>
        /// 2m以下の最低温度
        /// </summary>
        [JsonProperty("temperature_2m_min")]
        public String Temperature2mMin { get; set; } = string.Empty;

        /// <summary>
        /// 見かけの最高温度
        /// </summary>
        [JsonProperty("apparent_temperature_max")]
        public String ApparentTemperatureMax { get; set; } = string.Empty;

        /// <summary>
        /// 見かけの最低温度
        /// </summary>
        [JsonProperty("apparent_temperature_min")]
        public String ApparentTemperatureMin { get; set; } = string.Empty;

        /// <summary>
        /// 最大降水確率
        /// </summary>
        [JsonProperty("precipitation_probability_max")]
        public String PrecipitationProbabilityMax { get; set; } = string.Empty;
    }
}
