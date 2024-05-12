using NewDarkBot.Classes;
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

    public partial class FormCommands : Form
    {
        private delegate void SafeCallDelegate(string text);

        public FormCommands()
        {
            InitializeComponent();
            GetPermissionList();
        }

        private void FormCommands_Load(object sender, EventArgs e)
        {
            t1.Columns.Add("CommandId").MaxLength = 3;
            t1.Columns.Add("CommandTxt").MaxLength = 25;
            t1.Columns.Add("CommandResponse");
            t1.Columns.Add("CommandCD").MaxLength = 3;
            t1.Columns.Add("CommandUCD").MaxLength = 3;
            t1.Columns.Add("IsTimer").MaxLength = 3;
            t1.Columns.Add("Letzte Ausführung").MaxLength = 12;
            t1.Columns.Add("Persission").MaxLength = 14;
            t1.Columns.Add("Intervall").MaxLength = 2;
            DataGridView1.ColumnHeadersVisible = false;
            
            
            Liste_laden();
        }
        public bool IsTimerBox;
        int Zeile;
        public DataTable t1 = new DataTable();
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
                    PermissionBox.Items.Add(sName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void DataGridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridView1 = sender as DataGridView;
            try
            {
                Zeile = DataGridView1.CurrentCell.RowIndex;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ein Fehler ist aufgetreten: " + ex.Message + " - " + ex.Source);
            }
            CommandId.Text = DataGridView1.Rows[Zeile].Cells[0].Value.ToString();
            CommandTxt.Text = DataGridView1.Rows[Zeile].Cells[1].Value.ToString();
            CommandResponse.Text = DataGridView1.Rows[Zeile].Cells[2].Value.ToString();
            CommandCD.Text = DataGridView1.Rows[Zeile].Cells[3].Value.ToString();
            CommandUCD.Text = DataGridView1.Rows[Zeile].Cells[4].Value.ToString();

            if (DataGridView1.Rows[Zeile].Cells[5].Value.ToString().ToLower() == "false")
            {
                IsTimer.Text = DataGridView1.Rows[Zeile].Cells[5].Value.ToString().ToLower();
                TimerNo.Checked = true;
                TimerYes.Checked = false;

            }
            else if (DataGridView1.Rows[Zeile].Cells[5].Value.ToString().ToLower() == "true")
            {
                IsTimer.Text = DataGridView1.Rows[Zeile].Cells[5].Value.ToString().ToLower();
                TimerYes.Checked = true;
                TimerNo.Checked = false;
            }
            LastCall.Text = DataGridView1.Rows[Zeile].Cells[6].Value.ToString();
            PermissionBox.SelectedItem = DataGridView1.Rows[Zeile].Cells[7].Value.ToString();
            TxtIntervall.Text = DataGridView1.Rows[Zeile].Cells[8].Value.ToString();
        }
        private void Liste_laden()
        {
            string cn_string = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            SqlConnection cn = new SqlConnection(cn_string);

            string sql_Text = "SELECT * FROM commands";

            SqlDataAdapter sql_adapt = new SqlDataAdapter(sql_Text, cn);

            DataTable dtCommands = new DataTable();

            sql_adapt.Fill(dtCommands);

            DataGridView1.DataSource = dtCommands;

        }
        private void AddCommand()
        {
            string new_Name = CommandTxt.Text;
            string new_Cooldown = CommandCD.Text;
            string new_Usercooldown = CommandUCD.Text;
            string new_Response = CommandResponse.Text;
            string new_Perm = PermissionBox.Text;
            string new_Intervall = TxtIntervall.Text;

            string sql_Text = "INSERT INTO commands (CommandTxt, CommandResponse, CommandCD, CommandUCD, IsTimer, LastCall, Permission, Intervall) VALUES" +
                "('" + new_Name + "', '" + new_Response + "', '" + new_Cooldown + "', '" + new_Usercooldown + "', '" + IsTimerBox + "', '" + DateTime.Now + "', '" + new_Perm + "', '" + new_Intervall + "')";

            Db_execute(sql_Text);
            Liste_laden();
        }
        private void RefreshCommand()
        {
            string RefreshId = CommandId.Text;
            string new_Name = CommandTxt.Text;
            string new_Cooldown = CommandCD.Text;
            string new_Usercooldown = CommandUCD.Text;
            string new_Response = CommandResponse.Text;
            string new_Perm = PermissionBox.Text;
            string new_Intervall = TxtIntervall.Text;

            string sql_Text = "UPDATE commands SET CommandTxt = '" + new_Name + "', CommandResponse = '" + new_Response + "', CommandCD = '" + new_Cooldown + "', CommandUCD = '" + new_Usercooldown + "', IsTimer = '" + IsTimerBox + "', LastCall = '" + DateTime.Now + "', Permission = '" + new_Perm + "', Intervall = '" + new_Intervall + "' WHERE CommandID = '" + RefreshId + "';";
            Db_execute(sql_Text);
            Liste_laden();
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
        private void DelCommand()
        {
            string DelItemId = CommandId.Text;
            string sql_Text = "DELETE FROM commands WHERE CommandId= " + DelItemId;
            Db_execute(sql_Text);
            Liste_laden();
        }
        private void BtnCommandAdd_Click(object sender, EventArgs e)
        {
            AddCommand();
        }

        private void BtnCommandDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Willst du das ausgewählte Command wirklich löschen?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    DelCommand();
                }
            }
            catch
            {
                throw;
            }

        }

        private void BtnCommandRefresh_Click(object sender, EventArgs e)
        {
            RefreshCommand();
        }
        private void TimerYes_CheckedChanged(object sender, EventArgs e)
        {
            IsTimerBox = true;
        }

        private void TimerNo_CheckedChanged(object sender, EventArgs e)
        {
            IsTimerBox = false;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
