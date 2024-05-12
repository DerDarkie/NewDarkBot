
namespace NewDarkBot.Forms
{
    partial class FormWoW
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtWoWApiSecret = new System.Windows.Forms.TextBox();
            this.TxtWoWApiClientId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NewDarkBot.Properties.Resources.wowlogo1;
            this.pictureBox1.Location = new System.Drawing.Point(2, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtWoWApiSecret);
            this.groupBox1.Controls.Add(this.TxtWoWApiClientId);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 256);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "World of Warcraft API-Access";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "API Secret:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "API Client Id:";
            // 
            // TxtWoWApiSecret
            // 
            this.TxtWoWApiSecret.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.TxtWoWApiSecret.ForeColor = System.Drawing.Color.White;
            this.TxtWoWApiSecret.Location = new System.Drawing.Point(198, 58);
            this.TxtWoWApiSecret.Name = "TxtWoWApiSecret";
            this.TxtWoWApiSecret.PasswordChar = '*';
            this.TxtWoWApiSecret.ReadOnly = true;
            this.TxtWoWApiSecret.Size = new System.Drawing.Size(399, 29);
            this.TxtWoWApiSecret.TabIndex = 1;
            // 
            // TxtWoWApiClientId
            // 
            this.TxtWoWApiClientId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.TxtWoWApiClientId.ForeColor = System.Drawing.Color.White;
            this.TxtWoWApiClientId.Location = new System.Drawing.Point(198, 23);
            this.TxtWoWApiClientId.Name = "TxtWoWApiClientId";
            this.TxtWoWApiClientId.ReadOnly = true;
            this.TxtWoWApiClientId.Size = new System.Drawing.Size(399, 29);
            this.TxtWoWApiClientId.TabIndex = 1;
            // 
            // FormWoW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1348, 702);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormWoW";
            this.Text = "World of Warcraft API";
            this.Load += new System.EventHandler(this.FormWoW_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtWoWApiSecret;
        private System.Windows.Forms.TextBox TxtWoWApiClientId;
    }
}