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
        public IList<String>? Date { get; set; }

        /// <summary>
        /// 天気コード
        /// </summary>
        [JsonProperty("weather_code")]
        public IList<String>? WeatherCode { get; set; }

        /// <summary>
        /// 2m以下の最高温度
        /// </summary>
        [JsonProperty("temperature_2m_max")]
        public IList<String>? Temperature2mMax { get; set; }

        /// <summary>
        /// 2m以下の最低温度
        /// </summary>
        [JsonProperty("temperature_2m_min")]
        public IList<String>? Temperature2mMin { get; set; } 

        /// <summary>
        /// 見かけの最高温度
        /// </summary>
        [JsonProperty("apparent_temperature_max")]
        public IList<String>? ApparentTemperatureMax { get; set; }

        /// <summary>
        /// 見かけの最低温度
        /// </summary>
        [JsonProperty("apparent_temperature_min")]
        public IList<String>? ApparentTemperatureMin { get; set; }

        /// <summary>
        /// 最大降水確率
        /// </summary>
        [JsonProperty("precipitation_probability_max")]
        public IList<String>? PrecipitationProbabilityMax { get; set; }
    }
}
