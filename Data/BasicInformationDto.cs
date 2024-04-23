using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Weather.Data
{
    /// <summary>
    /// 基本情報データクラス
    /// </summary>
    public class BasicInformationDto
    {
        /// <summary>
        /// 緯度
        /// </summary>
        [JsonProperty("latitude")]
        public String Latitude { get; set; } = string.Empty;

        /// <summary>
        /// 経度
        /// </summary>
        [JsonProperty("longitude")]
        public String Longitude { get; set; } = string.Empty;

        /// <summary>
        /// 世代時間ミリ秒
        /// </summary>
        [JsonProperty("generationtime_ms")]
        public String GenerationtimeMs { get; set; } = string.Empty;

        /// <summary>
        /// UTC オフセット秒
        /// </summary>
        [JsonProperty("utc_offset_seconds")]
        public String UtcOffsetSeconds { get; set; } = string.Empty;

        /// <summary>
        /// タイムゾーン
        /// </summary>
        [JsonProperty("timezone")]
        public String Timezone { get; set; } = string.Empty;

        /// <summary>
        /// タイムゾーン略語
        /// </summary>
        [JsonProperty("timezone_abbreviation")]
        public String TimezoneAbbreviation { get; set; } = string.Empty;

        /// <summary>
        /// 標高
        /// </summary>
        [JsonProperty("elevation")]
        public String Elevation { get; set; } = string.Empty;
    }
}
