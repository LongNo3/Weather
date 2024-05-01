using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Weather.Data
{
    /// <summary>
    /// 時間天気データクラス(hourly)
    /// </summary>
    [JsonObject("hourly")]
    public class HourlyDto
    {
        /// <summary>
        /// 日時
        /// </summary>
        [JsonProperty("time")]
        public IList<String> DateTime { get; set; } = [];

        /// <summary>
        /// 2m以下の温度
        /// </summary>
        [JsonProperty("temperature_2m")]
        public IList<String> Temperature2m { get; set; } = [];

        /// <summary>
        /// 最大降水確率
        /// </summary>
        [JsonProperty("precipitation_probability")]
        public IList<String> PrecipitationQrobability { get; set; } = [];
    }
}
