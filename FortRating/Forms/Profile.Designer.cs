namespace FortRating.Forms
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.ProfileInfoPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.FIOLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EditProfieButton = new Guna.UI2.WinForms.Guna2Button();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.panelAvatar = new Guna.UI2.WinForms.Guna2Panel();
            this.avatarPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ProfileInfoPanel.SuspendLayout();
            this.panelAvatar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // ProfileInfoPanel
            // 
            this.ProfileInfoPanel.BackColor = System.Drawing.Color.Transparent;
            this.ProfileInfoPanel.BorderColor = System.Drawing.Color.Black;
            this.ProfileInfoPanel.BorderRadius = 20;
            this.ProfileInfoPanel.BorderThickness = 2;
            this.ProfileInfoPanel.Controls.Add(this.FIOLabel);
            this.ProfileInfoPanel.Controls.Add(this.label1);
            this.ProfileInfoPanel.Controls.Add(this.EditProfieButton);
            this.ProfileInfoPanel.Controls.Add(this.LoginLabel);
            this.ProfileInfoPanel.Controls.Add(this.labelLogin);
            this.ProfileInfoPanel.Controls.Add(this.panelAvatar);
            this.ProfileInfoPanel.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ProfileInfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProfileInfoPanel.FillColor = System.Drawing.Color.White;
            this.ProfileInfoPanel.Location = new System.Drawing.Point(0, 0);
            this.ProfileInfoPanel.Name = "ProfileInfoPanel";
            this.ProfileInfoPanel.Size = new System.Drawing.Size(1021, 236);
            this.ProfileInfoPanel.TabIndex = 0;
            // 
            // FIOLabel
            // 
            this.FIOLabel.AutoSize = true;
            this.FIOLabel.BackColor = System.Drawing.Color.Transparent;
            this.FIOLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIOLabel.ForeColor = System.Drawing.Color.Black;
            this.FIOLabel.Location = new System.Drawing.Point(384, 119);
            this.FIOLabel.Margin = new System.Windows.Forms.Padding(0);
            this.FIOLabel.Name = "FIOLabel";
            this.FIOLabel.Size = new System.Drawing.Size(100, 39);
            this.FIOLabel.TabIndex = 14;
            this.FIOLabel.Text = "ФИО";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(254, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 39);
            this.label1.TabIndex = 13;
            this.label1.Text = "ФИО:";
            // 
            // EditProfieButton
            // 
            this.EditProfieButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EditProfieButton.BorderRadius = 5;
            this.EditProfieButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EditProfieButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EditProfieButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EditProfieButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EditProfieButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EditProfieButton.ForeColor = System.Drawing.Color.White;
            this.EditProfieButton.Location = new System.Drawing.Point(848, 178);
            this.EditProfieButton.Name = "EditProfieButton";
            this.EditProfieButton.Size = new System.Drawing.Size(144, 45);
            this.EditProfieButton.TabIndex = 12;
            this.EditProfieButton.Text = "Изменить";
            this.EditProfieButton.Click += new System.EventHandler(this.EditProfieButton_Click);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.ForeColor = System.Drawing.Color.Black;
            this.LoginLabel.Location = new System.Drawing.Point(400, 40);
            this.LoginLabel.Margin = new System.Windows.Forms.Padding(0);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(95, 39);
            this.LoginLabel.TabIndex = 11;
            this.LoginLabel.Text = "login";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.BackColor = System.Drawing.Color.Transparent;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.ForeColor = System.Drawing.Color.Black;
            this.labelLogin.Location = new System.Drawing.Point(254, 40);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(126, 39);
            this.labelLogin.TabIndex = 10;
            this.labelLogin.Text = "Логин:";
            // 
            // panelAvatar
            // 
            this.panelAvatar.AutoRoundedCorners = true;
            this.panelAvatar.BorderColor = System.Drawing.Color.Black;
            this.panelAvatar.BorderRadius = 88;
            this.panelAvatar.BorderThickness = 2;
            this.panelAvatar.Controls.Add(this.avatarPicture);
            this.panelAvatar.Location = new System.Drawing.Point(36, 30);
            this.panelAvatar.Name = "panelAvatar";
            this.panelAvatar.Padding = new System.Windows.Forms.Padding(2);
            this.panelAvatar.Size = new System.Drawing.Size(179, 179);
            this.panelAvatar.TabIndex = 9;
            // 
            // avatarPicture
            // 
            this.avatarPicture.AutoRoundedCorners = true;
            this.avatarPicture.BackColor = System.Drawing.Color.Transparent;
            this.avatarPicture.BorderRadius = 86;
            this.avatarPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.avatarPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avatarPicture.Image = ((System.Drawing.Image)(resources.GetObject("avatarPicture.Image")));
            this.avatarPicture.ImageRotate = 0F;
            this.avatarPicture.Location = new System.Drawing.Point(2, 2);
            this.avatarPicture.Name = "avatarPicture";
            this.avatarPicture.Size = new System.Drawing.Size(175, 175);
            this.avatarPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarPicture.TabIndex = 7;
            this.avatarPicture.TabStop = false;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 563);
            this.Controls.Add(this.ProfileInfoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.ProfileInfoPanel.ResumeLayout(false);
            this.ProfileInfoPanel.PerformLayout();
            this.panelAvatar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.avatarPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel ProfileInfoPanel;
        private Guna.UI2.WinForms.Guna2Panel panelAvatar;
        private Guna.UI2.WinForms.Guna2PictureBox avatarPicture;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label labelLogin;
        private Guna.UI2.WinForms.Guna2Button EditProfieButton;
        private System.Windows.Forms.Label FIOLabel;
        private System.Windows.Forms.Label label1;
    }
}