
namespace NewDarkBot.Forms
{
    partial class FormUser
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnCommandDelete = new System.Windows.Forms.Button();
            this.BtnUserRefresh = new System.Windows.Forms.Button();
            this.PermissionBox2 = new System.Windows.Forms.ComboBox();
            this.TxtSubscriber = new System.Windows.Forms.TextBox();
            this.TxtPoints = new System.Windows.Forms.TextBox();
            this.TxtIsMod = new System.Windows.Forms.TextBox();
            this.TxtVip = new System.Windows.Forms.TextBox();
            this.TxtFollower = new System.Windows.Forms.TextBox();
            this.TxtDate = new System.Windows.Forms.TextBox();
            this.TxtDisplayName = new System.Windows.Forms.TextBox();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.TxtUserId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GroupBoxUser = new System.Windows.Forms.GroupBox();
            this.UserGridView = new System.Windows.Forms.DataGridView();
            this.GroupBox1.SuspendLayout();
            this.GroupBoxUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.BtnCommandDelete);
            this.GroupBox1.Controls.Add(this.BtnUserRefresh);
            this.GroupBox1.Controls.Add(this.PermissionBox2);
            this.GroupBox1.Controls.Add(this.TxtSubscriber);
            this.GroupBox1.Controls.Add(this.TxtPoints);
            this.GroupBox1.Controls.Add(this.TxtIsMod);
            this.GroupBox1.Controls.Add(this.TxtVip);
            this.GroupBox1.Controls.Add(this.TxtFollower);
            this.GroupBox1.Controls.Add(this.TxtDate);
            this.GroupBox1.Controls.Add(this.TxtDisplayName);
            this.GroupBox1.Controls.Add(this.TxtUserName);
            this.GroupBox1.Controls.Add(this.TxtUserId);
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Controls.Add(this.label9);
            this.GroupBox1.Controls.Add(this.label5);
            this.GroupBox1.Controls.Add(this.label10);
            this.GroupBox1.Controls.Add(this.label6);
            this.GroupBox1.Controls.Add(this.label8);
            this.GroupBox1.Controls.Add(this.label1);
            this.GroupBox1.Controls.Add(this.label7);
            this.GroupBox1.Controls.Add(this.label4);
            this.GroupBox1.Controls.Add(this.label3);
            this.GroupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GroupBox1.ForeColor = System.Drawing.Color.White;
            this.GroupBox1.Location = new System.Drawing.Point(973, 0);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(375, 702);
            this.GroupBox1.TabIndex = 6;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Edit Selected User";
            this.GroupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // BtnCommandDelete
            // 
            this.BtnCommandDelete.BackColor = System.Drawing.Color.Transparent;
            this.BtnCommandDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCommandDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCommandDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnCommandDelete.Image = global::NewDarkBot.Properties.Resources.close_icon2;
            this.BtnCommandDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCommandDelete.Location = new System.Drawing.Point(131, 433);
            this.BtnCommandDelete.Name = "BtnCommandDelete";
            this.BtnCommandDelete.Size = new System.Drawing.Size(203, 35);
            this.BtnCommandDelete.TabIndex = 16;
            this.BtnCommandDelete.Text = "Löschen";
            this.BtnCommandDelete.UseVisualStyleBackColor = false;
            this.BtnCommandDelete.Click += new System.EventHandler(this.BtnUserDelete_Click);
            // 
            // BtnUserRefresh
            // 
            this.BtnUserRefresh.BackColor = System.Drawing.Color.Transparent;
            this.BtnUserRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUserRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnUserRefresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnUserRefresh.Image = global::NewDarkBot.Properties.Resources.refresh2_klein;
            this.BtnUserRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUserRefresh.Location = new System.Drawing.Point(131, 392);
            this.BtnUserRefresh.Name = "BtnUserRefresh";
            this.BtnUserRefresh.Size = new System.Drawing.Size(203, 35);
            this.BtnUserRefresh.TabIndex = 15;
            this.BtnUserRefresh.Text = "Aktualisieren";
            this.BtnUserRefresh.UseVisualStyleBackColor = false;
            this.BtnUserRefresh.Click += new System.EventHandler(this.BtnUserRefresh_Click);
            // 
            // PermissionBox2
            // 
            this.PermissionBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.PermissionBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PermissionBox2.ForeColor = System.Drawing.Color.White;
            this.PermissionBox2.FormattingEnabled = true;
            this.PermissionBox2.Location = new System.Drawing.Point(131, 331);
            this.PermissionBox2.Name = "PermissionBox2";
            this.PermissionBox2.Size = new System.Drawing.Size(203, 27);
            this.PermissionBox2.TabIndex = 6;
            // 
            // TxtSubscriber
            // 
            this.TxtSubscriber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.TxtSubscriber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSubscriber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtSubscriber.ForeColor = System.Drawing.Color.White;
            this.TxtSubscriber.Location = new System.Drawing.Point(131, 228);
            this.TxtSubscriber.Name = "TxtSubscriber";
            this.TxtSubscriber.Size = new System.Drawing.Size(203, 26);
            this.TxtSubscriber.TabIndex = 5;
            // 
            // TxtPoints
            // 
            this.TxtPoints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.TxtPoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPoints.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPoints.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TxtPoints.Location = new System.Drawing.Point(131, 128);
            this.TxtPoints.Name = "TxtPoints";
            this.TxtPoints.Size = new System.Drawing.Size(203, 26);
            this.TxtPoints.TabIndex = 5;
            // 
            // TxtIsMod
            // 
            this.TxtIsMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.TxtIsMod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtIsMod.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtIsMod.ForeColor = System.Drawing.Color.White;
            this.TxtIsMod.Location = new System.Drawing.Point(131, 293);
            this.TxtIsMod.Name = "TxtIsMod";
            this.TxtIsMod.Size = new System.Drawing.Size(203, 26);
            this.TxtIsMod.TabIndex = 5;
            // 
            // TxtVip
            // 
            this.TxtVip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.TxtVip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtVip.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtVip.ForeColor = System.Drawing.Color.White;
            this.TxtVip.Location = new System.Drawing.Point(131, 261);
            this.TxtVip.Name = "TxtVip";
            this.TxtVip.Size = new System.Drawing.Size(203, 26);
            this.TxtVip.TabIndex = 5;
            // 
            // TxtFollower
            // 
            this.TxtFollower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.TxtFollower.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtFollower.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtFollower.ForeColor = System.Drawing.Color.White;
            this.TxtFollower.Location = new System.Drawing.Point(131, 193);
            this.TxtFollower.Name = "TxtFollower";
            this.TxtFollower.Size = new System.Drawing.Size(203, 26);
            this.TxtFollower.TabIndex = 5;
            // 
            // TxtDate
            // 
            this.TxtDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.TxtDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtDate.ForeColor = System.Drawing.Color.White;
            this.TxtDate.Location = new System.Drawing.Point(131, 161);
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.Size = new System.Drawing.Size(203, 26);
            this.TxtDate.TabIndex = 5;
            // 
            // TxtDisplayName
            // 
            this.TxtDisplayName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.TxtDisplayName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDisplayName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtDisplayName.ForeColor = System.Drawing.Color.White;
            this.TxtDisplayName.Location = new System.Drawing.Point(131, 93);
            this.TxtDisplayName.Name = "TxtDisplayName";
            this.TxtDisplayName.Size = new System.Drawing.Size(203, 26);
            this.TxtDisplayName.TabIndex = 5;
            // 
            // TxtUserName
            // 
            this.TxtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.TxtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtUserName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtUserName.ForeColor = System.Drawing.Color.White;
            this.TxtUserName.Location = new System.Drawing.Point(131, 59);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(203, 26);
            this.TxtUserName.TabIndex = 5;
            // 
            // TxtUserId
            // 
            this.TxtUserId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.TxtUserId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUserId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtUserId.ForeColor = System.Drawing.Color.White;
            this.TxtUserId.Location = new System.Drawing.Point(131, 26);
            this.TxtUserId.Name = "TxtUserId";
            this.TxtUserId.ReadOnly = true;
            this.TxtUserId.Size = new System.Drawing.Size(106, 19);
            this.TxtUserId.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(33, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(27, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Subscriber:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(22, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bot-Rechte:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(29, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Moderator:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(43, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Currency:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(85, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Vip:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(57, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "UserID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(46, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Follower:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(22, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Last Online:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "DisplayName:";
            // 
            // GroupBoxUser
            // 
            this.GroupBoxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GroupBoxUser.Controls.Add(this.UserGridView);
            this.GroupBoxUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.GroupBoxUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupBoxUser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GroupBoxUser.ForeColor = System.Drawing.Color.White;
            this.GroupBoxUser.Location = new System.Drawing.Point(0, 0);
            this.GroupBoxUser.Name = "GroupBoxUser";
            this.GroupBoxUser.Size = new System.Drawing.Size(967, 702);
            this.GroupBoxUser.TabIndex = 7;
            this.GroupBoxUser.TabStop = false;
            this.GroupBoxUser.Text = "User";
            // 
            // UserGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.UserGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.UserGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.UserGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.UserGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.UserGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.UserGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UserGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.UserGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.UserGridView.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.UserGridView.Location = new System.Drawing.Point(3, 22);
            this.UserGridView.MultiSelect = false;
            this.UserGridView.Name = "UserGridView";
            this.UserGridView.ReadOnly = true;
            this.UserGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.UserGridView.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.UserGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.UserGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.UserGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.UserGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(116)))));
            this.UserGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.UserGridView.RowTemplate.Height = 25;
            this.UserGridView.RowTemplate.ReadOnly = true;
            this.UserGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserGridView.Size = new System.Drawing.Size(961, 677);
            this.UserGridView.TabIndex = 0;
            this.UserGridView.SelectionChanged += new System.EventHandler(this.UserGridView_SelectedIndexChanged);
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1348, 702);
            this.Controls.Add(this.GroupBoxUser);
            this.Controls.Add(this.GroupBox1);
            this.Name = "FormUser";
            this.Text = "FormUser";
            this.Load += new System.EventHandler(this.FormUser_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBoxUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.ComboBox PermissionBox2;
        private System.Windows.Forms.TextBox TxtDate;
        private System.Windows.Forms.TextBox TxtDisplayName;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.TextBox TxtUserId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox GroupBoxUser;
        private System.Windows.Forms.DataGridView UserGridView;
        private System.Windows.Forms.Button BtnCommandDelete;
        private System.Windows.Forms.Button BtnUserRefresh;
        private System.Windows.Forms.TextBox TxtPoints;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtSubscriber;
        private System.Windows.Forms.TextBox TxtVip;
        private System.Windows.Forms.TextBox TxtFollower;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtIsMod;
        private System.Windows.Forms.Label label10;
    }
}