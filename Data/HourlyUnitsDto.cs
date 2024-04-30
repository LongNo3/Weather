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
        public IList<String>? DateTimeCode { get; set; }

        /// <summary>
        /// 2m以下の温度単位
        /// </summary>
        [JsonProperty("temperature_2m")]
        public IList<String>? Temperature2mUnit { get; set; }

        /// <summary>
        /// 最大降水確率単位
        /// </summary>
        [JsonProperty("precipitation_probability")]
        public IList<String>? PrecipitationQrobabilityUnit { get; set; }
    }
}
