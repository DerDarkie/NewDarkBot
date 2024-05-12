using NewDarkBot.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.Win32;
using System.Diagnostics;
using System.Threading;

namespace NewDarkBot.Forms
{
    

    public partial class FormAccountManager : Form
    {
        public FormAccountManager()
        {
            InitializeComponent();
        }
        private void FormAccountManager_Load(object sender, EventArgs e)
        {
            string botname = Settings.Default.botname;
            BotName.Text = botname;
            string channel = Settings.Default.channel;
            Channel.Text = channel;
            string clientid = Settings.Default.clientid;
            ClientId.Text = clientid;
            string oauth = Settings.Default.oauth;
            Oauth.Text = oauth;
            string apiclientid = Settings.Default.apiclientid;
            APIClientId.Text = apiclientid;
            string apisecret = Settings.Default.apisecret;
            APISecret.Text = apisecret;
        }
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            Settings.Default.botname = BotName.Text;
            Settings.Default.channel = Channel.Text;
            Settings.Default.oauth = Oauth.Text;
            Settings.Default.clientid = ClientId.Text;
            Settings.Default.apiclientid = APIClientId.Text;
            Settings.Default.apisecret = APISecret.Text;
            Settings.Default.Save();
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            Settings.Default.botname = "";
            Settings.Default.channel = "";
            Settings.Default.oauth = "";
            Settings.Default.clientid = "";
            Settings.Default.apiclientid = "";
            Settings.Default.apisecret = ""; 
            Settings.Default.Save();
        }
        private void Link1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string browser = string.Empty;
            RegistryKey key = null;
            try
            {
                key = Registry.ClassesRoot.OpenSubKey(@"HTTP\shell\open\command");
                if (key != null)
                {
                    // Get default Browser
                    browser = key.GetValue(null).ToString().ToLower().Trim(new[] { '"' });
                }
                if (!browser.EndsWith("exe"))
                {
                    //Remove all after the ".exe"
                    browser = browser.Substring(0, browser.LastIndexOf(".exe", StringComparison.InvariantCultureIgnoreCase) + 4);
                }
            }
            finally
            {
                if (key != null)
                {
                    key.Close();
                }
            }
            // Open the browser.
            Process proc = Process.Start(browser, "https://twitchtokengenerator.com/");
            if (proc != null)
            {
                Thread.Sleep(5000);
                // Close the browser.
            }
        }
    }
}
