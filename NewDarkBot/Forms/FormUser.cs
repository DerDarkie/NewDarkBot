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
using MySql.Data.MySqlClient;

namespace NewDarkBot.Forms
{
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
            GetPermissionList();
        }
        private void GetPermissionList()
        {
            string cn_string = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            string sql_Text = @"SELECT * FROM db_perm ";
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
                    PermissionBox2.Items.Add(sName);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        
        private void FormUser_Load(object sender, EventArgs e)
        {
            t2.Columns.Add("UserID");
            t2.Columns.Add("Username");
            t2.Columns.Add("DisplayName");
            t2.Columns.Add("Currency");
            t2.Columns.Add("Zuletzt Online");
            t2.Columns.Add("IsFollow");
            t2.Columns.Add("IsSub");
            t2.Columns.Add("IsVip");
            t2.Columns.Add("BotPerm");
            UserGridView.ColumnHeadersVisible = false;
            
            Liste_laden();
        }
        int Zeile;
        public DataTable t2 = new DataTable();



        private void Liste_laden()
        {
            string cn_string = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            SqlConnection cn = new SqlConnection(cn_string);

            string sql_Text = "SELECT * FROM db_user";

            SqlDataAdapter sql_adapt = new SqlDataAdapter(sql_Text, cn);

            DataTable dtUser = new DataTable();

            sql_adapt.Fill(dtUser);

            UserGridView.DataSource = dtUser;
           

        }
        private void UserGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserGridView = sender as DataGridView;
            try
            {
                Zeile = UserGridView.CurrentCell.RowIndex;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ein Fehler ist aufgetreten: " + ex.Message + " - " + ex.Source);
            }
            TxtUserId.Text = UserGridView.Rows[Zeile].Cells[0].Value.ToString();
            TxtUserName.Text = UserGridView.Rows[Zeile].Cells[1].Value.ToString();
            TxtDisplayName.Text = UserGridView.Rows[Zeile].Cells[2].Value.ToString();
            TxtPoints.Text = UserGridView.Rows[Zeile].Cells[3].Value.ToString();
            TxtDate.Text = UserGridView.Rows[Zeile].Cells[4].Value.ToString();
            string FollowTxt = UserGridView.Rows[Zeile].Cells[5].Value.ToString();
            switch(FollowTxt)
            {
                case "1":
                    TxtFollower.BackColor = Color.Green;
                    TxtFollower.Text = "JA";
                    break;
                case "0":
                    TxtFollower.BackColor = Color.Red;
                    TxtFollower.Text = "NEIN";
                    break;
            }
            string SubTxt = UserGridView.Rows[Zeile].Cells[6].Value.ToString();
            switch (SubTxt)
            {
                case "1":
                    TxtSubscriber.BackColor = Color.Green;
                    TxtSubscriber.Text = "JA";
                    break;
                case "0":
                    TxtSubscriber.BackColor = Color.Red;
                    TxtSubscriber.Text = "NEIN";
                    break;
            }
            string VipTxt = UserGridView.Rows[Zeile].Cells[7].Value.ToString();
            switch (VipTxt)
            {
                case "1":
                    TxtVip.BackColor = Color.Green;
                    TxtVip.Text = "JA";
                    break;
                case "0":
                    TxtVip.BackColor = Color.Red;
                    TxtVip.Text = "NEIN";
                    break;
            }
            string BoxIndex = UserGridView.Rows[Zeile].Cells[8].Value.ToString();
            switch(BoxIndex)
            {
                case "0":
                    PermissionBox2.SelectedIndex = 0;
                    break;
                case "1":
                    PermissionBox2.SelectedIndex = 1;
                    break;
                case "2":
                    PermissionBox2.SelectedIndex = 2;
                    break;
                case "3":
                    PermissionBox2.SelectedIndex = 3;
                    break;
                case "4":
                    PermissionBox2.SelectedIndex = 4;
                    break;
            }
            string IsModTxt = UserGridView.Rows[Zeile].Cells[9].Value.ToString();
            switch (IsModTxt)
            {
                case "1":
                    TxtIsMod.BackColor = Color.Green;
                    TxtIsMod.Text = "JA";
                    break;
                case "0":
                    TxtIsMod.BackColor = Color.Red;
                    TxtIsMod.Text = "NEIN";
                    break;
            }
        }

        private void RefreshUser()
        {
            string RefreshId = TxtUserId.Text;
            string new_Name = TxtUserName.Text;
            string new_DisplayName = TxtDisplayName.Text;
            string new_Points = TxtPoints.Text;
            string new_Follow = TxtFollower.Text.ToString();
            if(new_Follow == "JA")
            {
                new_Follow = "1";
            }
            else 
            { 
                new_Follow = "0";
            }
            string new_Sub = TxtSubscriber.Text.ToString();
            if(new_Sub == "JA")
            {
                new_Sub = "1";
            }
            else
            {
                new_Sub = "0";
            }
            string new_Vip = TxtVip.Text;
            if (new_Vip == "JA")
            {
                new_Vip = "1";
            }
            else
            {
                new_Vip = "0";
            }
            string new_BotPerm = PermissionBox2.SelectedIndex.ToString();
            string new_Mod = TxtIsMod.Text.ToString();
            if (new_Mod == "JA")
            {
                new_Mod = "1";
            }
            else
            {
                new_Mod = "0";
            }


            string sql_Text = "UPDATE db_user SET Username = '" + new_Name + "', DisplayName = '" + new_DisplayName + "', Currency = '" + new_Points + "', IsFollower = '" + new_Follow + "', IsSub = '" + new_Sub + "', IsVip = '" + new_Vip + "', BotPerm = '" + new_BotPerm + "', IsMod = '" + new_Mod + "' WHERE UserID = '" + RefreshId + "';";
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
        private void DelUser()
        {
            string DelItemId = TxtUserId.Text;
            string sql_Text = "DELETE FROM db_user WHERE UserID= " + DelItemId;
            Db_execute(sql_Text);
            Liste_laden();
        }
        private void BtnUserRefresh_Click(object sender, EventArgs e)
        {
            RefreshUser();
        }

        private void BtnUserDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Willst du den ausgewählten User wirklich löschen?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    DelUser();
                }
            }
            catch
            {
                throw;
            }
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
