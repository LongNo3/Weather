using System.Diagnostics;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text.Json.Nodes;
using System.Text;
using System.Web;
using System.Net.Http.Headers;
using Weather.Data;
using System;
using System.Xml.Linq;
using Weather.Database;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Drawing;
using System.Reflection.Emit;

namespace Weather
{
    /// <summary>
    /// 天気情報メインクラス
    /// </summary>
    public partial class WeatherMain : Form
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public WeatherMain()
        {
            InitializeComponent();

            //lblCurrentWeathrの親コントロールをpbShitaとする
            this.pbShita.Controls.Add(this.lblCurrentWeathr);

            //lblCurrentWeathrの位置をpbShita内の位置に変更する
            this.lblCurrentWeathr.Top = 160;
            this.lblCurrentWeathr.Left = this.lblCurrentWeathr.Left - this.pbShita.Left;
        }

        /// <summary>
        /// アプリケーションが最初に動いたときに呼ばれるメソッド
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void WeatherMainLoad(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            lblToday.Text = today.ToString("yyyy年MM月dd日(ddd)");
            await this.JsonAsync();
        }

        /// <summary>
        /// 天気サイトからJSON情報を取得する（仮）
        /// </summary>
        /// <returns></returns>
        private async Task JsonAsync()
        {
        // URLエンコーディング
        // https://api.open-meteo.com/v1/forecast?latitude=52.52&longitude=13.41&current=temperature_2m,weather_code&hourly=temperature_2m&daily=weather_code,apparent_temperature_max,apparent_temperature_min&timezone=Asia%2FTokyo
        // https://api.open-meteo.com/v1/forecast?latitude=52.52&longitude=13.41&current=temperature_2m,precipitation,weather_code&hourly=temperature_2m,precipitation_probability&daily=weather_code,temperature_2m_max,temperature_2m_min,apparent_temperature_max,apparent_temperature_min,precipitation_probability_max&timezone=Asia%2FTokyo
            string url = "https://api.open-meteo.com/v1/forecast?latitude=35.00&longitude=135.00&current=temperature_2m,precipitation,weather_code&hourly=temperature_2m,precipitation_probability&daily=weather_code,temperature_2m_max,temperature_2m_min,apparent_temperature_max,apparent_temperature_min,precipitation_probability_max&timezone=Asia%2FTokyo";

            try
            {
                // Webから天気予報Jsonを取得する。
                HttpClient client = new();
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
                client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

                // 天気データをjson形式で受け取る
                string weatherData = await client.GetStringAsync(url);
                JObject weatherDataObject = JObject.Parse(weatherData);

                // jsonデータをデータクラスに格納する
                RawWeatherDataDto rawWeatherDataDto = JsonDataChange.JsonDataInClass(weatherDataObject);

                DatabaseAccess dba = new DatabaseAccess();
                string? value = dba.GetValue(rawWeatherDataDto.CurrentDto.WeatherCode);
                string[] values = value.Split(",");
                this.lblCurrentWeathr.Text = values[0];
                this.lblCurrentTemperature.Text = rawWeatherDataDto.CurrentDto.Temperature2m + rawWeatherDataDto.CurrentUnitsDto.Temperature2mUnit;

                // 表示アイコン
                Bitmap img1 = new Bitmap("../../../Picture/" + values[1]);
                Bitmap img2 = new Bitmap("../../../Picture/" + values[2]);
                img1.MakeTransparent(img1.GetPixel(0, 0));
                img2.MakeTransparent(img2.GetPixel(0, 0));

                // アイコン合成
                Graphics g = Graphics.FromImage(img1);
                g.DrawImage(img2, 0, 0, img2.Width, img2.Height);
                g.Dispose();
                img2.Dispose();

                // アイコン表示
                this.pbShita.Image = img1;
            }
            catch (Exception ex)
            {
                lblErrer.Text= ex.Message;
            }
        }
    }
}
