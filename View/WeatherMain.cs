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

namespace Weather
{
    /// <summary>
    /// �V�C��񃁃C���N���X
    /// </summary>
    public partial class WeatherMain : Form
    {
        /// <summary>
        /// �R���X�g���N�^
        /// </summary>
        public WeatherMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// �A�v���P�[�V�������ŏ��ɓ������Ƃ��ɌĂ΂�郁�\�b�h
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void WeatherMainLoad(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            lblToday.Text = today.ToString("yyyy�NMM��dd��(ddd)");
            await this.JsonAsync();
        }

        /// <summary>
        /// �V�C�T�C�g����JSON�����擾����i���j
        /// </summary>
        /// <returns></returns>
        private async Task JsonAsync()
        {
        // URL�G���R�[�f�B���O
        // https://api.open-meteo.com/v1/forecast?latitude=52.52&longitude=13.41&current=temperature_2m,weather_code&hourly=temperature_2m&daily=weather_code,apparent_temperature_max,apparent_temperature_min&timezone=Asia%2FTokyo
        // https://api.open-meteo.com/v1/forecast?latitude=52.52&longitude=13.41&current=temperature_2m,precipitation,weather_code&hourly=temperature_2m,precipitation_probability&daily=weather_code,temperature_2m_max,temperature_2m_min,apparent_temperature_max,apparent_temperature_min,precipitation_probability_max&timezone=Asia%2FTokyo
            string url = "https://api.open-meteo.com/v1/forecast?latitude=35.00&longitude=135.00&current=temperature_2m,precipitation,weather_code&hourly=temperature_2m,precipitation_probability&daily=weather_code,temperature_2m_max,temperature_2m_min,apparent_temperature_max,apparent_temperature_min,precipitation_probability_max&timezone=Asia%2FTokyo";

            try
            {
                // Web����V�C�\��Json���擾����B
                HttpClient client = new();
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
                client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

                // �V�C�f�[�^��json�`���Ŏ󂯎��
                string weatherData = await client.GetStringAsync(url);
                JObject weatherDataObject = JObject.Parse(weatherData);

                // json�f�[�^���f�[�^�N���X�Ɋi�[����
                RawWeatherDataDto rawWeatherDataDto = JsonDataChange.JsonDataInClass(weatherDataObject);

                DatabaseAccess dba = new DatabaseAccess();
                this.lblCurrentWeathr.Text = dba.GetValue(rawWeatherDataDto.CurrentDto.WeatherCode);
                this.lblCurrentTemperature.Text = rawWeatherDataDto.CurrentDto.Temperature2m + rawWeatherDataDto.CurrentUnitsDto.Temperature2mUnit;
            }
            catch (Exception ex)
            {
                lblErrer.Text= ex.Message;
            }
        }
    }
}
