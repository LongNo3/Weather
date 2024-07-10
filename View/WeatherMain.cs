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
using System.Threading;

namespace Weather
{
    /// <summary>
    /// 天気情報メインクラス
    /// </summary>
    public partial class WeatherMain : Form
    {

        /// <summary>日付フォーマット</summary>
        private static String DAY_FORMAT = "yyyy年MM月dd日(ddd)";

        /// <summary>日付フォーマット</summary>
        private static String DAY_FORMAT_SMALL = "MM月\r\ndd日\r\n(ddd)";

        /// <summary>温度記号</summary>
        private static String TEMPERATURE_SYMBOL = "℃";

        /// <summary>アイコンフォルダパス</summary>
        private static String ICON_PATH = "../../../Picture/";

        /// <summary>アイコンフォルダパス</summary>
        private static Size ICON_SIZE_BIG = new Size(200, 200);

        /// <summary>アイコンフォルダパス</summary>
        private static Size ICON_SIZE_SMALL = new Size(50, 50);

        delegate void LblTimeViewDelegate();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public WeatherMain()
        {
            InitializeComponent();
            // フォームの透過
            this.Opacity = 0.85;
        }

        /// <summary>
        /// アプリケーションが最初に動いたときに呼ばれるメソッド
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void WeatherMainLoad(object sender, EventArgs e)
        {
            // 今日の日付
            DateTime today = DateTime.Today;
            lblToday.Text = today.ToString(DAY_FORMAT);

            // 時間表示
            await Task.Run(() =>
            {
                while (true)
                {
                    this.ViewTime();
                    // 1000ミリ秒=1秒
                    Task.Delay(1000);
                }
            });
            //await this.ViewTime();
            lblToday.Text = today.ToString(DAY_FORMAT);
            // 天気表示
            //await Task.Run(() => this.JsonAsync());
            await this.JsonAsync();
        }

        /// <summary>
        /// アプリを閉じるときの処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WeatherMain_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        /// <summary>
        /// 天気サイトからJSON情報を取得し表示する（仮）
        /// </summary>
        /// <returns></returns>
        private async Task JsonAsync()
        {
            // 緯度, 経度
            // 東京：国立(GoogleMap)：35.703943385198265, 139.44832349242623
            // 東京：国立(緯度経度地図 https://fukuno.jig.jp/app/map/latlng/)：35.703127,139.448513
            // https://api.open-meteo.com/v1/forecast?latitude=52.52&longitude=13.41&current=temperature_2m,weather_code&hourly=temperature_2m&daily=weather_code,apparent_temperature_max,apparent_temperature_min&timezone=Asia%2FTokyo
            // 大阪：福島：https://api.open-meteo.com/v1/forecast?latitude=52.52&longitude=13.41&current=temperature_2m,precipitation,weather_code&hourly=temperature_2m,precipitation_probability&daily=weather_code,temperature_2m_max,temperature_2m_min,apparent_temperature_max,apparent_temperature_min,precipitation_probability_max&timezone=Asia%2FTokyo
            // 東京：国立：https://api.open-meteo.com/v1/forecast?latitude=35.703127&longitude=139.448513&current=temperature_2m,precipitation,weather_code&hourly=temperature_2m,precipitation_probability&daily=weather_code,temperature_2m_max,temperature_2m_min,apparent_temperature_max,apparent_temperature_min,precipitation_probability_max&timezone=Asia%2FTokyo

            // URLエンコーディング
            string url = "https://api.open-meteo.com/v1/forecast?latitude=35.703127&longitude=139.448513&current=temperature_2m,precipitation,weather_code&hourly=temperature_2m,precipitation_probability&daily=weather_code,temperature_2m_max,temperature_2m_min,apparent_temperature_max,apparent_temperature_min,precipitation_probability_max&timezone=Asia%2FTokyo";

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

                if (rawWeatherDataDto is not null)
                {
                    // DBアクセスクラスのインスタンス化
                    DatabaseAccess dba = new();

                    // 天気名取得
                    string currentWeathrData = dba.GetValue(rawWeatherDataDto.CurrentDto.WeatherCode);
                    string[] currentWeathrDatas = currentWeathrData.Split(",");
                    this.lblCurrentWeathr.Text = currentWeathrDatas[0];

                    // アイコン表示
                    this.pbShita.Image = this.IconComposition(currentWeathrDatas[1], currentWeathrDatas[2], ICON_SIZE_BIG);

                    // 今の温度を表示
                    this.lblCurrentTemperature.Text = rawWeatherDataDto.CurrentDto.Temperature2m + rawWeatherDataDto.CurrentUnitsDto.Temperature2mUnit;
                    // 今日の最高気温を表示
                    this.lblCurrentTemperatureMax.Text = rawWeatherDataDto.DailyDto.Temperature2mMax[0] + rawWeatherDataDto.DailyUnitsDto.Temperature2mMaxUnit;
                    // 今日の最低気温を表示
                    this.lblCurrentTemperatureMin.Text = rawWeatherDataDto.DailyDto.Temperature2mMin[0] + rawWeatherDataDto.DailyUnitsDto.Temperature2mMinUnit;

                    // 週間天気1
                    string nextWeathrData = string.Empty;
                    this.lblNextDay1.Text = DateTime.Parse(rawWeatherDataDto.DailyDto.Date[1]).ToString(DAY_FORMAT_SMALL);
                    nextWeathrData = dba.GetValue(rawWeatherDataDto.DailyDto.WeatherCode[1]);
                    string[] nextWeathrDatas = nextWeathrData.Split(",");
                    this.lblNextWeathr1.Text = nextWeathrDatas[0];
                    this.pbNextWeathr1.Image = this.IconComposition(nextWeathrDatas[1], nextWeathrDatas[2], ICON_SIZE_SMALL);
                    this.lblNextTemperatureMax1.Text = rawWeatherDataDto.DailyDto.Temperature2mMax[1] + rawWeatherDataDto.DailyUnitsDto.Temperature2mMaxUnit;
                    this.lblNextTemperatureMin1.Text = rawWeatherDataDto.DailyDto.Temperature2mMin[1] + rawWeatherDataDto.DailyUnitsDto.Temperature2mMinUnit;

                    // 週間天気2
                    this.lblNextDay2.Text = DateTime.Parse(rawWeatherDataDto.DailyDto.Date[2]).ToString(DAY_FORMAT_SMALL);
                    nextWeathrData = dba.GetValue(rawWeatherDataDto.DailyDto.WeatherCode[2]);
                    nextWeathrDatas = nextWeathrData.Split(",");
                    this.lblNextWeathr2.Text = nextWeathrDatas[0];
                    this.pbNextWeathr2.Image = this.IconComposition(nextWeathrDatas[1], nextWeathrDatas[2], ICON_SIZE_SMALL);
                    this.lblNextTemperatureMax2.Text = rawWeatherDataDto.DailyDto.Temperature2mMax[2] + rawWeatherDataDto.DailyUnitsDto.Temperature2mMaxUnit;
                    this.lblNextTemperatureMin2.Text = rawWeatherDataDto.DailyDto.Temperature2mMin[2] + rawWeatherDataDto.DailyUnitsDto.Temperature2mMinUnit;

                    // 週間天気3
                    this.lblNextDay3.Text = DateTime.Parse(rawWeatherDataDto.DailyDto.Date[3]).ToString(DAY_FORMAT_SMALL);
                    nextWeathrData = dba.GetValue(rawWeatherDataDto.DailyDto.WeatherCode[3]);
                    nextWeathrDatas = nextWeathrData.Split(",");
                    this.lblNextWeathr3.Text = nextWeathrDatas[0];
                    this.pbNextWeathr3.Image = this.IconComposition(nextWeathrDatas[1], nextWeathrDatas[2], ICON_SIZE_SMALL);
                    this.lblNextTemperatureMax3.Text = rawWeatherDataDto.DailyDto.Temperature2mMax[3] + rawWeatherDataDto.DailyUnitsDto.Temperature2mMaxUnit;
                    this.lblNextTemperatureMin3.Text = rawWeatherDataDto.DailyDto.Temperature2mMin[3] + rawWeatherDataDto.DailyUnitsDto.Temperature2mMinUnit;

                    // 週間天気4
                    this.lblNextDay4.Text = DateTime.Parse(rawWeatherDataDto.DailyDto.Date[4]).ToString(DAY_FORMAT_SMALL);
                    nextWeathrData = dba.GetValue(rawWeatherDataDto.DailyDto.WeatherCode[4]);
                    nextWeathrDatas = nextWeathrData.Split(",");
                    this.lblNextWeathr4.Text = nextWeathrDatas[0];
                    this.pbNextWeathr4.Image = this.IconComposition(nextWeathrDatas[1], nextWeathrDatas[2], ICON_SIZE_SMALL);
                    this.lblNextTemperatureMax4.Text = rawWeatherDataDto.DailyDto.Temperature2mMax[4] + rawWeatherDataDto.DailyUnitsDto.Temperature2mMaxUnit; ;
                    this.lblNextTemperatureMin4.Text = rawWeatherDataDto.DailyDto.Temperature2mMin[4] +rawWeatherDataDto.DailyUnitsDto.Temperature2mMinUnit;

                    // 週間天気5
                    this.lblNextDay5.Text = DateTime.Parse(rawWeatherDataDto.DailyDto.Date[5]).ToString(DAY_FORMAT_SMALL);
                    nextWeathrData = dba.GetValue(rawWeatherDataDto.DailyDto.WeatherCode[5]);
                    nextWeathrDatas = nextWeathrData.Split(",");
                    this.lblNextWeathr5.Text = nextWeathrDatas[0];
                    this.pbNextWeathr5.Image = this.IconComposition(nextWeathrDatas[1], nextWeathrDatas[2], ICON_SIZE_SMALL);
                    this.lblNextTemperatureMax5.Text = rawWeatherDataDto.DailyDto.Temperature2mMax[5] + rawWeatherDataDto.DailyUnitsDto.Temperature2mMaxUnit; ;
                    this.lblNextTemperatureMin5.Text = rawWeatherDataDto.DailyDto.Temperature2mMin[5] + rawWeatherDataDto.DailyUnitsDto.Temperature2mMinUnit;

                    // 週間天気6
                    this.lblNextDay6.Text = DateTime.Parse(rawWeatherDataDto.DailyDto.Date[6]).ToString(DAY_FORMAT_SMALL);
                    nextWeathrData = dba.GetValue(rawWeatherDataDto.DailyDto.WeatherCode[6]);
                    nextWeathrDatas = nextWeathrData.Split(",");
                    this.lblNextWeathr6.Text = nextWeathrDatas[0];
                    this.pbNextWeathr6.Image = this.IconComposition(nextWeathrDatas[1], nextWeathrDatas[2], ICON_SIZE_SMALL);
                    this.lblNextTemperatureMax6.Text = rawWeatherDataDto.DailyDto.Temperature2mMax[6] + rawWeatherDataDto.DailyUnitsDto.Temperature2mMaxUnit;
                    this.lblNextTemperatureMin6.Text = rawWeatherDataDto.DailyDto.Temperature2mMin[6] + rawWeatherDataDto.DailyUnitsDto.Temperature2mMinUnit;


                    /*
                    this.pbNextWeathr2.Image = this.IconComposition(nextWeathrDatas[1], nextWeathrDatas[2], ICON_SIZE_SMALL);
                    //this.pbNextWeathr2.Image = this.IconComposition(nextWeathrDatas[3], nextWeathrDatas[4], ICON_SIZE_SMALL);
                    this.pbNextWeathr3.Image = this.IconComposition(nextWeathrDatas[5], nextWeathrDatas[6], ICON_SIZE_SMALL);
                    this.pbNextWeathr4.Image = this.IconComposition(nextWeathrDatas[7], nextWeathrDatas[8], ICON_SIZE_SMALL);
                    this.pbNextWeathr5.Image = this.IconComposition(nextWeathrDatas[9], nextWeathrDatas[10], ICON_SIZE_SMALL);
                    this.pbNextWeathr6.Image = this.IconComposition(nextWeathrDatas[11], nextWeathrDatas[12], ICON_SIZE_SMALL);
                    this.lblNextTemperatureMax1.Text = rawWeatherDataDto.DailyDto.Temperature2mMax[1] + rawWeatherDataDto.DailyUnitsDto.Temperature2mMaxUnit[1];
                    this.lblNextTemperatureMin1.Text = rawWeatherDataDto.DailyDto.Temperature2mMin[1] + rawWeatherDataDto.DailyUnitsDto.Temperature2mMinUnit[1];
                    this.lblNextTemperatureMax2.Text = rawWeatherDataDto.DailyDto.Temperature2mMax[2] + rawWeatherDataDto.DailyUnitsDto.Temperature2mMaxUnit[2];
                    this.lblNextTemperatureMin2.Text = rawWeatherDataDto.DailyDto.Temperature2mMin[2] + rawWeatherDataDto.DailyUnitsDto.Temperature2mMinUnit[2];
                    this.lblNextTemperatureMax3.Text = rawWeatherDataDto.DailyDto.Temperature2mMax[3] + rawWeatherDataDto.DailyUnitsDto.Temperature2mMaxUnit[3];
                    this.lblNextTemperatureMin3.Text = rawWeatherDataDto.DailyDto.Temperature2mMin[3] + rawWeatherDataDto.DailyUnitsDto.Temperature2mMinUnit[3];
                    this.lblNextDay2.Text = DateTime.Parse(rawWeatherDataDto.DailyDto.Date[2]).ToString(DAY_FORMAT);
                    this.lblNextDay3.Text = DateTime.Parse(rawWeatherDataDto.DailyDto.Date[3]).ToString(DAY_FORMAT);
                    this.lblNextDay4.Text = DateTime.Parse(rawWeatherDataDto.DailyDto.Date[4]).ToString(DAY_FORMAT);
                    this.lblNextDay5.Text = DateTime.Parse(rawWeatherDataDto.DailyDto.Date[5]).ToString(DAY_FORMAT);
                    this.lblNextDay6.Text = DateTime.Parse(rawWeatherDataDto.DailyDto.Date[6]).ToString(DAY_FORMAT);
                    */
                }
            }
            catch (Exception ex)
            {
                lblErrer.Text= ex.Message;
            }
        }

        /// <summary>
        /// アイコン合成
        /// </summary>
        /// <param name="icon1">メインアイコン名</param>
        /// <param name="icon2">重なるアイコン名</param>
        /// <param name="iconSize">アイコンの大きさ</param>
        /// <returns>アイコンイメージ</returns>
        private Bitmap IconComposition(string icon1, string icon2, Size iconSize)
        {
            // 表示アイコン
            Bitmap img1 = new Bitmap(ICON_PATH + icon1);
            Bitmap img2 = new Bitmap(ICON_PATH + icon2);
            img1.MakeTransparent(img1.GetPixel(0, 0));
            img2.MakeTransparent(img2.GetPixel(0, 0));
            
            // アイコン合成
            Graphics g = Graphics.FromImage(img1);
            g.DrawImage(img2, 0, 0, img2.Width, img2.Height);
            g.Dispose();
            img2.Dispose();

            return new Bitmap(img1, iconSize);
        }

        private void ViewTime()
        {
            //while (true)
            {
                // 時間更新
                Invoke(new LblTimeViewDelegate(SetTime));
            }
        }

        private void SetTime()
        {
            LblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
