using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Weather.Data
{
    /// <summary>
    /// 時間天気データ単位クラス(hourly_units)
    /// </summary>
    [JsonObject("hourly_units")]
    public class HourlyUnitsDto
    {
        /// <summary>
        /// 日時ISOコード
        /// </summary>
        [JsonProperty("time")]
        public String DateTimeCode { get; set; } = string.Empty;

        /// <summary>
        /// 2m以下の温度単位
        /// </summary>
        [JsonProperty("temperature_2m")]
        public String Temperature2mUnit { get; set; } = string.Empty;

        /// <summary>
        /// 最大降水確率単位
        /// </summary>
        [JsonProperty("precipitation_probability")]
        public String PrecipitationQrobabilityUnit { get; set; } = string.Empty;
    }
}
