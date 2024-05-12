
namespace NewDarkBot.Forms
{
    partial class FormAccountManager
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
            this.Link1 = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.ClientId = new System.Windows.Forms.TextBox();
            this.Oauth = new System.Windows.Forms.TextBox();
            this.Channel = new System.Windows.Forms.TextBox();
            this.BotName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.APISecret = new System.Windows.Forms.TextBox();
            this.APIClientId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Link1
            // 
            this.Link1.AutoSize = true;
            this.Link1.LinkColor = System.Drawing.Color.Aqua;
            this.Link1.Location = new System.Drawing.Point(161, 308);
            this.Link1.Name = "Link1";
            this.Link1.Size = new System.Drawing.Size(252, 19);
            this.Link1.TabIndex = 24;
            this.Link1.TabStop = true;
            this.Link1.Text = "Hol Dir hier Deinen Scope Oauth Token";
            this.Link1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link1_LinkClicked);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Location = new System.Drawing.Point(420, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(325, 19);
            this.label8.TabIndex = 23;
            this.label8.Text = "Gib den Kanalnamen ein, in den Dein Bot Joinen soll";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(420, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(276, 19);
            this.label7.TabIndex = 21;
            this.label7.Text = "Gib Hier denn Accountnamen deines Bot ein";
            // 
            // BtnClear
            // 
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnClear.Image = global::NewDarkBot.Properties.Resources.close_icon2;
            this.BtnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClear.Location = new System.Drawing.Point(332, 251);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(172, 32);
            this.BtnClear.TabIndex = 20;
            this.BtnClear.Text = "Löschen";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnRefresh.Image = global::NewDarkBot.Properties.Resources.refresh2_klein;
            this.BtnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRefresh.Location = new System.Drawing.Point(161, 251);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(165, 32);
            this.BtnRefresh.TabIndex = 19;
            this.BtnRefresh.Text = "Aktualisieren";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // ClientId
            // 
            this.ClientId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClientId.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClientId.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ClientId.Location = new System.Drawing.Point(161, 154);
            this.ClientId.Name = "ClientId";
            this.ClientId.Size = new System.Drawing.Size(584, 29);
            this.ClientId.TabIndex = 18;
            // 
            // Oauth
            // 
            this.Oauth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.Oauth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Oauth.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Oauth.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Oauth.Location = new System.Drawing.Point(161, 123);
            this.Oauth.Name = "Oauth";
            this.Oauth.Size = new System.Drawing.Size(584, 29);
            this.Oauth.TabIndex = 17;
            // 
            // Channel
            // 
            this.Channel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.Channel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Channel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Channel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Channel.Location = new System.Drawing.Point(161, 91);
            this.Channel.Name = "Channel";
            this.Channel.Size = new System.Drawing.Size(253, 29);
            this.Channel.TabIndex = 16;
            // 
            // BotName
            // 
            this.BotName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.BotName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BotName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BotName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BotName.Location = new System.Drawing.Point(161, 59);
            this.BotName.Name = "BotName";
            this.BotName.Size = new System.Drawing.Size(253, 29);
            this.BotName.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(74, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Client ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(11, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Bot Oauth-Token:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(81, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Channel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(66, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Bot Name:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NewDarkBot.Properties.Resources.twitch;
            this.pictureBox1.Location = new System.Drawing.Point(8, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BotName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Link1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.BtnClear);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BtnRefresh);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Channel);
            this.groupBox1.Controls.Add(this.APISecret);
            this.groupBox1.Controls.Add(this.APIClientId);
            this.groupBox1.Controls.Add(this.ClientId);
            this.groupBox1.Controls.Add(this.Oauth);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(12, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1045, 428);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Twitch Bot-Account Daten";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(39, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "API Client ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label9.Location = new System.Drawing.Point(59, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 21);
            this.label9.TabIndex = 12;
            this.label9.Text = "API Secret:";
            // 
            // APISecret
            // 
            this.APISecret.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.APISecret.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.APISecret.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.APISecret.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.APISecret.Location = new System.Drawing.Point(161, 216);
            this.APISecret.Name = "APISecret";
            this.APISecret.Size = new System.Drawing.Size(584, 29);
            this.APISecret.TabIndex = 18;
            // 
            // APIClientId
            // 
            this.APIClientId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.APIClientId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.APIClientId.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.APIClientId.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.APIClientId.Location = new System.Drawing.Point(161, 185);
            this.APIClientId.Name = "APIClientId";
            this.APIClientId.Size = new System.Drawing.Size(584, 29);
            this.APIClientId.TabIndex = 18;
            // 
            // FormAccountManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1348, 702);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormAccountManager";
            this.Text = "Twitch Bot Account Einstellungen";
            this.Load += new System.EventHandler(this.FormAccountManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel Link1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.TextBox ClientId;
        private System.Windows.Forms.TextBox Oauth;
        private System.Windows.Forms.TextBox Channel;
        private System.Windows.Forms.TextBox BotName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox APISecret;
        private System.Windows.Forms.TextBox APIClientId;
    }
}