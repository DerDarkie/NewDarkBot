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

namespace NewDarkBot.Forms
{
    public partial class FormRaffle2 : Form
    {
        public FormRaffle2()
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

        int Zeile;

        public DataTable t4 = new DataTable();

        private void FormRaffle2_Load(object sender, EventArgs e)
        {
            t4.Columns.Add("Raf2Id");
            t4.Columns.Add("Raf2Keyword");
            t4.Columns.Add("Raf2Prize");
            t4.Columns.Add("Raf2JoinPerm");
            t4.Columns.Add("Raf2UseCosts");
            t4.Columns.Add("Raf2UseTicketMax");
            t4.Columns.Add("Raf2UseTimer");
            t4.Columns.Add("Raf2TicketCost");
            t4.Columns.Add("Raf2MxTicket");
            t4.Columns.Add("Raf2Aktiv");
            t4.Columns.Add("Raf2TimeHH");
            t4.Columns.Add("Raf2TimeMM");
            t4.Columns.Add("Raf2UseArg1");
            t4.Columns.Add("Raf2Arg1");
            t4.Columns.Add("Raf2Arg1Desc");
            t4.Columns.Add("Raf2UseArg2");
            t4.Columns.Add("Raf2Arg2");
            t4.Columns.Add("Raf2Arg2Desc");
            t4.Columns.Add("Raf2UseArg3");
            t4.Columns.Add("Raf2Arg3");
            t4.Columns.Add("Raf2Arg3Desc");
            DataGridVorlagen.ColumnHeadersVisible = false;
            Liste_laden();
            Load_Joins2();
        }


        private void Liste_laden()
        {
            string cn_string = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            SqlConnection cn = new SqlConnection(cn_string);

            string sql_Text = @"SELECT * FROM raffle2";

            SqlDataAdapter sql_adapt = new SqlDataAdapter(sql_Text, cn);

            DataTable dtRaffle2 = new DataTable();

            sql_adapt.Fill(dtRaffle2);

            DataGridVorlagen.DataSource = dtRaffle2;

        }
        public DataTable t3 = new DataTable();
        public void Load_Joins2()
        {
            string cn_string = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            string sql_Text = @"SELECT * FROM dbo.db_Joined2 ";
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
                    JoindListBox.SelectedIndex = JoindListBox.Items.Count - 1;
                    JoindListBox.SelectedIndex = -1;
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
            TextPrice.Text = DataGridVorlagen.Rows[Zeile].Cells[2].Value.ToString();
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
            TxtAktiv.Text = DataGridVorlagen.Rows[Zeile].Cells[9].Value.ToString();
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
            IdentiferArg1.Text = DataGridVorlagen.Rows[Zeile].Cells[13].Value.ToString();
            TxtArg1Descri.Text = DataGridVorlagen.Rows[Zeile].Cells[14].Value.ToString();
            if (DataGridVorlagen.Rows[Zeile].Cells[15].Value.ToString() == "false")
            {
                CheckUseArg2.Checked = false;
            }
            else if (DataGridVorlagen.Rows[Zeile].Cells[15].Value.ToString() == "true")
            {
                CheckUseArg2.Checked = true;
            }
            IdentiferArg2.Text = DataGridVorlagen.Rows[Zeile].Cells[16].Value.ToString();
            TxtArg2Descri.Text = DataGridVorlagen.Rows[Zeile].Cells[17].Value.ToString();
            if (DataGridVorlagen.Rows[Zeile].Cells[18].Value.ToString() == "false")
            {
                CheckUseArg3.Checked = false;
            }
            else if (DataGridVorlagen.Rows[Zeile].Cells[18].Value.ToString() == "true")
            {
                CheckUseArg3.Checked = true;
            }
            IdentiferArg3.Text = DataGridVorlagen.Rows[Zeile].Cells[19].Value.ToString();
            TxtArg3Descri.Text = DataGridVorlagen.Rows[Zeile].Cells[20].Value.ToString();
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
            string new_Prize = TextPrice.Text;
            string new_UseArg1 = RafUseArg1;
            string new_Arg1 = IdentiferArg1.Text;
            string new_Arg1Des = TxtArg1Descri.Text;
            string new_UseArg2 = RafUseArg2;
            string new_Arg2 = IdentiferArg2.Text;
            string new_Arg2Des = TxtArg2Descri.Text;
            string new_UseArg3 = RafUseArg3;
            string new_Arg3 = IdentiferArg3.Text;
            string new_Arg3Des = TxtArg3Descri.Text;

            string sql_Text = "INSERT INTO raffle2 (Raf2Keyword, Raf2Prize, Raf2JoinPerm, Raf2UseCosts, Raf2UseMaxTicket, Raf2UseTimer, Raf2TicketCost, Raf2MaxTicket, Raf2TimeHH, Raf2TimeMM, Raf2UseArg1, Raf2Arg1, Raf2Arg1Descri, Raf2UseArg2, Raf2Arg2, Raf2Arg2Descri, Raf2UseArg3, Raf2Arg3, Raf2Arg3Descri,) VALUES" +
                "('" + new_Keyword + "', '" + new_Prize + "', " + new_JoinPerm + ", '" + new_UseCost + "', '" + new_UseTicket + "', '" + new_UseTime + "', '" + new_RafCost + "', '" + new_MaxTickets + "', '" + new_TimeHH + "', '" + new_TimeMM + "', '" + new_UseArg1 + "', '" + new_Arg1 + "', '" + new_Arg1Des + "', '" + new_UseArg2 + "', '" + new_Arg2 + "', '" + new_Arg2Des + "', '" + new_UseArg3 + "', '" + new_Arg3 + "', '" + new_Arg3Des + "')";

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
            string new_Prize = TextPrice.Text;
            string new_UseArg1 = RafUseArg1;
            string new_Arg1 = IdentiferArg1.Text;
            string new_Arg1Des = TxtArg1Descri.Text;
            string new_UseArg2 = RafUseArg2;
            string new_Arg2 = IdentiferArg2.Text;
            string new_Arg2Des = TxtArg2Descri.Text;
            string new_UseArg3 = RafUseArg3;
            string new_Arg3 = IdentiferArg3.Text;
            string new_Arg3Des = TxtArg3Descri.Text;

            string sql_Text = "UPDATE raffle2 SET Raf2Keyword = '" + new_Keyword + "', Raf2Prize = '" + new_Prize + "', Raf2JoinPerm = '" + new_JoinPerm + "', Raf2UseCosts = '" + new_UseCost + "', Raf2UseMaxTicket = '" + new_UseTicket + "', Raf2UseTimer = '" + new_UseTime + "', Raf2TicketCost = '" + new_RafCost + "', Raf2MaxTicket = '" + new_MaxTickets + "', Raf2TimeHH = '" + new_TimeHH + "', Raf2TimeMM = '" + new_TimeMM + "' , Raf2UseArg1 = '" + new_UseArg1 + "', Raf2Arg1 = '" + new_Arg1 + "', Raf2Arg1Descri = '" + new_Arg1Des + "', Raf2UseArg2 = '" + new_UseArg2 + "', Raf2Arg2 = '" + new_Arg2 + "', Raf2Arg2Descri = '" + new_Arg2Des + "', Raf2UseArg3 = '" + new_UseArg3 + "', Raf2Arg3 = '" + new_Arg3 + "', Raf2Arg3Descri = '" + new_Arg3Des + "' WHERE Raf2Id = '" + RefreshTempId + "';";
            Db_execute(sql_Text);
            Liste_laden();
        }
        private void DelRaffleTemp()
        {
            string DelItemId = TxtId.Text;
            string sql_Text = "DELETE FROM raffle2 WHERE Raf2Id= " + DelItemId;
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

        private void CheckUseArg2_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckUseArg2.Checked)
            {
                RafUseArg2 = "true";
            }
            else if (!CheckUseArg2.Checked)
            {
                RafUseArg2 = "false";
            }
        }

        private void CheckUseArg3_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckUseArg3.Checked)
            {
                RafUseArg3 = "true";
            }
            else if (!CheckUseArg3.Checked)
            {
                RafUseArg3 = "false";
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
            TextPrice.Text = "";
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
            CheckUseArg2.Checked = false;
            CheckUseArg3.Checked = false;
            IdentiferArg1.Text = "#";
            TxtArg1Descri.Text = "";
            IdentiferArg2.Text = "*";
            TxtArg2Descri.Text = "";
            IdentiferArg3.Text = "$";
            TxtArg3Descri.Text = "";

        }
    }
}