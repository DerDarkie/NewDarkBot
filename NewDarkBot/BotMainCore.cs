using System;
using TwitchLib.Client;
using TwitchLib.Client.Models;
using TwitchLib.Client.Events;
using TwitchLib.Api;
using TwitchLib.Api.Core;
using TwitchLib.Api.Events;
using TwitchLib.Api.Helix;
using TwitchLib.Api.Helix.Models;
using TwitchLib.Api.Helpers;
using TwitchLib.Api.Interfaces;
using TwitchLib.Api.Services;
using TwitchLib.Api.Services.Events;
using TwitchLib.Api.ThirdParty.ModLookup;
using TwitchLib.Api.V5.Models;
using TwitchLib.Api.V5.Models.Users;
using TwitchLib.Client.Extensions;
using TwitchLib.Client.Enums.Internal;
using TwitchLib.Communication.Events;
using TwitchLib.Communication.Clients;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using NewDarkBot.Classes;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using NewDarkBot.Forms;
using System.Linq;

namespace NewDarkBot
{
    class BotMainCore
    {
        public string pongmsg = "PONG :tmi.twitch.tv";
        public Action<bool> Connected;
        public Action<string> LogTxt;
        public Action<string> ChatText;
        public Action<string> ViewerText;
        public Action<string> ViewerText2;
        public string _userName;
        public string _displayname;
        public string _username;
        public string _cmdtxt;
        public int CmdP { get; set; }
        public int UserP { get; set; }
        public static TwitchClient client;
        public string UserColor { get; set; }
        public string ChatTextListBox { get; set; }
        public string ViewerTextListBox { get; set; }
        public int Raf1Id { get; set; }
        public int Raf2Id { get; set; }
        public int Raf1On { get; set; }
        public int Raf2On { get; set; }
        public string RafKey1 { get; set; }
        public string Raf1Prize { get; private set; }
        public string Raf1UseArg1 { get; private set; }
        public bool Raf1UseArg { get; private set; }
        public bool Raf2UseArg { get; private set; }
        public string Raf1Arg1 { get; private set; }
        public string Raf1Arg2 { get; private set; }
        public string Raf1Arg3 { get; private set; }
        public string Raf2Prize { get; private set; }
        public string RafKey2 { get; set; }
        public string Raf2UseArg1 { get; private set; }
        public string Raf2Arg1 { get; private set; }
        public string Raf2Arg2 { get; private set; }
        public string Raf2Arg3 { get; private set; }
        public bool RafActive1 { get; private set; }
        public bool RafActive2 { get; private set; }
        public bool Missing_Arg1 { get; private set; }
        
        private delegate void SafeCallDelegate(string text);
        public ConnectionCredentials creds = new ConnectionCredentials(Settings.Default.botname, Settings.Default.oauth);
        
        private string sName;

        public string Raf1Keyword { get; private set; }
        public string Raf2Keyword { get; private set; }
        public bool Missing_Arg2 { get; private set; }

        
        private string _Arg1;
        private string _Arg3;
        private string _Arg2;
        private string _2Arg1;
        private string _2Arg2;
        private string _2Arg3;
        private bool _isConnected;

        public void Connect(bool isLogging)
        {
            client = new TwitchClient();
            client.Initialize(creds, Settings.Default.channel);
            client.OnConnectionError += Client_OnConnectionError;
            client.OnConnected += Client_OnConnected;
            client.OnChatCommandReceived += Client_OnChatCommandReceived;
            client.OnMessageReceived += Client_OnMessageReceived;
            client.OnUserJoined += Client_OnUserJoind;
            client.OnUserLeft += Client_OnUserLeft;
            
            if (isLogging)
            {
                client.OnLog += Client_OnLog;
            }
            client.Connect();
            client.SendRaw("CAP REQ :twitch.tv/membership");
            client.SendRaw("CAP REQ :twitch.tv/tags");
            client.SendRaw("CAP REQ :twitch.tv/commands");
            
        }
        
        private void Client_OnMessageReceived(object sender, OnMessageReceivedArgs e)
        {
            if (e.ChatMessage.Message.Contains("PING :tmi.twitch.tv"))
            {
                SendPong(pongmsg);
            }
            ChatText?.Invoke($"{DateTime.Now} - {e.ChatMessage.DisplayName}: {e.ChatMessage.Message}");
            _displayname = e.ChatMessage.DisplayName.ToString();
            _userName = e.ChatMessage.Username;
            
            CheckRaf1Aktiv();
            CheckRaf2Aktiv();
            if (RafActive1)
            {
                if (e.ChatMessage.Message.Contains("!" + RafKey1))
                {
                    
                    string cn_string = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
                    string sql_Text = @"SELECT * FROM dbo.db_Joined1 WHERE JoinName =   '" + _displayname + "'";
                    SqlConnection cn = new SqlConnection(cn_string);
                    SqlCommand cmd = new SqlCommand(sql_Text, cn);
                    SqlDataReader Joinedreader;
                    try
                    {
                        cmd.Connection.Open();
                        Joinedreader = cmd.ExecuteReader();
                        while (Joinedreader.Read())
                        {
                            sName = Joinedreader.GetString("JoinName").ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    if (sName != _displayname)
                    {
                        if (Raf1UseArg)
                         {
                            string [] subs = e.ChatMessage.Message.Split(null, 4);
                            var totalElements = subs.Count();
                            if (totalElements == 4)
                            {
                                _Arg1 = subs[1];
                                _Arg2 = subs[2];
                                _Arg3 = subs[3];
                                Missing_Arg1 = false;
                            }
                            else
                            {
                                Missing_Arg1 = true;
                            }
                            if (Missing_Arg1)
                            {
                                string msg = _displayname + ", Du hast die DREI benötigtem Angaben nicht mit eingegeben. Charaktername ServerName Fraktion (Angaben mit Leerzeichen trennen)";
                                SendMsg(msg);
                                return;
                            }
                            else
                            {
                                string sql_Text2 = @"INSERT INTO dbo.db_Joined1 (RafId, JoinName, Arg1, Arg2, Arg3) VALUES ('" + Raf1Id + "', '" + _displayname + "', '" + _Arg1.Replace("'", "''") + "', '" + _Arg2.Replace("'", "''") + "', '" + _Arg3.Replace("'", "''") + "')";
                                Db_execute(sql_Text2);
                                string msg = _displayname + ", Du nimmst nun an der Verlosung von " + Raf1Prize + " teil. Viel Glück !! Dein Char: " + _Arg1 + " - " + _Arg2 + " - " + _Arg3 + " wurde eingetragen.";
                                SendMsg(msg);
                               
                            }
                        }
                        else
                        {
                            string sql_Text2 = @"INSERT INTO dbo.db_Joined1 (RafId, JoinName) VALUES ('" + Raf1Id + "', '" + _displayname + "')";
                            Db_execute(sql_Text2);
                            string msg = _displayname + ", Du nimmst nun an der Verlosung von " + Raf1Prize + " teil. Viel Glück !! ";
                            SendMsg(msg);
                            
                        }
                       
                    }
                    else
                    {
                        string msg = _displayname + ", Du bist für diese Verlosung bereits eingetragen, Viel Glück!! ";
                        SendMsg(msg);
                    }
                }
            }
            if (RafActive2)
            {
                if (e.ChatMessage.Message.Contains("!" + RafKey2))
                {
                    
                    string cn_string = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
                    string sql_Text = @"SELECT * FROM dbo.db_Joined2 WHERE JoinName =   '" + _displayname + "'";
                    SqlConnection cn = new SqlConnection(cn_string);
                    SqlCommand cmd = new SqlCommand(sql_Text, cn);
                    SqlDataReader Joinedreader2;
                    try
                    {
                        cmd.Connection.Open();
                        Joinedreader2 = cmd.ExecuteReader();
                        while (Joinedreader2.Read())
                        {
                            sName = Joinedreader2.GetString("JoinName").ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    if (sName != _displayname)
                    {
                        if (Raf2UseArg)
                        {
                            string[] subs = e.ChatMessage.Message.Split(null, 4);
                            var totalElements = subs.Count();
                            if (totalElements == 4)
                            {
                                _2Arg1 = subs[1];
                                _2Arg2 = subs[2];
                                _2Arg3 = subs[3];
                                Missing_Arg2 = false;
                            }
                            else
                            {
                                Missing_Arg2 = true;
                            }
                            if (Missing_Arg2)
                            {
                                string msg = _displayname + ", Du hast die DREI benötigtem Angaben nicht mit eingegeben. Charaktername ServerName Fraktion (Angaben mit Leerzeichen trennen)";
                                SendMsg(msg);
                                return;
                            }
                            else
                            {
                                string sql_Text2 = @"INSERT INTO dbo.db_Joined2 (RafId, JoinName, Arg1, Arg2, Arg3) VALUES ('" + Raf2Id + "', '" + _displayname + "', '" + _2Arg1.Replace("'", "''") + "', '" + _2Arg2.Replace("'", "''") + "', '" + _2Arg3.Replace("'", "''") + "')";
                                Db_execute(sql_Text2);
                                string msg = _displayname + ", Du nimmst nun an der Verlosung von " + Raf2Prize + " teil. Viel Glück !! Dein Char:" + _2Arg1 + " - " + _2Arg2 + " - " + _2Arg3 + " wurde eingetragen.";
                                SendMsg(msg);
                                
                            }
                            
                        }
                        else
                        {
                            string sql_Text2 = @"INSERT INTO dbo.db_Joined2 (RafId, JoinName) VALUES ('" + Raf2Id + "', '" + _displayname + "')";
                            Db_execute(sql_Text2);
                            string msg = _displayname + ", Du nimmst nun an der Verlosung von " + Raf2Prize + " teil. Viel Glück !! ";
                            SendMsg(msg);
                            
                        }
                        
                    }
                    else
                    {
                        string msg = _displayname + ", Du bist für diese Verlosung bereits eingetragen, Viel Glück!! ";
                        SendMsg(msg);
                    }
                }
            }


        }
        private int Db_execute(string sql_Text)
        {
            string cn_string = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            SqlConnection cn = new SqlConnection(cn_string);

            SqlCommand cmd = new SqlCommand(sql_Text, cn);
            cmd.Connection.Open();
            int nResult = cmd.ExecuteNonQuery();

            return nResult;
        }
        public void CheckRaf1Aktiv()
        {
            string cn_string = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            string sql_Text = @"SELECT * FROM raffle1 WHERE Raf1Aktiv = 1";
            SqlConnection cn = new SqlConnection(cn_string);
            SqlCommand cmd = new SqlCommand(sql_Text, cn);
            SqlDataReader raf1reader;
            try
            {
                cmd.Connection.Open();
                raf1reader = cmd.ExecuteReader();
                while (raf1reader.Read())
                {
                    Raf1Id = raf1reader.GetInt32("Raf1Id");
                    RafKey1 = raf1reader.GetString("Raf1Keyword");
                    Raf1Prize = raf1reader.GetString("Raf1Prize");
                    Raf1UseArg1 = raf1reader.GetString("Raf1UseArg1");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (Raf1Id > 0)
            {
                RafActive1 = true;
            }
            else
            {
                RafActive1 = false;
            }
            if (Raf1UseArg1 == "true")
            {
                Raf1UseArg = true;
            }
            else
            {
                Raf1UseArg = false;
            }
        }
        private void CheckRaf2Aktiv()
        {
            string cn_string = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            string sql_Text = @"SELECT * FROM raffle2 WHERE Raf2Aktiv = 1";
            SqlConnection cn = new SqlConnection(cn_string);
            SqlCommand cmd = new SqlCommand(sql_Text, cn);
            SqlDataReader raf2reader;
            try
            {
                cmd.Connection.Open();
                raf2reader = cmd.ExecuteReader();
                while (raf2reader.Read())
                {
                    Raf2Id = raf2reader.GetInt32("Raf2Id");
                    RafKey2 = raf2reader.GetString("Raf2Keyword");
                    Raf2Prize = raf2reader.GetString("Raf2Prize");
                    Raf2UseArg1 = raf2reader.GetString("Raf2UseArg1");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (Raf2Id > 0)
            {
                RafActive2 = true;
            }
            else
            {
                RafActive2 = false;
            }
            if (Raf2UseArg1 == "true")
            {
                Raf2UseArg = true;
            }
            else
            {
                Raf2UseArg = false;
            }
        }
        private void Client_OnChatCommandReceived(object sender, OnChatCommandReceivedArgs e)
        {
            _cmdtxt = e.Command.CommandText.ToString();
            _username = e.Command.ChatMessage.Username.ToString();
            string cn_string = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            string sql_Text = @"SELECT * FROM db_user WHERE DisplayName = '" + _username + "'";
            SqlConnection cn = new SqlConnection(cn_string);
            SqlCommand cmd = new SqlCommand(sql_Text, cn);
            SqlDataReader userreader;
            try
            {
                cmd.Connection.Open();
                userreader = cmd.ExecuteReader();
                while (userreader.Read())
                {
                    UserP = userreader.GetInt32("BotPerm");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string sql_Text2 = @"SELECT * FROM commands WHERE CommandTxt = '" + _cmdtxt + "'";
            SqlConnection cn2 = new SqlConnection(cn_string);
            SqlCommand cmd2 = new SqlCommand(sql_Text2, cn2);
            SqlDataReader cmdreader;
            try
            {
                cmd2.Connection.Open();
                cmdreader = cmd2.ExecuteReader();
                while (cmdreader.Read())
                {
                    string ResponseTxt = cmdreader.GetString("CommandResponse");
                    string CmdPerm = cmdreader.GetString("Permission");

                    switch(CmdPerm)
                    {
                        case "Everybody":
                                CmdP = 0;
                            break;
                        case "Regular":
                                CmdP = 1;
                            break;
                        case "Subscriber":
                            CmdP = 2;
                            break;
                        case "Editor":
                            CmdP = 3;
                            break;
                        case "Moderator":
                            CmdP = 4;
                            break;
                    }
                    if (UserP >= CmdP)
                    {
                        string Response = ResponseTxt;
                        SendMsg(Response);
                    }
                    else
                    {
                        string Error = "Dir fehlt leider die Berechtigung für dieses Command, " + _username;
                        SendMsg(Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Client_OnUserJoind(object sender, OnUserJoinedArgs e)
        {
            _userName = e.Username;
            
            ViewerText?.Invoke($"{_userName}");

            //User checken
            string cn_string = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            SqlConnection connection = new SqlConnection(cn_string);
            string query = @"SELECT Username FROM db_user WHERE Username = '" + _userName + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                connection.Open();
                string update_query = @"UPDATE db_user SET LastOnline = '" + DateTime.Now + "' WHERE Username = '" + _userName + "';";
                SqlCommand cmd = new SqlCommand(update_query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            else
            {
                connection.Open();
                string insert_query = @"INSERT INTO db_user (Username, LastOnline) VALUES ('" + _userName + "', '" + DateTime.Now + "');";
                SqlCommand cmd = new SqlCommand(insert_query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        private void Client_OnUserLeft(object sender, OnUserLeftArgs e)
        {
            ViewerText2?.Invoke($"{ e.Username}");
        }
        private void Client_OnConnected(object sender, OnConnectedArgs e)
        {
            Connected?.Invoke(true);
            _isConnected = true;
        }
        private void Client_OnLog(object sender, OnLogArgs e)
        {
            LogTxt?.Invoke(e.Data);
        }
        private void Client_OnConnectionError(object sender, OnConnectionErrorArgs e)
        {
            string message = "Es konnte keine Verbindung aufgebaut werden. Überprüfe deinen Internetverbindung";
            string caption = "Error";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);
            return;
        }
        internal void Disconnect()
            {
                Connected?.Invoke(false);
                client.Disconnect();
                _isConnected = false;
            }
        public void SendMsg(string msg)
        {
            if (_isConnected)
            {
                if (msg != null)
                {
                    client.SendMessage(Settings.Default.channel, msg);
                    ChatText?.Invoke($"{DateTime.Now} -  {msg}");
                }
            }
            else
            {
                string message = "Bot ist nicht Online !.";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
                return;
            }
        }
        public void SendPong(string pongmsg)
        {
            client.SendRaw(pongmsg);
        }
    }
}
