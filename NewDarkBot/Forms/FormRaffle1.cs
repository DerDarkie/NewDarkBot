using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewDarkBot.Classes;
using TwitchLib.Client;
using TwitchLib.Client.Models;
using TwitchLib.Client.Events;
using System.Data.SqlClient;
using System.Configuration;
using NewDarkBot;

namespace NewDarkBot.Forms
{
    public partial class FormRaffle1 : Form
    {
        public FormRaffle1()
        {
            InitializeComponent();
            GetPermissionList();
        }
        private delegate void SafeCallDelegate(string text);
        public string RafUseCost;
        public string RafUseTicket;
        public string RafUseTimer;
        public string RafAktiv;
        public string RafUseArg1;
        public string RafUseArg2;
        public string RafUseArg3;
        public int rowIndex;
        int Zeile;
        public DataTable t4 = new DataTable();
        public TwitchClient client;
        private BotMainCore _maincore;
        public bool _isConnected;
        private void FormRaffle1_Load(object sender, EventArgs e)
        {
            if (!_isConnected)
            {
                _maincore = new BotMainCore();
                _maincore.Connected += SetOnlineStatus;
                _isConnected = false;
            }
            else
            {
                _isConnected = true;
            }
            
            t4.Columns.Add("Raf1Id").MaxLength = 3;
            t4.Columns.Add("Raf1Keyword").MaxLength = 10;
            t4.Columns.Add("Raf1Prize").MaxLength = 15;
            t4.Columns.Add("Raf1JoinPerm").MaxLength = 2;
            t4.Columns.Add("Raf1UseCosts").MaxLength = 2;
            t4.Columns.Add("Raf1UseTicketMax").MaxLength = 2;
            t4.Columns.Add("Raf1UseTimer").MaxLength = 2;
            t4.Columns.Add("Raf1TicketCost").MaxLength = 3;
            t4.Columns.Add("Raf1MxTicket").MaxLength = 3;
            t4.Columns.Add("RafAktiv").MaxLength = 2;
            t4.Columns.Add("Raf1TimeHH").MaxLength = 2;
            t4.Columns.Add("Raf1TimeMM").MaxLength = 2;
            t4.Columns.Add("Raf1UseArg1").MaxLength = 2;
            t4.Columns.Add("Raf1Winner").MaxLength = 10;
            t4.Columns.Add("Raf1State").MaxLength = 2;
            
            DataGridVorlagen.ColumnHeadersVisible = true;
            Liste_laden();
            Load_Joins1();
            IsRaffle();
           
        }
        private void SetOnlineStatus(bool status)
        {
            if (status)
            {
                _isConnected = true;
            }
            else
            {
                _isConnected = false;
            }
        }
        private void Liste_laden()
        {
            string cn_string = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            SqlConnection cn = new SqlConnection(cn_string);

            string sql_Text = @"SELECT * FROM raffle1";

            SqlDataAdapter sql_adapt = new SqlDataAdapter(sql_Text, cn);

            DataTable dtRaffle1 = new DataTable();

            sql_adapt.Fill(dtRaffle1);

            DataGridVorlagen.DataSource = dtRaffle1;

        }
        public DataTable t3 = new DataTable();
        
        public static int Raf1IdCheck { get; private set; }
        public static string Raf1StateCheck { get; private set; }
        public static string Raf1Prize { get; private set; }
        public static string Raf1Keyword { get; private set; }
        public static bool Raf1Active1 { get; private set; }
        public static string Raf1UseArg1 { get; private set; }
        public static bool Raf1UseArg { get; private set; }
        public int Zeile2 { get; private set; }

        public  void Load_Joins1()
        {
            string cn_string = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            string sql_Text = @"SELECT * FROM dbo.db_Joined1 ";
            SqlConnection cn = new SqlConnection(cn_string);
            SqlCommand cmd = new SqlCommand(sql_Text, cn);
            SqlDataReader Joinedreader;
            try
            {
                cmd.Connection.Open();
                Joinedreader = cmd.ExecuteReader();
                while (Joinedreader.Read())
                {
                    string sName = Joinedreader.GetString("JoinName");
                    
                    JoindListBox.Items.Add(sName);
                    JoindListBox.Refresh();
                    JoindListBox.SelectedIndex = 0;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void GetPermissionList()
        {
            string cn_string = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            string sql_Text = @"SELECT * FROM dbo.db_perm ";
            SqlConnection cn = new SqlConnection(cn_string);
            SqlCommand cmd = new SqlCommand(sql_Text, cn);
            SqlDataReader permreader;
            try
            {
                cmd.Connection.Open();
                permreader = cmd.ExecuteReader();
                while (permreader.Read())
                {
                    string sName = permreader.GetString("PermName");
                    int sValue = permreader.GetInt32("ident");
                    ComboPerm.Items.Add(sName);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void DataGridVorlagen_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridVorlagen = sender as DataGridView;
            try
            {
                Zeile = DataGridVorlagen.CurrentCell.RowIndex;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ein Fehler ist aufgetreten: " + ex.Message + " - " + ex.Source);
            }
            TxtId.Text = DataGridVorlagen.Rows[Zeile].Cells[0].Value.ToString();
            TxtKeyword.Text = DataGridVorlagen.Rows[Zeile].Cells[1].Value.ToString();
            TxtPrice.Text = DataGridVorlagen.Rows[Zeile].Cells[2].Value.ToString();
            ComboPerm.SelectedIndex = (int)DataGridVorlagen.Rows[Zeile].Cells[3].Value;
            if (DataGridVorlagen.Rows[Zeile].Cells[4].Value.ToString() == "false")
            {
                CheckTicketCost.Checked = false;
            }
            else if (DataGridVorlagen.Rows[Zeile].Cells[4].Value.ToString() == "true")
            {
                CheckTicketCost.Checked = true;
            }
            if (DataGridVorlagen.Rows[Zeile].Cells[5].Value.ToString() == "false")
            {
                CheckMaxTickets.Checked = false;
            }
            else if (DataGridVorlagen.Rows[Zeile].Cells[5].Value.ToString() == "true")
            {
                CheckMaxTickets.Checked = true;
            }
            if (DataGridVorlagen.Rows[Zeile].Cells[6].Value.ToString() == "false")
            {
                CheckTimer.Checked = false;
            }
            else if (DataGridVorlagen.Rows[Zeile].Cells[6].Value.ToString() == "true")
            {
                CheckTimer.Checked = true;
            }
            TxtTicketCost.Text = DataGridVorlagen.Rows[Zeile].Cells[7].Value.ToString();
            TxtMaxTickets.Text = DataGridVorlagen.Rows[Zeile].Cells[8].Value.ToString();
            if(DataGridVorlagen.Rows[Zeile].Cells[9].Value.ToString() == "1")
            {
                TxtAktiv.Text = DataGridVorlagen.Rows[Zeile].Cells[9].Value.ToString();
                BtnStart.Enabled = false;
                BtnStopEntries.Enabled = true;
                BtnPickWin.Enabled = false;
                BtnRemoveWinner.Enabled = false;
                BtnCloseRaffle1.Enabled = false;
            }
            else if(DataGridVorlagen.Rows[Zeile].Cells[9].Value.ToString() == "0")
            {
                TxtAktiv.Text = DataGridVorlagen.Rows[Zeile].Cells[9].Value.ToString();
                BtnStart.Enabled = true;
                BtnStopEntries.Enabled = false;
                BtnPickWin.Enabled = false;
                BtnRemoveWinner.Enabled = false;
                BtnCloseRaffle1.Enabled = false;
            }
            TxtSetTimeHH.Text = DataGridVorlagen.Rows[Zeile].Cells[10].Value.ToString();
            TxtSetTimeMM.Text = DataGridVorlagen.Rows[Zeile].Cells[11].Value.ToString();
            TrackTimeHH.Value = (int)DataGridVorlagen.Rows[Zeile].Cells[10].Value;
            TrackTimeMM.Value = (int)DataGridVorlagen.Rows[Zeile].Cells[11].Value;
            if (DataGridVorlagen.Rows[Zeile].Cells[12].Value.ToString() == "false")
            {
                CheckUseArg1.Checked = false;
            }
            else if (DataGridVorlagen.Rows[Zeile].Cells[12].Value.ToString() == "true")
            {
                CheckUseArg1.Checked = true;
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
        private void AddRaffleTemp()
        {
            string new_Keyword = TxtKeyword.Text;
            string new_RafCost = TxtTicketCost.Text;
            int new_JoinPerm = ComboPerm.SelectedIndex;
            string new_UseCost = RafUseCost;
            string new_UseTicket = RafUseTicket;
            string new_MaxTickets = TxtMaxTickets.Text;
            string new_UseTime = RafUseTimer;
            string new_TimeHH = TxtSetTimeHH.Text;
            string new_TimeMM = TxtSetTimeMM.Text;
            string new_Prize = TxtPrice.Text;
            string new_UseArg1 = RafUseArg1;
           
            string sql_Text = "INSERT INTO raffle1 (Raf1Keyword, Raf1Prize, Raf1JoinPerm, Raf1UseCosts, Raf1UseMaxTicket, Raf1UseTimer, Raf1TicketCost, Raf1MaxTicket, Raf1TimeHH, Raf1TimeMM, Raf1UseArg1) VALUES" +
                "('" + new_Keyword + "', '" + new_Prize + "', " + new_JoinPerm + ", '" + new_UseCost + "', '" + new_UseTicket + "', '" + new_UseTime + "', '" + new_RafCost + "', '" + new_MaxTickets + "', '" + new_TimeHH + "', '" + new_TimeMM + "', '" + new_UseArg1 + "')";

            Db_execute(sql_Text);
            Liste_laden();
        }
        
        private void RefreshRaffleTemp()
        {
            string RefreshTempId = TxtId.Text;
            string new_Keyword = TxtKeyword.Text;
            string new_RafCost = TxtTicketCost.Text;
            int new_JoinPerm = ComboPerm.SelectedIndex;
            string new_UseCost = RafUseCost;
            string new_UseTicket = RafUseTicket;
            string new_MaxTickets = TxtMaxTickets.Text;
            string new_UseTime = RafUseTimer;
            string new_TimeHH = TxtSetTimeHH.Text;
            string new_TimeMM = TxtSetTimeMM.Text;
            string new_Prize = TxtPrice.Text;
            string new_UseArg1 = RafUseArg1;
            string sql_Text = "UPDATE raffle1 SET Raf1Keyword = '" + new_Keyword + "', Raf1Prize = '" + new_Prize + "', Raf1JoinPerm = '" + new_JoinPerm + "', Raf1UseCosts = '" + new_UseCost + "', Raf1UseMaxTicket = '" + new_UseTicket + "', Raf1UseTimer = '" + new_UseTime + "', Raf1TicketCost = '" + new_RafCost + "', Raf1MaxTicket = '" + new_MaxTickets + "', Raf1TimeHH = '" + new_TimeHH + "', Raf1TimeMM = '" + new_TimeMM + "' , Raf1UseArg1 = '" + new_UseArg1 + "' WHERE Raf1Id = " + RefreshTempId;
            Db_execute(sql_Text);
            Liste_laden();
        }
        private void DelRaffleTemp()
        {
            string DelItemId = TxtId.Text;
            string sql_Text = "DELETE FROM raffle1 WHERE Raf1Id= " + DelItemId;
            Db_execute(sql_Text);
            Liste_laden();
        }
        private void CheckTicketCost_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckTicketCost.Checked)
            {
                RafUseCost = "true";
            }
            else if (!CheckTicketCost.Checked)
            {
                RafUseCost = "false";
            }
        }

        private void CheckMaxTickets_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckMaxTickets.Checked)
            {
                RafUseTicket = "true";
            }
            else if (!CheckMaxTickets.Checked)
            {
                RafUseTicket = "false";
            }
        }

        private void CheckTimer_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckTimer.Checked)
            {
                RafUseTimer = "true";
            }
            else if (!CheckTimer.Checked)
            {
                RafUseTimer = "false";
            }
        }
        private void CheckUseArg1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckUseArg1.Checked)
            {
                RafUseArg1 = "true";
            }
            else if (!CheckUseArg1.Checked)
            {
                RafUseArg1 = "false";
            }
        }
        private void BtnAddTemp_Click(object sender, EventArgs e)
        {
            AddRaffleTemp();
        }

        private void BtnRefreshTemp_Click(object sender, EventArgs e)
        {
            RefreshRaffleTemp();
        }

        private void BtnDelTemp_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Willst du die ausgewählte Vorlage wirklich löschen?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    DelRaffleTemp();
                }
            }
            catch
            {
                throw;
            }
        }
        private void TrackTimeHH_Scroll(object sender, EventArgs e)
        {
            TxtSetTimeHH.Text = "" + TrackTimeHH.Value;
        }

        private void TrackTimeMM_Scroll(object sender, EventArgs e)
        {
            TxtSetTimeMM.Text = "" + TrackTimeMM.Value;
        }

        private void BtnClearFields_Click(object sender, EventArgs e)
        {
            TxtId.Text = "";
            TxtKeyword.Text = "";
            TxtPrice.Text = "";
            ComboPerm.SelectedItem = 0;
            CheckTicketCost.Checked = false;
            CheckTimer.Checked = false;
            CheckMaxTickets.Checked = false;
            TxtTicketCost.Text = "";
            TxtMaxTickets.Text = "";
            TxtAktiv.Text = "";
            TxtSetTimeHH.Text = "";
            TxtSetTimeMM.Text = "";
            TrackTimeHH.Value = 0;
            TrackTimeMM.Value = 0;
            CheckUseArg1.Checked = false;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            
            if (!Raf1Active1)
            {
                string cn_string = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
                string sql_Text4 = @"SELECT * FROM raffle1 WHERE Raf1Aktiv = 1";
                SqlConnection cn = new SqlConnection(cn_string);
                SqlCommand cmd = new SqlCommand(sql_Text4, cn);
                SqlDataReader raf1reader;
                try
                {
                    cmd.Connection.Open();
                    raf1reader = cmd.ExecuteReader();
                    while (raf1reader.Read())
                    {
                        Raf1IdCheck = raf1reader.GetInt32("Raf1Id");
                        Raf1StateCheck = raf1reader.GetString("Raf1State");
                        if (Raf1IdCheck > 0)
                        {
                            Raf1Active1 = true;
                        }
                        else
                        {
                            Raf1Active1 = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                string new_status = "1";
                bool new_status2 = true;
                string sql_Text = "UPDATE raffle1 SET Raf1Aktiv = '" + new_status + "' Raf1State = '" + new_status2 + "' WHERE Raf1Id = " + Raf1IdCheck;
                Db_execute(sql_Text);
                Liste_laden();
                BtnStart.Enabled = false;
                BtnStopEntries.Enabled = true;
                BtnPickWin.Enabled = false;
                BtnRemoveWinner.Enabled = false;
                BtnCloseRaffle1.Enabled = false;
                
                string Raf1Prize = TxtPrice.Text;
                string Raf1Keyword = TxtKeyword.Text;
                if (CheckUseArg1.Checked)
                {
                    string msg = "Es wurde eine Verlosung gestartet! Zu gewinnen gibt es: " + Raf1Prize + " . Teilnahme mit: !" + Raf1Keyword + " Charaktername ServerName Fraktion (Angaben mit Leerzeichen trennen)";
                    _maincore.SendMsg(msg);
                }
                else
                {
                    string msg = "Es wurde eine Verlosung gestartet! Zu gewinnen gibt es: " + Raf1Prize + " . Teilnahme mit: !" + Raf1Keyword;
                    _maincore.SendMsg(msg);
                }
            }
            else if (Raf1Active1 && Raf1StateCheck == "false")
            {
                string cn_string = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
                string sql_Text4 = @"SELECT * FROM raffle1 WHERE Raf1Aktiv = 1";
                SqlConnection cn = new SqlConnection(cn_string);
                SqlCommand cmd = new SqlCommand(sql_Text4, cn);
                SqlDataReader raf1reader;
                try
                {
                    cmd.Connection.Open();
                    raf1reader = cmd.ExecuteReader();
                    while (raf1reader.Read())
                    {
                        Raf1IdCheck = raf1reader.GetInt32("Raf1Id");
                        Raf1StateCheck = raf1reader.GetString("Raf1State");
                        if (Raf1IdCheck > 0)
                        {
                            Raf1Active1 = true;
                        }
                        else
                        {
                            Raf1Active1 = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                bool new_status = true;
                string sql_Text2 = "UPDATE raffle1 SET Raf1State = '" + new_status + "' WHERE Raf1Id = " + Raf1IdCheck;
                Db_execute(sql_Text2);
                Liste_laden();
                BtnStart.Enabled = false;
                BtnStopEntries.Enabled = true;
                BtnPickWin.Enabled = false;
                BtnRemoveWinner.Enabled = false;
                BtnCloseRaffle1.Enabled = false;
            }
            else
            {
                string message = "Es läuft bereits ein Raffle. Du musst erst das Raffle beenden, bevor Du ein neues starten kannst";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
                return;
            }
        }
        public void IsRaffle()
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
                    Raf1IdCheck = raf1reader.GetInt32("Raf1Id");
                    Raf1StateCheck = raf1reader.GetString("Raf1State");
                    if(Raf1IdCheck > 0)
                    {
                        Raf1Active1 = true;
                    }
                    else
                    {
                        Raf1Active1 = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void JoindListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            JoindListBox.SelectedIndex = 0;
            string JN = JoindListBox.SelectedItem.ToString();
            string cn_string = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            string sql_Text = @"SELECT * FROM dbo.db_Joined1 WHERE JoinName = '" + JN + "';"; 
            SqlConnection cn = new SqlConnection(cn_string);
            SqlCommand cmd = new SqlCommand(sql_Text, cn);
            SqlDataReader Joinedreader;
            try
            {
                cmd.Connection.Open();
                Joinedreader = cmd.ExecuteReader();
                while (Joinedreader.Read())
                {
                    TxtJName.Text = Joinedreader.GetString("JoinName");
                    TxtArg1.Text = Joinedreader.GetString("Arg1");
                    TxtArg2.Text = Joinedreader.GetString("Arg2");
                    TxtArg3.Text = Joinedreader.GetString("Arg3");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnStopEntries_Click(object sender, EventArgs e)
        {
            if (Raf1Active1)
            {
                string cn_string = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
                string sql_Text2 = @"SELECT * FROM raffle1 WHERE Raf1Aktiv = 1";
                SqlConnection cn = new SqlConnection(cn_string);
                SqlCommand cmd = new SqlCommand(sql_Text2, cn);
                SqlDataReader raf1reader;
                try
                {
                    cmd.Connection.Open();
                    raf1reader = cmd.ExecuteReader();
                    while (raf1reader.Read())
                    {
                        Raf1IdCheck = raf1reader.GetInt32("Raf1Id");
                        Raf1StateCheck = raf1reader.GetString("Raf1State");
                        if (Raf1IdCheck > 0)
                        {
                            Raf1Active1 = true;
                        }
                        else
                        {
                            Raf1Active1 = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                bool new_status = false;
                string sql_Text = "UPDATE raffle1 SET Raf1State = '" + new_status + "' WHERE Raf1Id = " + Raf1IdCheck;
                Db_execute(sql_Text);
                Liste_laden();
                BtnStart.Enabled = true;
                BtnStopEntries.Enabled = false;
                BtnPickWin.Enabled = true;
                BtnRemoveWinner.Enabled = false;
                BtnCloseRaffle1.Enabled = false;
                
                string msg = "Die Verlosung von: " + Raf1Prize + " wurde geschlossen ! Keine Eintragung mehr möglich !";
                _maincore.SendMsg(msg);
            }
        }

        private void BtnPickWin_Click(object sender, EventArgs e)
        {
            
            if (Raf1Active1)
            {
                string cn_string = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
                string sql_Text3 = @"SELECT * FROM raffle1 WHERE Raf1Aktiv = 1";
                SqlConnection cn = new SqlConnection(cn_string);
                SqlCommand cmd = new SqlCommand(sql_Text3, cn);
                SqlDataReader raf1reader;
                try
                {
                    cmd.Connection.Open();
                    raf1reader = cmd.ExecuteReader();
                    while (raf1reader.Read())
                    {
                        Raf1IdCheck = raf1reader.GetInt32("Raf1Id");
                        Raf1StateCheck = raf1reader.GetString("Raf1State");
                        if (Raf1IdCheck > 0)
                        {
                            Raf1Active1 = true;
                        }
                        else
                        {
                            Raf1Active1 = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                string sql_Text = @"SELECT COUNT (*) FROM db_Joined1 WHERE RafId = " + Raf1IdCheck;
                
                SqlConnection con = new SqlConnection(cn_string);
                SqlCommand cmd2 = new SqlCommand(sql_Text, con);
                con.Open();
                int count = (int)cmd2.ExecuteScalar();
                con.Close();
                Liste_laden();
                BtnStart.Enabled = true;
                BtnStopEntries.Enabled = false;
                BtnPickWin.Enabled = false;
                BtnRemoveWinner.Enabled = true;
                BtnCloseRaffle1.Enabled = true;
                
                string message = "Es gibt" + count + "Einträge";
                string caption = "Info";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
                return;
            }

        }
    }
}
