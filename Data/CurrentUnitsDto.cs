using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Weather.Data
{
    /// <summary>
    /// 現在天気データ単位クラス(current_units)
    /// </summary>
    [JsonObject("current_units")]
    public class CurrentUnitsDto
    {
        /// <summary>
        /// 日時ISOコード
        /// </summary>
        [JsonProperty("time")]
        public String DateTimeCode { get; set; } = string.Empty;

        /// <summary>
        /// 更新時間単位
        /// </summary>
        [JsonProperty("interval")]
        public String IntervalUnit { get; set; } = string.Empty;

        /// <summary>
        /// 2m以下の温度単位
        /// </summary>
        [JsonProperty("temperature_2m")]
        public String Temperature2mUnit { get; set; } = string.Empty;

        /// <summary>
        /// 降水確率単位
        /// </summary>
        [JsonProperty("precipitation")]
        public String PrecipitationQrobabilityUnit { get; set; } = string.Empty;

        /// <summary>
        /// 天気コードWmo
        /// </summary>
        [JsonProperty("weather_code")]
        public String WeatherCodeWmo { get; set; } = string.Empty;
    }
}
