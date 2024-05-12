using NewDarkBot.Classes;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NewDarkBot.Forms
{
    public partial class FormWoW : Form
    {
        public string ClientId;
        public string ApiSecret;

        private delegate void SafeCallDelegate(string text);
        public FormWoW()
        {
            InitializeComponent();
        }

        private void FormWoW_Load(object sender, EventArgs e)
        {
            TxtWoWApiClientId.Text = Settings.Default.wowapiclientid;
            TxtWoWApiSecret.Text = Settings.Default.wowapisecret;
            ClientId = Settings.Default.wowapiclientid;
            ApiSecret = Settings.Default.wowapisecret;
        }

        public string GetAccessToken(string ClientId,  string ApiSecret)
        {
            var client = new RestClient("https://eu.battle.net/oauth/token");
            var request = new RestRequest(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("content-type", "application / x - www - form - urlencode");
            request.AddParameter("application/x-www-urlencoded", $"grant_type=client_credentials&client_id={ClientId}&client_secret={ApiSecret}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            var tokenResponse = JsonConvert.DeserializeObject<AccessTokenResponse>(response.Content);
            return tokenResponse.Access_token;
        }
        public class AccessTokenResponse
        {
            public string Access_token { get; set; }
        }

    }
}
