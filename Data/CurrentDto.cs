using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Weather.Data
{
    /// <summary>
    /// 現在天気データクラス(current)
    /// </summary>
    [JsonObject("current")]
    public class CurrentDto
    {
        /// <summary>
        /// 日時
        /// </summary>
        [JsonProperty("time")]
        public String DateTime { get; set; } = string.Empty;

        /// <summary>
        /// 更新時間
        /// </summary>
        [JsonProperty("interval")]
        public String Interval { get; set; } = string.Empty;

        /// <summary>
        /// 2m以下の温度
        /// </summary>
        [JsonProperty("temperature_2m")]
        public String Temperature2m { get; set; } = string.Empty;

        /// <summary>
        /// 最大降水確率
        /// </summary>
        [JsonProperty("precipitation")]
        public String Precipitation { get; set; } = string.Empty;

        /// <summary>
        /// 天気コード
        /// </summary>
        [JsonProperty("weather_code")]
        public String WeatherCode { get; set; } = string.Empty;
    }
}
