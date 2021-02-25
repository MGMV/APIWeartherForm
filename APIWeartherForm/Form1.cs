using Dadata;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APIWeartherForm
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void weather(Geo geo)
        {
            string url = @"https://api.weather.yandex.ru/v2/forecast?";
            url += "lat=" + geo.geo_lat;
            url += "&lon=" + geo.geo_lon;
            groupBox1.Name = geo.name;


            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Headers.Add("X-Yandex-API-Key:53784e43-078c-4410-b236-190616cd4a9e");
            WebResponse webResponse = webRequest.GetResponse();
            Stream stream = webResponse.GetResponseStream();
            StreamReader sr = new StreamReader(stream);
            string s = sr.ReadToEnd();
            var sss = JObject.Parse(s);

            string name = sss["geo_object"]["locality"]["name"].ToString();
            int temp = Int32.Parse(sss["fact"]["temp"].ToString());
            int feels_like = Int32.Parse(sss["fact"]["feels_like"].ToString());

            groupBox1.Text = name;

            Temptxt.Text = "Температура: " + temp.ToString();
            feelsLikeTxt.Text = "Ощущается: " + feels_like.ToString();
        }

        private async Task asdAsync()
        {

            // https://github.com/hflabs/dadata-csharp

            var token = "8550db05a079b0fbcb6468f69798b93896aa7887";
            var api = new SuggestClientAsync(token);
            var result = await api.SuggestAddress(comboBox1.Text);
            string str = "";
            comboBox1.Items.Add(result.suggestions[0].value);
            if (comboBox1.Items.Count > 1)
                comboBox1.Items.RemoveAt(0);

        }

        private async Task<Geo> asdAsyncGeo()
        {

            // https://github.com/hflabs/dadata-csharp

            var token = "8550db05a079b0fbcb6468f69798b93896aa7887";
            var api = new SuggestClientAsync(token);
            var result = await api.SuggestAddress(comboBox1.Text);
            string str = "";
            Geo geo = new Geo();
            geo.name = result.suggestions[0].value;
            geo.geo_lon = result.suggestions[0].data.geo_lon;
            geo.geo_lat = result.suggestions[0].data.geo_lat;
            return geo;
        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            asdAsync();
        }

        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Geo geo = await asdAsyncGeo();
            weather(geo);

        }
    }
    public class Geo
    { 
        public string name { get; set; }
        public string geo_lat { get; set; }
        public string geo_lon { get; set; }
    }
}
