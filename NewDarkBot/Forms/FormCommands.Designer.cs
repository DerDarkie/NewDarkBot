
namespace NewDarkBot.Forms
{
    partial class FormCommands
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnCommandDelete = new System.Windows.Forms.Button();
            this.BtnCommandRefresh = new System.Windows.Forms.Button();
            this.BtnCommandAdd = new System.Windows.Forms.Button();
            this.Commands = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtIntervall = new System.Windows.Forms.TextBox();
            this.PermissionBox = new System.Windows.Forms.ComboBox();
            this.LastCall = new System.Windows.Forms.TextBox();
            this.CommandResponse = new System.Windows.Forms.TextBox();
            this.TimerNo = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.TimerYes = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IsTimer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CommandUCD = new System.Windows.Forms.TextBox();
            this.CommandTxt = new System.Windows.Forms.TextBox();
            this.CommandId = new System.Windows.Forms.TextBox();
            this.CommandCD = new System.Windows.Forms.TextBox();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Commands.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCommandDelete
            // 
            this.BtnCommandDelete.BackColor = System.Drawing.Color.Transparent;
            this.BtnCommandDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCommandDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCommandDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnCommandDelete.Image = global::NewDarkBot.Properties.Resources.close_icon2;
            this.BtnCommandDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCommandDelete.Location = new System.Drawing.Point(835, 102);
            this.BtnCommandDelete.Name = "BtnCommandDelete";
            this.BtnCommandDelete.Size = new System.Drawing.Size(203, 35);
            this.BtnCommandDelete.TabIndex = 14;
            this.BtnCommandDelete.Text = "Löschen";
            this.BtnCommandDelete.UseVisualStyleBackColor = false;
            this.BtnCommandDelete.Click += new System.EventHandler(this.BtnCommandDelete_Click);
            // 
            // BtnCommandRefresh
            // 
            this.BtnCommandRefresh.BackColor = System.Drawing.Color.Transparent;
            this.BtnCommandRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCommandRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCommandRefresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnCommandRefresh.Image = global::NewDarkBot.Properties.Resources.refresh2_klein;
            this.BtnCommandRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCommandRefresh.Location = new System.Drawing.Point(835, 61);
            this.BtnCommandRefresh.Name = "BtnCommandRefresh";
            this.BtnCommandRefresh.Size = new System.Drawing.Size(203, 35);
            this.BtnCommandRefresh.TabIndex = 13;
            this.BtnCommandRefresh.Text = "Aktualisieren";
            this.BtnCommandRefresh.UseVisualStyleBackColor = false;
            this.BtnCommandRefresh.Click += new System.EventHandler(this.BtnCommandRefresh_Click);
            // 
            // BtnCommandAdd
            // 
            this.BtnCommandAdd.BackColor = System.Drawing.Color.Transparent;
            this.BtnCommandAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCommandAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCommandAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnCommandAdd.Image = global::NewDarkBot.Properties.Resources.addicon;
            this.BtnCommandAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCommandAdd.Location = new System.Drawing.Point(835, 20);
            this.BtnCommandAdd.Name = "BtnCommandAdd";
            this.BtnCommandAdd.Size = new System.Drawing.Size(203, 35);
            this.BtnCommandAdd.TabIndex = 12;
            this.BtnCommandAdd.Text = "Hinzufügen";
            this.BtnCommandAdd.UseVisualStyleBackColor = false;
            this.BtnCommandAdd.Click += new System.EventHandler(this.BtnCommandAdd_Click);
            // 
            // Commands
            // 
            this.Commands.BackColor = System.Drawing.Color.Transparent;
            this.Commands.Controls.Add(this.label13);
            this.Commands.Controls.Add(this.label1);
            this.Commands.Controls.Add(this.TxtIntervall);
            this.Commands.Controls.Add(this.PermissionBox);
            this.Commands.Controls.Add(this.LastCall);
            this.Commands.Controls.Add(this.CommandResponse);
            this.Commands.Controls.Add(this.TimerNo);
            this.Commands.Controls.Add(this.label2);
            this.Commands.Controls.Add(this.TimerYes);
            this.Commands.Controls.Add(this.label9);
            this.Commands.Controls.Add(this.label10);
            this.Commands.Controls.Add(this.label12);
            this.Commands.Controls.Add(this.label11);
            this.Commands.Controls.Add(this.label7);
            this.Commands.Controls.Add(this.label8);
            this.Commands.Controls.Add(this.label3);
            this.Commands.Controls.Add(this.label4);
            this.Commands.Controls.Add(this.label5);
            this.Commands.Controls.Add(this.IsTimer);
            this.Commands.Controls.Add(this.label6);
            this.Commands.Controls.Add(this.CommandUCD);
            this.Commands.Controls.Add(this.CommandTxt);
            this.Commands.Controls.Add(this.CommandId);
            this.Commands.Controls.Add(this.CommandCD);
            this.Commands.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Commands.Location = new System.Drawing.Point(12, 12);
            this.Commands.Name = "Commands";
            this.Commands.Size = new System.Drawing.Size(798, 232);
            this.Commands.TabIndex = 20;
            this.Commands.TabStop = false;
            this.Commands.Text = "Commands";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(542, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 20);
            this.label13.TabIndex = 18;
            this.label13.Text = "Intervall:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(702, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Minuten";
            // 
            // TxtIntervall
            // 
            this.TxtIntervall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.TxtIntervall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtIntervall.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtIntervall.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtIntervall.Location = new System.Drawing.Point(626, 35);
            this.TxtIntervall.Name = "TxtIntervall";
            this.TxtIntervall.Size = new System.Drawing.Size(71, 26);
            this.TxtIntervall.TabIndex = 20;
            this.TxtIntervall.TabStop = false;
            // 
            // PermissionBox
            // 
            this.PermissionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.PermissionBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PermissionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PermissionBox.ForeColor = System.Drawing.Color.White;
            this.PermissionBox.FormattingEnabled = true;
            this.PermissionBox.Location = new System.Drawing.Point(575, 170);
            this.PermissionBox.Name = "PermissionBox";
            this.PermissionBox.Size = new System.Drawing.Size(204, 26);
            this.PermissionBox.TabIndex = 17;
            // 
            // LastCall
            // 
            this.LastCall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.LastCall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastCall.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastCall.ForeColor = System.Drawing.Color.White;
            this.LastCall.Location = new System.Drawing.Point(575, 140);
            this.LastCall.Name = "LastCall";
            this.LastCall.Size = new System.Drawing.Size(204, 24);
            this.LastCall.TabIndex = 13;
            this.LastCall.TabStop = false;
            // 
            // CommandResponse
            // 
            this.CommandResponse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.CommandResponse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CommandResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CommandResponse.ForeColor = System.Drawing.SystemColors.Menu;
            this.CommandResponse.Location = new System.Drawing.Point(111, 108);
            this.CommandResponse.Name = "CommandResponse";
            this.CommandResponse.Size = new System.Drawing.Size(669, 24);
            this.CommandResponse.TabIndex = 2;
            // 
            // TimerNo
            // 
            this.TimerNo.AutoSize = true;
            this.TimerNo.BackColor = System.Drawing.Color.Transparent;
            this.TimerNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimerNo.ForeColor = System.Drawing.Color.White;
            this.TimerNo.Location = new System.Drawing.Point(251, 203);
            this.TimerNo.Name = "TimerNo";
            this.TimerNo.Size = new System.Drawing.Size(56, 22);
            this.TimerNo.TabIndex = 6;
            this.TimerNo.TabStop = true;
            this.TimerNo.Text = "Nein";
            this.TimerNo.UseVisualStyleBackColor = false;
            this.TimerNo.CheckedChanged += new System.EventHandler(this.TimerNo_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Keyword:";
            // 
            // TimerYes
            // 
            this.TimerYes.AutoSize = true;
            this.TimerYes.BackColor = System.Drawing.Color.Transparent;
            this.TimerYes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TimerYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimerYes.ForeColor = System.Drawing.Color.White;
            this.TimerYes.Location = new System.Drawing.Point(151, 203);
            this.TimerYes.Name = "TimerYes";
            this.TimerYes.Size = new System.Drawing.Size(42, 22);
            this.TimerYes.TabIndex = 5;
            this.TimerYes.TabStop = true;
            this.TimerYes.Text = "Ja";
            this.TimerYes.UseVisualStyleBackColor = false;
            this.TimerYes.CheckedChanged += new System.EventHandler(this.TimerYes_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(10, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "ID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label10.Location = new System.Drawing.Point(183, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "(Wird automatisch generiert)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(474, 172);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "Permission";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(448, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "Letzter Aufruf";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(237, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Sekunden";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(237, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Sekunden";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Response:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cooldown:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(10, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "User Cooldown:";
            // 
            // IsTimer
            // 
            this.IsTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.IsTimer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IsTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IsTimer.ForeColor = System.Drawing.SystemColors.Control;
            this.IsTimer.Location = new System.Drawing.Point(63, 206);
            this.IsTimer.Name = "IsTimer";
            this.IsTimer.Size = new System.Drawing.Size(71, 15);
            this.IsTimer.TabIndex = 12;
            this.IsTimer.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(10, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Timer:";
            // 
            // CommandUCD
            // 
            this.CommandUCD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.CommandUCD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CommandUCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CommandUCD.ForeColor = System.Drawing.SystemColors.Menu;
            this.CommandUCD.Location = new System.Drawing.Point(151, 169);
            this.CommandUCD.Name = "CommandUCD";
            this.CommandUCD.Size = new System.Drawing.Size(71, 24);
            this.CommandUCD.TabIndex = 4;
            // 
            // CommandTxt
            // 
            this.CommandTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.CommandTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CommandTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CommandTxt.ForeColor = System.Drawing.SystemColors.Menu;
            this.CommandTxt.Location = new System.Drawing.Point(110, 73);
            this.CommandTxt.Name = "CommandTxt";
            this.CommandTxt.Size = new System.Drawing.Size(669, 24);
            this.CommandTxt.TabIndex = 1;
            // 
            // CommandId
            // 
            this.CommandId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.CommandId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CommandId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CommandId.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.CommandId.Location = new System.Drawing.Point(111, 38);
            this.CommandId.Name = "CommandId";
            this.CommandId.ReadOnly = true;
            this.CommandId.Size = new System.Drawing.Size(71, 22);
            this.CommandId.TabIndex = 11;
            this.CommandId.TabStop = false;
            // 
            // CommandCD
            // 
            this.CommandCD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.CommandCD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CommandCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CommandCD.ForeColor = System.Drawing.SystemColors.Menu;
            this.CommandCD.Location = new System.Drawing.Point(151, 141);
            this.CommandCD.Name = "CommandCD";
            this.CommandCD.Size = new System.Drawing.Size(71, 24);
            this.CommandCD.TabIndex = 3;
            // 
            // DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.ColumnHeadersVisible = false;
            this.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridView1.GridColor = System.Drawing.Color.Gray;
            this.DataGridView1.Location = new System.Drawing.Point(3, 22);
            this.DataGridView1.MultiSelect = false;
            this.DataGridView1.Name = "DataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.RowHeadersWidth = 25;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridView1.RowTemplate.Height = 25;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(1318, 415);
            this.DataGridView1.TabIndex = 21;
            this.DataGridView1.TabStop = false;
            this.DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.DataGridView1.SelectionChanged += new System.EventHandler(this.DataGridView1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(12, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1324, 440);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Commands";
            // 
            // FormCommands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1348, 702);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Commands);
            this.Controls.Add(this.BtnCommandDelete);
            this.Controls.Add(this.BtnCommandRefresh);
            this.Controls.Add(this.BtnCommandAdd);
            this.Name = "FormCommands";
            this.Text = "Command Verwaltung";
            this.Load += new System.EventHandler(this.FormCommands_Load);
            this.Commands.ResumeLayout(false);
            this.Commands.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCommandDelete;
        private System.Windows.Forms.Button BtnCommandRefresh;
        private System.Windows.Forms.Button BtnCommandAdd;
        private System.Windows.Forms.GroupBox Commands;
        private System.Windows.Forms.ComboBox PermissionBox;
        private System.Windows.Forms.TextBox LastCall;
        private System.Windows.Forms.TextBox CommandResponse;
        private System.Windows.Forms.RadioButton TimerNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton TimerYes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IsTimer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CommandUCD;
        private System.Windows.Forms.TextBox CommandTxt;
        private System.Windows.Forms.TextBox CommandId;
        private System.Windows.Forms.TextBox CommandCD;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtIntervall;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}