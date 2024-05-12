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
    public partial class FormCurrency : Form
    {
        private delegate void SafeCallDelegate(string text);
        public FormCurrency()
        {
            InitializeComponent();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }


        }
        private void FormCurrency_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
    }
}
