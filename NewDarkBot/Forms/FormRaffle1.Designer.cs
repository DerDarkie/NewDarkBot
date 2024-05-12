
namespace NewDarkBot.Forms
{
    partial class FormRaffle1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.JoindListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtKeyword = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CheckUseArg1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtSetTimeMM = new System.Windows.Forms.Label();
            this.TxtSetTimeHH = new System.Windows.Forms.Label();
            this.BtnDelTemp = new System.Windows.Forms.Button();
            this.BtnClearFields = new System.Windows.Forms.Button();
            this.BtnAddTemp = new System.Windows.Forms.Button();
            this.BtnRefreshTemp = new System.Windows.Forms.Button();
            this.TrackTimeHH = new System.Windows.Forms.TrackBar();
            this.TrackTimeMM = new System.Windows.Forms.TrackBar();
            this.CheckTimer = new System.Windows.Forms.CheckBox();
            this.CheckMaxTickets = new System.Windows.Forms.CheckBox();
            this.CheckTicketCost = new System.Windows.Forms.CheckBox();
            this.ComboPerm = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.TxtAktiv = new System.Windows.Forms.TextBox();
            this.TxtMaxTickets = new System.Windows.Forms.TextBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtTicketCost = new System.Windows.Forms.TextBox();
            this.BtnPickWin = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.WinChatListBox = new System.Windows.Forms.ListBox();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnStopEntries = new System.Windows.Forms.Button();
            this.BtnRemoveWinner = new System.Windows.Forms.Button();
            this.BtnCloseRaffle1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.DataGridVorlagen = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.TxtArg3 = new System.Windows.Forms.TextBox();
            this.TxtArg2 = new System.Windows.Forms.TextBox();
            this.TxtArg1 = new System.Windows.Forms.TextBox();
            this.TxtJName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackTimeHH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackTimeMM)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridVorlagen)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.JoindListBox);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(1087, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 474);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Joined Viewer";
            // 
            // JoindListBox
            // 
            this.JoindListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.JoindListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.JoindListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JoindListBox.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.JoindListBox.FormattingEnabled = true;
            this.JoindListBox.ItemHeight = 19;
            this.JoindListBox.Location = new System.Drawing.Point(3, 22);
            this.JoindListBox.Name = "JoindListBox";
            this.JoindListBox.ScrollAlwaysVisible = true;
            this.JoindListBox.Size = new System.Drawing.Size(250, 449);
            this.JoindListBox.TabIndex = 0;
            this.JoindListBox.SelectedIndexChanged += new System.EventHandler(this.JoindListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(69, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Keyword:";
            // 
            // TxtKeyword
            // 
            this.TxtKeyword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.TxtKeyword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtKeyword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtKeyword.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TxtKeyword.Location = new System.Drawing.Point(70, 45);
            this.TxtKeyword.Name = "TxtKeyword";
            this.TxtKeyword.Size = new System.Drawing.Size(167, 26);
            this.TxtKeyword.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.groupBox2.Controls.Add(this.CheckUseArg1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TxtSetTimeMM);
            this.groupBox2.Controls.Add(this.TxtSetTimeHH);
            this.groupBox2.Controls.Add(this.BtnDelTemp);
            this.groupBox2.Controls.Add(this.BtnClearFields);
            this.groupBox2.Controls.Add(this.BtnAddTemp);
            this.groupBox2.Controls.Add(this.BtnRefreshTemp);
            this.groupBox2.Controls.Add(this.TrackTimeHH);
            this.groupBox2.Controls.Add(this.TrackTimeMM);
            this.groupBox2.Controls.Add(this.CheckTimer);
            this.groupBox2.Controls.Add(this.CheckMaxTickets);
            this.groupBox2.Controls.Add(this.CheckTicketCost);
            this.groupBox2.Controls.Add(this.ComboPerm);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TxtPrice);
            this.groupBox2.Controls.Add(this.TxtAktiv);
            this.groupBox2.Controls.Add(this.TxtMaxTickets);
            this.groupBox2.Controls.Add(this.TxtId);
            this.groupBox2.Controls.Add(this.TxtTicketCost);
            this.groupBox2.Controls.Add(this.TxtKeyword);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox2.Location = new System.Drawing.Point(3, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1340, 219);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Einstellungen Give Away I";
            // 
            // CheckUseArg1
            // 
            this.CheckUseArg1.AutoSize = true;
            this.CheckUseArg1.Location = new System.Drawing.Point(7, 140);
            this.CheckUseArg1.Name = "CheckUseArg1";
            this.CheckUseArg1.Size = new System.Drawing.Size(539, 23);
            this.CheckUseArg1.TabIndex = 11;
            this.CheckUseArg1.Text = "Für WoW GiveAway kannst du 3 Argumente nutzen ( Char-Name, Server, Fraktion)";
            this.CheckUseArg1.UseVisualStyleBackColor = true;
            this.CheckUseArg1.CheckedChanged += new System.EventHandler(this.CheckUseArg1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(970, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = ":";
            // 
            // TxtSetTimeMM
            // 
            this.TxtSetTimeMM.AutoSize = true;
            this.TxtSetTimeMM.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtSetTimeMM.Location = new System.Drawing.Point(990, 115);
            this.TxtSetTimeMM.Name = "TxtSetTimeMM";
            this.TxtSetTimeMM.Size = new System.Drawing.Size(28, 21);
            this.TxtSetTimeMM.TabIndex = 7;
            this.TxtSetTimeMM.Text = "00";
            // 
            // TxtSetTimeHH
            // 
            this.TxtSetTimeHH.AutoSize = true;
            this.TxtSetTimeHH.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtSetTimeHH.Location = new System.Drawing.Point(936, 116);
            this.TxtSetTimeHH.Name = "TxtSetTimeHH";
            this.TxtSetTimeHH.Size = new System.Drawing.Size(28, 21);
            this.TxtSetTimeHH.TabIndex = 7;
            this.TxtSetTimeHH.Text = "00";
            // 
            // BtnDelTemp
            // 
            this.BtnDelTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.BtnDelTemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelTemp.Image = global::NewDarkBot.Properties.Resources.close_icon2;
            this.BtnDelTemp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDelTemp.Location = new System.Drawing.Point(1143, 125);
            this.BtnDelTemp.Name = "BtnDelTemp";
            this.BtnDelTemp.Size = new System.Drawing.Size(190, 30);
            this.BtnDelTemp.TabIndex = 6;
            this.BtnDelTemp.TabStop = false;
            this.BtnDelTemp.Text = "Vorlage löschen";
            this.BtnDelTemp.UseVisualStyleBackColor = false;
            this.BtnDelTemp.Click += new System.EventHandler(this.BtnDelTemp_Click);
            // 
            // BtnClearFields
            // 
            this.BtnClearFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.BtnClearFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClearFields.Image = global::NewDarkBot.Properties.Resources.start;
            this.BtnClearFields.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClearFields.Location = new System.Drawing.Point(1143, 22);
            this.BtnClearFields.Name = "BtnClearFields";
            this.BtnClearFields.Size = new System.Drawing.Size(190, 30);
            this.BtnClearFields.TabIndex = 6;
            this.BtnClearFields.TabStop = false;
            this.BtnClearFields.Text = "Neue Vorlage";
            this.BtnClearFields.UseVisualStyleBackColor = false;
            this.BtnClearFields.Click += new System.EventHandler(this.BtnClearFields_Click);
            // 
            // BtnAddTemp
            // 
            this.BtnAddTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.BtnAddTemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddTemp.Image = global::NewDarkBot.Properties.Resources.addicon;
            this.BtnAddTemp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddTemp.Location = new System.Drawing.Point(1143, 57);
            this.BtnAddTemp.Name = "BtnAddTemp";
            this.BtnAddTemp.Size = new System.Drawing.Size(190, 30);
            this.BtnAddTemp.TabIndex = 6;
            this.BtnAddTemp.TabStop = false;
            this.BtnAddTemp.Text = "Vorlage hinzufügen";
            this.BtnAddTemp.UseVisualStyleBackColor = false;
            this.BtnAddTemp.Click += new System.EventHandler(this.BtnAddTemp_Click);
            // 
            // BtnRefreshTemp
            // 
            this.BtnRefreshTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.BtnRefreshTemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefreshTemp.Image = global::NewDarkBot.Properties.Resources.refresh2_klein;
            this.BtnRefreshTemp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRefreshTemp.Location = new System.Drawing.Point(1143, 91);
            this.BtnRefreshTemp.Name = "BtnRefreshTemp";
            this.BtnRefreshTemp.Size = new System.Drawing.Size(190, 30);
            this.BtnRefreshTemp.TabIndex = 6;
            this.BtnRefreshTemp.TabStop = false;
            this.BtnRefreshTemp.Text = "Vorlage aktualisieren";
            this.BtnRefreshTemp.UseVisualStyleBackColor = false;
            this.BtnRefreshTemp.Click += new System.EventHandler(this.BtnRefreshTemp_Click);
            // 
            // TrackTimeHH
            // 
            this.TrackTimeHH.AllowDrop = true;
            this.TrackTimeHH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.TrackTimeHH.LargeChange = 2;
            this.TrackTimeHH.Location = new System.Drawing.Point(487, 110);
            this.TrackTimeHH.Maximum = 24;
            this.TrackTimeHH.Name = "TrackTimeHH";
            this.TrackTimeHH.Size = new System.Drawing.Size(230, 45);
            this.TrackTimeHH.TabIndex = 9;
            this.TrackTimeHH.TabStop = false;
            this.TrackTimeHH.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.TrackTimeHH.Scroll += new System.EventHandler(this.TrackTimeHH_Scroll);
            // 
            // TrackTimeMM
            // 
            this.TrackTimeMM.AllowDrop = true;
            this.TrackTimeMM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.TrackTimeMM.LargeChange = 1000;
            this.TrackTimeMM.Location = new System.Drawing.Point(723, 110);
            this.TrackTimeMM.Maximum = 60;
            this.TrackTimeMM.Name = "TrackTimeMM";
            this.TrackTimeMM.Size = new System.Drawing.Size(207, 45);
            this.TrackTimeMM.TabIndex = 10;
            this.TrackTimeMM.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.TrackTimeMM.Scroll += new System.EventHandler(this.TrackTimeMM_Scroll);
            // 
            // CheckTimer
            // 
            this.CheckTimer.AutoSize = true;
            this.CheckTimer.Location = new System.Drawing.Point(487, 73);
            this.CheckTimer.Name = "CheckTimer";
            this.CheckTimer.Size = new System.Drawing.Size(62, 23);
            this.CheckTimer.TabIndex = 6;
            this.CheckTimer.Text = "Timer";
            this.CheckTimer.UseVisualStyleBackColor = true;
            this.CheckTimer.CheckedChanged += new System.EventHandler(this.CheckTimer_CheckedChanged);
            // 
            // CheckMaxTickets
            // 
            this.CheckMaxTickets.AutoSize = true;
            this.CheckMaxTickets.Location = new System.Drawing.Point(243, 74);
            this.CheckMaxTickets.Name = "CheckMaxTickets";
            this.CheckMaxTickets.Size = new System.Drawing.Size(103, 23);
            this.CheckMaxTickets.TabIndex = 5;
            this.CheckMaxTickets.Text = "Max.Tickets";
            this.CheckMaxTickets.UseVisualStyleBackColor = true;
            this.CheckMaxTickets.CheckedChanged += new System.EventHandler(this.CheckMaxTickets_CheckedChanged);
            // 
            // CheckTicketCost
            // 
            this.CheckTicketCost.AutoSize = true;
            this.CheckTicketCost.Location = new System.Drawing.Point(7, 74);
            this.CheckTicketCost.Name = "CheckTicketCost";
            this.CheckTicketCost.Size = new System.Drawing.Size(113, 23);
            this.CheckTicketCost.TabIndex = 4;
            this.CheckTicketCost.Text = "Ticket Kosten";
            this.CheckTicketCost.UseVisualStyleBackColor = true;
            this.CheckTicketCost.CheckedChanged += new System.EventHandler(this.CheckTicketCost_CheckedChanged);
            // 
            // ComboPerm
            // 
            this.ComboPerm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.ComboPerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboPerm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboPerm.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ComboPerm.FormattingEnabled = true;
            this.ComboPerm.Location = new System.Drawing.Point(774, 45);
            this.ComboPerm.Name = "ComboPerm";
            this.ComboPerm.Size = new System.Drawing.Size(290, 27);
            this.ComboPerm.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(774, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Join Permission:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(863, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "Minuten";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(650, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Stunden";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(242, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gewinn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(-58, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(5, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "ID:";
            // 
            // TxtPrice
            // 
            this.TxtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.TxtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPrice.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TxtPrice.Location = new System.Drawing.Point(242, 45);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(526, 26);
            this.TxtPrice.TabIndex = 2;
            // 
            // TxtAktiv
            // 
            this.TxtAktiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.TxtAktiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtAktiv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtAktiv.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TxtAktiv.Location = new System.Drawing.Point(990, 74);
            this.TxtAktiv.Name = "TxtAktiv";
            this.TxtAktiv.Size = new System.Drawing.Size(74, 26);
            this.TxtAktiv.TabIndex = 2;
            this.TxtAktiv.TabStop = false;
            // 
            // TxtMaxTickets
            // 
            this.TxtMaxTickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.TxtMaxTickets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtMaxTickets.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtMaxTickets.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TxtMaxTickets.Location = new System.Drawing.Point(242, 112);
            this.TxtMaxTickets.Name = "TxtMaxTickets";
            this.TxtMaxTickets.Size = new System.Drawing.Size(231, 26);
            this.TxtMaxTickets.TabIndex = 8;
            // 
            // TxtId
            // 
            this.TxtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.TxtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtId.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TxtId.Location = new System.Drawing.Point(6, 45);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(58, 19);
            this.TxtId.TabIndex = 2;
            this.TxtId.TabStop = false;
            // 
            // TxtTicketCost
            // 
            this.TxtTicketCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.TxtTicketCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTicketCost.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtTicketCost.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TxtTicketCost.Location = new System.Drawing.Point(6, 112);
            this.TxtTicketCost.Name = "TxtTicketCost";
            this.TxtTicketCost.Size = new System.Drawing.Size(231, 26);
            this.TxtTicketCost.TabIndex = 7;
            // 
            // BtnPickWin
            // 
            this.BtnPickWin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.BtnPickWin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPickWin.Image = global::NewDarkBot.Properties.Resources.winner;
            this.BtnPickWin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPickWin.Location = new System.Drawing.Point(5, 94);
            this.BtnPickWin.Name = "BtnPickWin";
            this.BtnPickWin.Size = new System.Drawing.Size(190, 30);
            this.BtnPickWin.TabIndex = 6;
            this.BtnPickWin.TabStop = false;
            this.BtnPickWin.Text = "Gewinner ziehen";
            this.BtnPickWin.UseVisualStyleBackColor = false;
            this.BtnPickWin.Click += new System.EventHandler(this.BtnPickWin_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.WinChatListBox);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox3.Location = new System.Drawing.Point(882, 433);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(199, 121);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gewinner Messages";
            // 
            // WinChatListBox
            // 
            this.WinChatListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.WinChatListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WinChatListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WinChatListBox.ForeColor = System.Drawing.SystemColors.Info;
            this.WinChatListBox.FormattingEnabled = true;
            this.WinChatListBox.ItemHeight = 19;
            this.WinChatListBox.Location = new System.Drawing.Point(3, 22);
            this.WinChatListBox.Name = "WinChatListBox";
            this.WinChatListBox.ScrollAlwaysVisible = true;
            this.WinChatListBox.Size = new System.Drawing.Size(193, 96);
            this.WinChatListBox.Sorted = true;
            this.WinChatListBox.TabIndex = 0;
            // 
            // BtnStart
            // 
            this.BtnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.BtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnStart.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnStart.Image = global::NewDarkBot.Properties.Resources.start;
            this.BtnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnStart.Location = new System.Drawing.Point(5, 22);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(190, 30);
            this.BtnStart.TabIndex = 6;
            this.BtnStart.TabStop = false;
            this.BtnStart.Text = "Raffle starten";
            this.BtnStart.UseVisualStyleBackColor = false;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnStopEntries
            // 
            this.BtnStopEntries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.BtnStopEntries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStopEntries.Image = global::NewDarkBot.Properties.Resources.hold;
            this.BtnStopEntries.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnStopEntries.Location = new System.Drawing.Point(5, 58);
            this.BtnStopEntries.Name = "BtnStopEntries";
            this.BtnStopEntries.Size = new System.Drawing.Size(190, 30);
            this.BtnStopEntries.TabIndex = 6;
            this.BtnStopEntries.TabStop = false;
            this.BtnStopEntries.Text = "Einträge stoppen";
            this.BtnStopEntries.UseVisualStyleBackColor = false;
            this.BtnStopEntries.Click += new System.EventHandler(this.BtnStopEntries_Click);
            // 
            // BtnRemoveWinner
            // 
            this.BtnRemoveWinner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.BtnRemoveWinner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemoveWinner.Image = global::NewDarkBot.Properties.Resources.user_remove_icon;
            this.BtnRemoveWinner.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRemoveWinner.Location = new System.Drawing.Point(5, 130);
            this.BtnRemoveWinner.Name = "BtnRemoveWinner";
            this.BtnRemoveWinner.Size = new System.Drawing.Size(190, 30);
            this.BtnRemoveWinner.TabIndex = 6;
            this.BtnRemoveWinner.TabStop = false;
            this.BtnRemoveWinner.Text = "Gewinner entfernen";
            this.BtnRemoveWinner.UseVisualStyleBackColor = false;
            // 
            // BtnCloseRaffle1
            // 
            this.BtnCloseRaffle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.BtnCloseRaffle1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCloseRaffle1.Image = global::NewDarkBot.Properties.Resources.close_icon2;
            this.BtnCloseRaffle1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCloseRaffle1.Location = new System.Drawing.Point(5, 166);
            this.BtnCloseRaffle1.Name = "BtnCloseRaffle1";
            this.BtnCloseRaffle1.Size = new System.Drawing.Size(190, 30);
            this.BtnCloseRaffle1.TabIndex = 6;
            this.BtnCloseRaffle1.TabStop = false;
            this.BtnCloseRaffle1.Text = "Raffle schließen";
            this.BtnCloseRaffle1.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnStart);
            this.groupBox4.Controls.Add(this.BtnStopEntries);
            this.groupBox4.Controls.Add(this.BtnPickWin);
            this.groupBox4.Controls.Add(this.BtnCloseRaffle1);
            this.groupBox4.Controls.Add(this.BtnRemoveWinner);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox4.Location = new System.Drawing.Point(882, 225);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(199, 202);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Raffle Funktionen";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.DataGridVorlagen);
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox5.Location = new System.Drawing.Point(3, 225);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(873, 474);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Raffle Vorlagen";
            // 
            // DataGridVorlagen
            // 
            this.DataGridVorlagen.AllowUserToAddRows = false;
            this.DataGridVorlagen.AllowUserToDeleteRows = false;
            this.DataGridVorlagen.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.DataGridVorlagen.CausesValidation = false;
            this.DataGridVorlagen.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DataGridVorlagen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridVorlagen.DefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridVorlagen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridVorlagen.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridVorlagen.Location = new System.Drawing.Point(3, 22);
            this.DataGridVorlagen.MultiSelect = false;
            this.DataGridVorlagen.Name = "DataGridVorlagen";
            this.DataGridVorlagen.ReadOnly = true;
            this.DataGridVorlagen.RowTemplate.Height = 25;
            this.DataGridVorlagen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridVorlagen.ShowCellErrors = false;
            this.DataGridVorlagen.ShowEditingIcon = false;
            this.DataGridVorlagen.ShowRowErrors = false;
            this.DataGridVorlagen.Size = new System.Drawing.Size(867, 449);
            this.DataGridVorlagen.TabIndex = 0;
            this.DataGridVorlagen.TabStop = false;
            this.DataGridVorlagen.SelectionChanged += new System.EventHandler(this.DataGridVorlagen_SelectedIndexChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.TxtArg3);
            this.groupBox6.Controls.Add(this.TxtArg2);
            this.groupBox6.Controls.Add(this.TxtArg1);
            this.groupBox6.Controls.Add(this.TxtJName);
            this.groupBox6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(882, 557);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 142);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "User Eingaben";
            // 
            // TxtArg3
            // 
            this.TxtArg3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.TxtArg3.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtArg3.ForeColor = System.Drawing.Color.White;
            this.TxtArg3.Location = new System.Drawing.Point(3, 100);
            this.TxtArg3.Name = "TxtArg3";
            this.TxtArg3.Size = new System.Drawing.Size(194, 26);
            this.TxtArg3.TabIndex = 0;
            // 
            // TxtArg2
            // 
            this.TxtArg2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.TxtArg2.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtArg2.ForeColor = System.Drawing.Color.White;
            this.TxtArg2.Location = new System.Drawing.Point(3, 74);
            this.TxtArg2.Name = "TxtArg2";
            this.TxtArg2.Size = new System.Drawing.Size(194, 26);
            this.TxtArg2.TabIndex = 0;
            // 
            // TxtArg1
            // 
            this.TxtArg1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.TxtArg1.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtArg1.ForeColor = System.Drawing.Color.White;
            this.TxtArg1.Location = new System.Drawing.Point(3, 48);
            this.TxtArg1.Name = "TxtArg1";
            this.TxtArg1.Size = new System.Drawing.Size(194, 26);
            this.TxtArg1.TabIndex = 0;
            // 
            // TxtJName
            // 
            this.TxtJName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.TxtJName.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtJName.ForeColor = System.Drawing.Color.White;
            this.TxtJName.Location = new System.Drawing.Point(3, 22);
            this.TxtJName.Name = "TxtJName";
            this.TxtJName.Size = new System.Drawing.Size(194, 26);
            this.TxtJName.TabIndex = 0;
            // 
            // FormRaffle1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1348, 702);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormRaffle1";
            this.Text = "Raffle 1";
            this.Load += new System.EventHandler(this.FormRaffle1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackTimeHH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackTimeMM)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridVorlagen)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtKeyword;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar TrackTimeMM;
        private System.Windows.Forms.CheckBox CheckTimer;
        private System.Windows.Forms.CheckBox CheckMaxTickets;
        private System.Windows.Forms.CheckBox CheckTicketCost;
        private System.Windows.Forms.ComboBox ComboPerm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.TextBox TxtMaxTickets;
        private System.Windows.Forms.TextBox TxtTicketCost;
        private System.Windows.Forms.Button BtnDelTemp;
        private System.Windows.Forms.Button BtnPickWin;
        private System.Windows.Forms.Button BtnRefreshTemp;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnStopEntries;
        private System.Windows.Forms.Button BtnRemoveWinner;
        private System.Windows.Forms.Button BtnCloseRaffle1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView DataGridVorlagen;
        private System.Windows.Forms.Button BtnAddTemp;
        private System.Windows.Forms.TextBox TxtAktiv;
        private System.Windows.Forms.Label TxtSetTimeHH;
        private System.Windows.Forms.TrackBar TrackTimeHH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label TxtSetTimeMM;
        private System.Windows.Forms.Button BtnClearFields;
        private System.Windows.Forms.CheckBox CheckUseArg1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox JoindListBox;
        private System.Windows.Forms.ListBox WinChatListBox;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox TxtArg3;
        private System.Windows.Forms.TextBox TxtArg2;
        private System.Windows.Forms.TextBox TxtArg1;
        private System.Windows.Forms.TextBox TxtJName;
    }
}